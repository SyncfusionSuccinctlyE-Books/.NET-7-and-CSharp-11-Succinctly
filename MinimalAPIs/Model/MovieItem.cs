namespace MinimalAPIs.Model
{
    public class MovieItem
    {
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool Watched { get; set; }
    }
}
