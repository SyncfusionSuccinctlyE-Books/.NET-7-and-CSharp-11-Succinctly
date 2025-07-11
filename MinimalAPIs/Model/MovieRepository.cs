namespace MinimalAPIs.Model
{
    public class MovieRepository : IMovieRepository
    {
        private static List<MovieItem>? _allMovieItems;
        public void AddMovieItem(MovieItem movieItem)
        {
            _allMovieItems?.Add(movieItem);
        }

        public List<MovieItem>? GetAllMovieItems()
        {
            if (_allMovieItems == null)
            {
                InitializeData();
            }

            return _allMovieItems;
        }

        private void InitializeData()
        {
            _allMovieItems = new List<MovieItem>()
                {
                    new MovieItem(){Title = "Movie 1", Description="Movie 1 description.", Watched=true },
                    new MovieItem(){Title = "Movie 2", Description="Movie 2 description."},
                    new MovieItem(){Title = "Movie 3", Description="Movie 3 description.", Watched=true},
                    new MovieItem(){Title = "Movie 4", Description="Movie 4 description."}
                };
        }
    }
}
