namespace MinimalAPIs;
public class LoggingFilter : IEndpointFilter
{
    protected readonly ILogger _logger;
    protected LoggingFilter(ILoggerFactory loggerFac)
    {
        _logger = loggerFac.CreateLogger<LoggingFilter>();
    }
    public virtual async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        _logger.LogInformation($"Request {context.HttpContext.Request.Path} processed at {DateTime.Now}");

        var result = await next(context);

        _logger.LogInformation($"Request {context.HttpContext.Request.Path} processed at {DateTime.Now}");

        return result;
    }
}

class MinimalAPILogFilter : LoggingFilter
{
    public MinimalAPILogFilter(ILoggerFactory loggerFac) : base(loggerFac) { }
}
