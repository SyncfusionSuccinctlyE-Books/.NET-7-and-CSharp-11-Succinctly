
using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;

namespace RateLimiting;

public class Program
{
    const string FIXED_RATE_LIMIT_POLICY = "fixed";
    const string CONCURRENT_RATE_LIMIT_POLICY = "concurrent";

    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Fixed rate limit
        builder.Services.AddRateLimiter(_ => _
        .AddFixedWindowLimiter(policyName: FIXED_RATE_LIMIT_POLICY, options =>
        {
            options.PermitLimit = 4;
            options.Window = TimeSpan.FromSeconds(20);
            options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
            options.QueueLimit = 2;
        }));

        //// Concurrent rate limit
        //builder.Services.AddRateLimiter(_ => _
        //.AddConcurrencyLimiter(policyName: CONCURRENT_RATE_LIMIT_POLICY, options =>
        //{
        //    options.PermitLimit = 4;
        //    options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
        //    options.QueueLimit = 2;
        //}));

        // Global rate limiter
        //builder.Services.AddRateLimiter(opt =>
        //{
        //    opt.RejectionStatusCode = 429;
        //    opt.GlobalLimiter =
        //    PartitionedRateLimiter.Create<HttpContext, string>(
        //        httpContext => RateLimitPartition.GetFixedWindowLimiter(
        //            partitionKey: httpContext.User.Identity?.Name ??
        //            httpContext.Request.Headers.Host.ToString(),
        //            factory: partition => new FixedWindowRateLimiterOptions
        //            {
        //                AutoReplenishment = true,
        //                PermitLimit = 4,
        //                QueueLimit = 0,
        //                Window = TimeSpan.FromSeconds(20)
        //            }));
        //});

        //// Chaining rate limiters
        //builder.Services.AddRateLimiter(opt =>
        //{
        //    opt.GlobalLimiter = PartitionedRateLimiter.CreateChained<HttpContext>(

        //        PartitionedRateLimiter.Create<HttpContext, string>(
        //        httpContext => RateLimitPartition.GetFixedWindowLimiter(
        //            partitionKey: httpContext.User.Identity?.Name ??
        //            httpContext.Request.Headers.Host.ToString(),
        //            factory: partition => new FixedWindowRateLimiterOptions
        //            {
        //                AutoReplenishment = true,
        //                PermitLimit = 100,
        //                QueueLimit = 0,
        //                Window = TimeSpan.FromMinutes(1)
        //            })),

        //        PartitionedRateLimiter.Create<HttpContext, string>(
        //        httpContext => RateLimitPartition.GetFixedWindowLimiter(
        //            partitionKey: httpContext.User.Identity?.Name ??
        //            httpContext.Request.Headers.Host.ToString(),
        //            factory: partition => new FixedWindowRateLimiterOptions
        //            {
        //                AutoReplenishment = true,
        //                PermitLimit = 1000,
        //                QueueLimit = 0,
        //                Window = TimeSpan.FromHours(1)
        //            })));
        //});

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        // Enable rate limiting middlewre
        app.UseRateLimiter();
        app.UseHttpsRedirection();
        app.UseAuthorization();
        //app.MapControllers();
        app.MapControllers().RequireRateLimiting(FIXED_RATE_LIMIT_POLICY);
        //app.MapControllers().RequireRateLimiting(CONCURRENT_RATE_LIMIT_POLICY);
        app.Run();
    }
}