using MovieClub.Entity;
using MovieClub.Service.Genres.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.Persistance.Genres
{
    public class EFGenreRepository: GenreRepository
    {
        private readonly EFDataContext _context;

        public EFGenreRepository(EFDataContext context)
        {
            _context = context;
        }

        public void Add(Genre genre)
        {
            _context.Genres.Add(genre);
        }
    }
}
