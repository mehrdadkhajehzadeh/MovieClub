using MovieClub.Service.Genres.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.TestTools.Genres.Factory
{
    public class CreateAddGenreDTOFactory
    {
        public static AddGenreDTO Create() 
        {
            return new AddGenreDTO()
            {
                Title = "newTitle",
            };
        }
    }
}
