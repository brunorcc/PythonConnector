using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Primavera.Hydrogen;
using Primavera.Lithium.PythonConnector.Models;

namespace Primavera.Lithium.PythonConnector.WebApi.Contracts
{
    /// <summary>
    /// python manager interface.
    /// </summary>
    public interface IPythonManager
    {
        /// <summary>
        /// Returns the output data.
        /// </summary>
        /// <param name="inputData">The input data.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task<OperationResult<IEnumerable<OutputData>>> GetOutputAsync(IEnumerable<InputData> inputData);
    }
}
