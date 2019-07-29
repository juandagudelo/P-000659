using AutoMapper;
using HighSchool.Domain.DTO;
using HighSchool.Infrastructure.Entities.Students;
using HighSchool.Infrastructure.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace HighSchool.Domain.Services
{
    public class MarkService : IMarkService
    {
        private IMarkRepository _markRepository;
        private IMapper _mapper;

        public MarkService(IMarkRepository markRepository, IMapper mapper)
        {
            _markRepository = markRepository;
            _mapper = mapper;
        }

        public List<MarkDTO> GetMarkResultsFiltered()
        {
            IQueryable<Mark> data = _markRepository.GetAll();
            return _mapper.Map<List<MarkDTO>>(data);
        }
    }
}
