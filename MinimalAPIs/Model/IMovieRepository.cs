namespace MinimalAPIs.Model
{
    public interface IMovieRepository
    {
        List<MovieItem>? GetAllMovieItems();
        void AddMovieItem(MovieItem movieItem);
    }
}
