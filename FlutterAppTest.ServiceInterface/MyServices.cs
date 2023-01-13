using ServiceStack;
using FlutterAppTest.ServiceModel;

namespace FlutterAppTest.ServiceInterface;

public class MyServices : Service
{
    public object Any(Hello request)
    {
        return new HelloResponse { Result = $"Hello, {request.Name}!" };
    }
}