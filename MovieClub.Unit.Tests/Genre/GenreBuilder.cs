using MovieClub.Entity;

namespace VideoClub.Test.Tools.Genres
{
    public class GenreBuilder
    {
        private readonly Genre genre;
        public GenreBuilder()
        {
            genre = new Genre()
           {
               Id = 1,
               Rate = 1,
               Title = "nummy-Title",
           };
        }
        public GenreBuilder WithTitle(string title)
        {
            genre.Title = title;
            return this;
        }
        public Genre Build()
        {
            return genre;
        }
    }
}
