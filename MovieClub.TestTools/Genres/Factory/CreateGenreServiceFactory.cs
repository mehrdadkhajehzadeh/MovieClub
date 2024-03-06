using Moq;
using MovieClub.Contracts;
using MovieClub.Persistance;
using MovieClub.Persistance.Genres;
using MovieClub.Service.Genres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.TestTools.Genres.Factory
{
    public class CreateGenreServiceFactory
    {
        public static GenreAppService Create(EFDataContext context, DateTime? fakeTime = null)
        {
            var repository = new EFGenreRepository(context);
            var unit = new EFUnitOfWork(context);
            var dateTimeServiceMock = new Mock<DateTimeService>();
            dateTimeServiceMock.Setup(_ => _.Now()).Returns(fakeTime ?? new DateTime(2023, 10, 10));
            return new GenreAppService(repository, unit, dateTimeServiceMock.Object);
        }
    }
}
