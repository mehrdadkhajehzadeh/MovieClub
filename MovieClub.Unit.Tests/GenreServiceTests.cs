using FluentAssertions;
using MovieClub.Persistance;
using MovieClub.TestTools.DatabaseConfig.Unit;
using MovieClub.TestTools.Genres.Factory;

namespace MovieClub.Unit.Tests
{
    public class GenreServiceTests
    { 
        private readonly EFInMemoryDatabase db;
        private readonly EFDataContext context;
        private readonly EFDataContext readContext;
        public GenreServiceTests()
        {
             db = new EFInMemoryDatabase();
             context = db.CreateDataContext<EFDataContext>();
             readContext = db.CreateDataContext<EFDataContext>();
        } 
        [Fact]
        public async void Add_Should_Be_Save_One_Genre()
        {
            var sut=CreateGenreServiceFactory.Create(context);
            var dto = CreateAddGenreDTOFactory.Create(); 

            await sut.Add(dto);

            var actual=readContext.Genres.SingleOrDefault();
            actual.Title.Should().Be(dto.Title);
            actual.Rate.Should().Be(0);
        }
    }
}