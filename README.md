# Istio
.NET Standard 2.1 library that provides abstractions and default implementations to manage Istio thanks to an [IKubernetes client](https://github.com/kubernetes-client/csharp)

**WORK IN PROGRESS**

# Usage

[Nuget Package](https://www.nuget.org/packages/Neuroglia.Istio/)

```
  dotnet add package Neuroglia.Istio
```

## Sample Code

### Create a new Virtual Service

```c#
    V1ObjectMeta metadata = new V1ObjectMeta(name: "test-vs");
    VirtualServiceSpec spec = new VirtualServiceSpec()
    {
        Hosts = new List<string>() { "test" },
        Http = new List<HttpRoute>() 
        { 
            new HttpRoute()
            {
                Headers = new Headers()
                {
                    Request = new HeadersOperations()
                    {
                        Add = new Dictionary<string, string>()
                        {
                            { "x-custom-header", "Added by test-vs" }
                        }
                    }
                },
                Route = new List<HttpRouteDestination>()
                {
                    new HttpRouteDestination()
                    {
                        Destination = new Destination("test")
                        {
                            Port = new PortSelector(80)
                        }
                    }
                }
            } 
        }
    };
    VirtualService virtualService = new VirtualService(metadata, spec);
    await this.KubernetesClient.CreateNamespacedCustomObjectAsync(virtualService, broker.Namespace());
```

# Contributing

Please see [CONTRIBUTING.md](https://github.com/neuroglia-io/K8s/blob/master/CONTRIBUTING.md) for instructions on how to contribute.
