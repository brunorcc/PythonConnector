# <a name="root"></a>PRIMAVERA Lithium Python Connector Service (PCS) Client Library

Python connector Service.

## Service Client

| Class | Description |
| - | - |
| [`PythonConnectorClient`](#PythonConnectorClient) | The entry point of the Python Connector Service client library. |

## Operations

| Class | Name | Description |
| - | - | - |
| [`PythonConnector`](#PythonConnectorOperations) | Python Connector | The python connector controller. |

## Models

| Class | Name | Description |
| - | - | - |
| [`InputData`](#InputData) | Input Data | The input data. |
| [`OutputData`](#OutputData) | Output Data | The output data. |

## Enumerations

The client library has no enumerations.

## Reference

### Service Client Classes

#### <a name="PythonConnectorClient"></a>`PythonConnectorClient`

- Namespace: `Primavera.Lithium.PythonConnector`
- Inheritance: `PythonConnectorClientBase` (`ServiceClient<PythonConnectorClientBase>`)

##### Constructors

###### PythonConnectorClient(Uri, ServiceClientCredentials)

| Parameter | Type | Description |
| - | - | - |
| `baseUri` | `Uri` | The base URI of the service. |
| `credentials` | `ServiceClientCredentials` | The credentials that should be used to access the service. |

###### PythonConnectorClient(Uri, ServiceClientCredentials, HttpMessageHandler)

| Parameter | Type | Description |
| - | - | - |
| `baseUri` | `Uri` | The base URI of the service. |
| `credentials` | `ServiceClientCredentials` | The credentials that should be used to access the service. |
| `handler` | `HttpMessageHandler` | The root message handler. |

###### PythonConnectorClient(Uri, ServiceClientCredentials, HttpMessageHandler, bool)

| Parameter | Type | Description |
| - | - | - |
| `baseUri` | `Uri` | The base URI of the service. |
| `credentials` | `ServiceClientCredentials` | The credentials that should be used to access the service. |
| `handler` | `HttpMessageHandler` | The root message handler. |
| `disposeHandler` | `bool` | True if the inner handler should be disposed of, false if the inner handler is intended to be reused. |

###### PythonConnectorClient(Uri, AuthenticationCallback)

| Parameter | Type | Description |
| - | - | - |
| `baseUri` | `Uri` | The base URI of the service. |
| `callback` | `AuthenticationCallback` | The callback that will be invoked during authentication to get the access token. |

###### PythonConnectorClient(Uri, AuthenticationCallback, HttpMessageHandler)

| Parameter | Type | Description |
| - | - | - |
| `baseUri` | `Uri` | The base URI of the service. |
| `callback` | `AuthenticationCallback` | The callback that will be invoked during authentication to get the access token. |
| `handler` | `HttpMessageHandler` | The root message handler. |

###### PythonConnectorClient(Uri, AuthenticationCallback, HttpMessageHandler, bool)

| Parameter | Type | Description |
| - | - | - |
| `baseUri` | `Uri` | The base URI of the service. |
| `callback` | `AuthenticationCallback` | The callback that will be invoked during authentication to get the access token. |
| `handler` | `HttpMessageHandler` | The root message handler. |
| `disposeHandler` | `bool` | True if the inner handler should be disposed of, false if the inner handler is intended to be reused. |

##### Properties

| Property | Type | Description |
| - | - | - |
| `AcceptLanguage` | `string` | Gets or sets the preferred language for the response. |

##### Methods

###### SetRetryPolicy(RetryPolicy

Sets the retry policy.

| Parameter | Type | Description |
| - | - | - |
| `retryPolicy` | `RetryPolicy` | The new retry policy. |

###### SetUserAgent(string, string, string

Sets the user agent header when making requests to the service.

| Parameter | Type | Description |
| - | - | - |
| `productName` | `string` | The product name. |
| `version` | `string` | The version. |
| `info` | `string` | Additional information. |

##### Example

```csharp
Uri address = new Uri("[service-address]");

using PythonConnectorClient client = new PythonConnectorClient(
    new Uri(address),
    ClientCredentials.NoCredentials);
```

[^ Back to top](#root)

### Operations Classes

#### <a name="PythonConnectorOperations"></a>`PythonConnectorOperations`

The python connector controller.

- Namespace: `Primavera.Lithium.PythonConnector`
- Inheritance: `PythonConnectorOperationsBase` (`IPythonConnectorOperations`)

##### Methods

##### `GetResultAsync()`

The python connector get result.

```csharp
public async Task<ServiceOperationResult<IEnumerable<OutputData>>> GetResultAsync(IEnumerable<InputData> inputData, CancellationToken cancellationToken = default);
```

###### Parameters

| Parameter | Type | Description | Rules |
| - | - | - | - |
| `inputData` | `IEnumerable<InputData>` | The input data. | Required.  |


###### Returns

| Return Type | Description |
| - | - | - | - |
| `IEnumerable<Primavera.Lithium.PythonConnector.Models.OutputData>` | Returns the output data. |


###### Status Codes

| Status Code | Description |
| - | - | - | - |
| `HttpStatusCode.Ok` | Success. |
| `HttpStatusCode.BadRequest` | Failure: the request is invalid.|

> The operation will raise `ServiceException` for any failure status code. The exception may include a body with a `ServiceError` depending on the status code.


[^ Back to top](#root)

### Models Classes

#### <a name="InputData"></a>`InputData`

The input data.

- Namespace: `Primavera.Lithium.PythonConnector.Models`
- Inheritance: `InputDataBase`

##### Properties

| Property | Type | Description | Rules |
| - | - | - | - |
| `Key` | `string` | Input data key. | Required.  |
| `Date` | `string` | Input data date. | Required.  |
| `Value` | `double` | Input data value. |  |

[^ Back to top](#root)

#### <a name="OutputData"></a>`OutputData`

The output data.

- Namespace: `Primavera.Lithium.PythonConnector.Models`
- Inheritance: `OutputDataBase`

##### Properties

| Property | Type | Description | Rules |
| - | - | - | - |
| `Key` | `string` | Output data key. | Required.  |
| `StartTime` | `string` | Output data start time. | Required.  |
| `EndTime` | `string` | Output data end time. | Required.  |
| `AnomalyType` | `string` | Output data anomaly type. | Required.  |
| `AnomalyScore` | `double` | Output data anomaly score. |  |
| `DispersionScore` | `double` | Output data dispersion score. |  |
| `ConfidenceLevel` | `double` | Output data confidence level. |  |
| `GlobalIntensity` | `double` | Output data global intensity. |  |
| `MovingIntensity` | `double` | Output data moving intensity. |  |
| `WeightedMovingIntensity` | `double` | Output data weighted moving intensity. |  |
| `Correlations` | `string` | Output data correlations. | Required.  |
| `Polarity` | `double` | Output data polarity. |  |

[^ Back to top](#root)

