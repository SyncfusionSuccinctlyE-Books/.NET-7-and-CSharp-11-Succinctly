using Microsoft.AspNetCore.Mvc.Filters;

namespace GenericAttributes;
public class LogFilter : IAsyncActionFilter
{
    public ILogger<LogFilter> _logger;

    public LogFilter(ILogger<LogFilter> logger) => _logger = logger;

    public async Task OnActionExecutionAsync(
        ActionExecutingContext context, 
        ActionExecutionDelegate next)
    {
        _logger.LogInformation("Action started");
        await next();
        _logger.LogInformation("Action ended");
    }
}
