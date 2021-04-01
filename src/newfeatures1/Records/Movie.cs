namespace newfeatures1
{
    public record Movie
    {
        public string Title { get; set; }
        public int Rating { get; set; }
    }
    
    public record TvSeries : Movie
    {
        public int SeasonsNumber { get; set; }
    }
}