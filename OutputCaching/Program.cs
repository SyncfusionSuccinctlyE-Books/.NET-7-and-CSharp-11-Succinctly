
namespace OutputCaching;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Add output cache in the services collection
        builder.Services.AddOutputCache(opt =>
        {
            opt.DefaultExpirationTimeSpan = TimeSpan.FromSeconds(5);
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();
        // Add middelware for Output Caching
        app.UseOutputCache();
        // Add CacheOutput for Output Caching to work
        //app.MapControllers().CacheOutput();

        app.MapControllers().CacheOutput(policy =>
        {
            policy.SetVaryByQuery("days");

            //policy.SetVaryByRouteValue(new string[] { "years" });

            policy.Expire(TimeSpan.FromSeconds(5));
        });

        app.Run();
    }
}