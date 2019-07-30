using System.Collections.Generic;
using AutoMapper;
using HighSchool.Domain.DTO;
using HighSchool.Domain.Services.Interfaces;
using HighSchool.Infrastructure.Repositories.Interfaces;

namespace HighSchool.Domain.Services
{
    public class SubjectService : ISubjectService
    {
        private ISubjectRepository _subjectRepository;
        private IMapper _mapper;

        public SubjectService(ISubjectRepository subjectRepository, IMapper mapper)
        {
            _subjectRepository = subjectRepository;
            _mapper = mapper;
        }

        public List<SubjectDTO> GetAll()
        {
            return _mapper.Map<List<SubjectDTO>>(_subjectRepository.GetAll());
        }
    }
}
