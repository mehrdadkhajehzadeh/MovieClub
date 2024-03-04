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
        public static GenreAppService Create(EFDataContext context)
        {
            var repository = new EFGenreRepository(context);
            var unit = new EFUnitOfWork(context);
            return new GenreAppService(repository, unit);
        }
    }
}
