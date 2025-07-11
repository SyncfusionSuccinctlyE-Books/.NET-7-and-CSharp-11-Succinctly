
using MinimalAPIs;
using MinimalAPIs.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthorization();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

#region Endpoint Filters On Each Endpoint
app.MapGet("/movies", (IMovieRepository movieRepo) =>
{
    return movieRepo.GetAllMovieItems();
}).AddEndpointFilter(async (context, next) =>
{
    app.Logger.LogInformation($"Request {context.HttpContext.Request.Path} processed at {DateTime.Now}");

    var result = await next(context);

    app.Logger.LogInformation($"Request {context.HttpContext.Request.Path} processed at {DateTime.Now}");

    return result;
});

app.MapPost("/movies", (MovieItem movieItem, IMovieRepository movieRepo) =>
{
    if (movieItem is null) return Results.BadRequest();
    if (string.IsNullOrEmpty(movieItem.Title)) return Results.BadRequest();

    movieRepo.AddMovieItem(movieItem);

    return Results.Ok();

}).AddEndpointFilter(async (context, next) =>
{
    app.Logger.LogInformation($"POST Request {context.HttpContext.Request.Path} processed at {DateTime.Now}");

    var result = await next(context);

    app.Logger.LogInformation($"POST Request {context.HttpContext.Request.Path} processed at {DateTime.Now}");

    return result;
});
#endregion

#region Endpoint Filters using the Generic AddEndpointFilter Implementation
//app.MapGet("/movies", (IMovieRepository movieRepo) =>
//{
//return movieRepo.GetAllMovieItems();
//}).AddEndpointFilter<MinimalAPILogFilter>();

//app.MapPost("/movies", (MovieItem movieItem, IMovieRepository movieRepo) =>
//{
//    if (movieItem is null) return Results.BadRequest();
//    if (string.IsNullOrEmpty(movieItem.Title)) return Results.BadRequest();

//    movieRepo.AddMovieItem(movieItem);

//    return Results.Ok();

//}).AddEndpointFilter<MinimalAPILogFilter>(); 
#endregion

#region Endpoint Filters using Route Groups
//var groupedLogging = app.MapGroup("/api").AddEndpointFilter(async (context, next) =>
//{
//app.Logger.LogInformation($"Request {context.HttpContext.Request.Path} processed at {DateTime.Now}");

//var result = await next(context);

//app.Logger.LogInformation($"Request {context.HttpContext.Request.Path} processed at {DateTime.Now}");

//return result;
//});


//groupedLogging.MapGet("/movies", (IMovieRepository movieRepo) =>
//{
//    return movieRepo.GetAllMovieItems();
//});

//groupedLogging.MapPost("/movies", (MovieItem movieItem, IMovieRepository movieRepo) =>
//{
//    if (movieItem is null) return Results.BadRequest();
//    if (string.IsNullOrEmpty(movieItem.Title)) return Results.BadRequest();

//    movieRepo.AddMovieItem(movieItem);

//    return Results.Ok();
//}); 
#endregion


app.Run();
