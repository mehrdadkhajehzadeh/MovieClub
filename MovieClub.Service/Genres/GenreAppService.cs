using MovieClub.Contracts;
using MovieClub.Entity;
using MovieClub.Service.Genres.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.Service.Genres
{
    public class GenreAppService : GenreService
    {
        private readonly GenreRepository _repository;
        private readonly UnitOfWork _unitOfWork;
        private readonly DateTimeService _dateTimeService;
        public GenreAppService(GenreRepository repository, UnitOfWork unitOfWork, DateTimeService dateTimeService)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _dateTimeService = dateTimeService;
        }

        public async Task Add(AddGenreDTO dto)
        {
            var genre = new Genre(dto.Title);
            _repository.Add(genre);
            await _unitOfWork.Complete();
        }
    }
}
