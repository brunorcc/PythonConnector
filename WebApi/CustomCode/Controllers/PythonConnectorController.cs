using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Primavera.Hydrogen;
using Primavera.Lithium.PythonConnector.Models;
using Primavera.Lithium.PythonConnector.WebApi.Contracts;

namespace Primavera.Lithium.PythonConnector.WebApi.Controllers
{
    /// <summary>
    /// PythonConnectorController Controller.
    /// </summary>
    /// <seealso cref="PythonConnectorController"/>
    public partial class PythonConnectorController
    {
        #region Members

        /// <summary>
        /// The table python manager.
        /// </summary>
        private IPythonManager pythonManager;

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets the digital archive manager.
        /// </summary>
        /// <value>The digital archive manager.</value>
        private IPythonManager PythonManager
        {
            get
            {
                if (this.pythonManager == null)
                {
                    this.pythonManager = this.HttpContext.RequestServices.GetRequiredService<IPythonManager>();
                }

                return this.pythonManager;
            }
        }

        #endregion

        /// <inheritdoc/>
        protected override async Task<IActionResult> GetResultCoreAsync(IEnumerable<InputData> inputData)
        {
            OperationResult<IEnumerable<OutputData>> readResult = await this.PythonManager.GetOutputAsync(inputData).ConfigureAwait(false);

            return this.Ok(readResult.Data);
        }
    }
}
