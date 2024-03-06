using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.Entity
{
    public class Genre
    {
        public Genre()
        {
        }

        public Genre(string title)
        {
            Title = title;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int Rate { get; set; } = 0;
    }
}
