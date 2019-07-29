using AutoMapper;
using HighSchool.Domain.DTO;
using HighSchool.Domain.DTO.Filters;
using HighSchool.Infrastructure.Entities.Students;
using HighSchool.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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

        public List<MarkDTO> GetMarkResultsFiltered(FilterDTO filterDTO)
        {
            IQueryable<Mark> data = _markRepository.GetAll();

            if (filterDTO.Score > 0)
            {
                data = data.Where(p=> p.Score > filterDTO.Score);
            }

            if (!string.IsNullOrEmpty(filterDTO.StudentName))
            {
                data = data.Where(p => p.Student.FullName.ToLower().Contains(filterDTO.StudentName.ToLower()));

            }

            if (!string.IsNullOrEmpty(filterDTO.SubjectName))
            {
                data = data.Where(p => p.Subject.Name.ToLower().Contains(filterDTO.SubjectName.ToLower()));

            }

            return _mapper.Map<List<MarkDTO>>(data);
        }

        
    }
}
