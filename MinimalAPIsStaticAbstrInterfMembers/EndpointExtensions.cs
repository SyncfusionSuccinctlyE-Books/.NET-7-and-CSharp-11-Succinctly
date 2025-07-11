namespace MinimalAPIsStaticAbstrInterfMembers;
public static class EndpointExtensions
{
    public static IEndpointRouteBuilder MapEndPoint<T>(this IEndpointRouteBuilder app) where T : IEndpoint 
    {
        app.MapMethods(
            T.Pattern
            , new[] { T.Method.ToString() }
            , T.Handler
            );
        return app;
    }
}
