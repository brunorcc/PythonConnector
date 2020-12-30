using System;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Primavera.Hydrogen;
using Primavera.Hydrogen.Caching.Distributed.Redis;
using Primavera.Hydrogen.Caching.Distributed.Resilience;
using Primavera.Hydrogen.Configuration;
using Primavera.Lithium.PythonConnector.WebApi.Configuration;
using Primavera.Lithium.PythonConnector.WebApi.Contracts;
using Primavera.Lithium.PythonConnector.WebApi.Managers;
using Python.Runtime;

namespace Primavera.Lithium.PythonConnector.WebApi
{
    /// <summary>
    /// Defines the base class for the application initialization logic.
    /// </summary>
    /// <seealso cref="Primavera.Lithium.PythonConnector.WebApi.StartupBase"/>
    public partial class Startup
    {
        #region Protected Methods

        /// <summary>
        /// Called when configuring services to configure additional services.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="hostConfiguration">The host configuration.</param>
        /// <remarks>The method is called from <see cref="Lithium.PythonConnector.WebApi.StartupBase.ConfigureServices(IServiceCollection)"/>.</remarks>
        protected override void AddAdditionalServices(IServiceCollection services, HostConfiguration hostConfiguration)
        {
            base.AddAdditionalServices(services, hostConfiguration);

            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = int.MaxValue;
                x.MultipartBodyLengthLimit = int.MaxValue; // In case of multipart
            });

            services.AddSingleton<IPythonManager, PythonManager>();

            string pythonPath = @"C:\python38";

            Environment.SetEnvironmentVariable("PATH", $@"{pythonPath};C:\python38" + Environment.GetEnvironmentVariable("PATH"));
            Environment.SetEnvironmentVariable("PYTHONHOME", pythonPath);

            Environment.SetEnvironmentVariable("PYTHONPATH ", $@"{pythonPath}\Lib;C:\python38\Lib");

            PythonEngine.PythonHome = Environment.GetEnvironmentVariable("PYTHONHOME", EnvironmentVariableTarget.Process);
            PythonEngine.PythonPath = Environment.GetEnvironmentVariable("PYTHONPATH", EnvironmentVariableTarget.Process);

            if (!PythonEngine.IsInitialized)
            {
                PythonEngine.Initialize();
                PythonEngine.BeginAllowThreads();
            }
        }

        #endregion
    }
}
