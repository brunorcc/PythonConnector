using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Primavera.Hydrogen;
using Primavera.Hydrogen.Rest.Client;
using Primavera.Lithium.PythonConnector.Models;

namespace Primavera.Lithium.PythonConnector.Client.Console
{
    /// <summary>
    /// Defines the type that implements the application.
    /// </summary>
    /// <seealso cref="Primavera.Lithium.PythonConnector.Client.Console.ApplicationBase"/>
    internal sealed partial class Application
    {
        /// <inheritdoc/>
        protected override void PrintCustomMenuOptions()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        protected override Task<bool> HandleCustomMenuOptionsAsync(ConsoleKeyInfo key)
        {
            throw new NotImplementedException();
        }
    }
}
