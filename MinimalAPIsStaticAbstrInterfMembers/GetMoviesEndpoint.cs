using MinimalAPIs.Model;

namespace MinimalAPIsStaticAbstrInterfMembers;
public class GetMoviesEndpoint : IEndpoint
{
    public static string Pattern => "movies";

    public static HttpMethod Method => HttpMethod.Get;

    public static Delegate Handler => GetMovies;
            
    private static IResult GetMovies(IMovieRepository repo)
    {            
        return Results.Ok(repo.GetAllMovieItems());
    }
}
