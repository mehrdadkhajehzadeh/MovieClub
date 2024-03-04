using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.Service.Genres.Contracts
{
    public interface GenreService
    {
        Task Add(AddGenreDTO dto);
    }
}
