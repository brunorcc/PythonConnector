using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Primavera.Hydrogen;
using Primavera.Lithium.PythonConnector.Models;
using Primavera.Lithium.PythonConnector.WebApi.Contracts;
using Python.Runtime;

namespace Primavera.Lithium.PythonConnector.WebApi.Managers
{
    /// <summary>
    /// Python manager.
    /// </summary>
    /// <seealso cref="Primavera.Lithium.PythonConnector.WebApi.Contracts.IPythonManager"/>
    public class PythonManager : IPythonManager
    {
        /// <inheritdoc/>
        public async Task<OperationResult<IEnumerable<OutputData>>> GetOutputAsync(IEnumerable<InputData> inputData)
        {
            List<OutputData> response = new List<OutputData>();
            using (Py.GIL())
            {
                dynamic pd = Py.Import("pandas");
                dynamic json = Py.Import("json");
                
                dynamic ads = Py.Import("primavera.carbon.pcs.applications.standalone");
                string inputStr = JsonSerializer.Serialize(inputData, new JsonSerializerOptions { PropertyNamingPolicy = null });

                dynamic jsonObj = json.loads(inputStr);
                dynamic dataframe = pd.json_normalize(jsonObj);
                
                dataframe["date"] = pd.to_datetime(dataframe["date"]);
                Console.WriteLine(dataframe);

                string results = ads.calculate_anomalies(inputStr, @"D:\Teste\standalone_results_exemplo_3_timeseries.csv", @"D:\Teste\input.json");
                JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                response = JsonSerializer.Deserialize<List<OutputData>>(results, options);
            }

            return await Task.FromResult(OperationResult<IEnumerable<OutputData>>.Success(response)).ConfigureAwait(false);
        }
    }
}
