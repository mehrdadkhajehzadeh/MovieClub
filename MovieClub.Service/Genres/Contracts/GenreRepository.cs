using MovieClub.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.Service.Genres.Contracts
{
    public interface GenreRepository
    {
        void Add(Genre genre);
    }
}
