using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Primavera.Lithium.PythonConnector.WebApi.Controllers
{
    /// <summary>
    /// Monitoring Controller.
    /// </summary>
    /// <seealso cref="Primavera.Lithium.PythonConnector.WebApi.Controllers.MonitoringController"/>
    public partial class MonitoringController
    {
        #region Public Methods

        /// <summary>
        /// Provides an action that diagnoses the service. This action is use to perform functional
        /// tests on the service.
        /// </summary>
        /// <returns>The action result.</returns>
        /// <remarks>Success: status code is <see cref="HttpStatusCode.OK"/>.</remarks>
        public override async Task<IActionResult> DiagnosticsAsync()
        {
            return await Task.FromResult(this.Ok("OK")).ConfigureAwait(false);
        }

        /// <summary>
        /// Provides an action that probes the service. This action is used to check if the service
        /// is running.
        /// </summary>
        /// <returns>The action result.</returns>
        /// <remarks>Success: status code is <see cref="HttpStatusCode.OK"/>.</remarks>
        public override Task<IActionResult> ProbeAsync()
        {
            return this.DiagnosticsAsync();
        }

        #endregion
    }
}