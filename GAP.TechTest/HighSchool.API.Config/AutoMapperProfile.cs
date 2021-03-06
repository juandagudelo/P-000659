﻿using AutoMapper;
using HighSchool.Domain.DTO;
using HighSchool.Infrastructure.Entities.Students;

namespace HighSchool.API.Config
{
    class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Mark, MarkDTO>()
               .ForMember(dest => dest.SubjectName, source => source.MapFrom(prop => prop.Subject.Name))
               .ForMember(dest => dest.StudentName, source => source.MapFrom(prop => prop.Student.FullName))
               .ReverseMap();

            CreateMap<Subject, SubjectDTO>()
               .ReverseMap();
        }


    }
}
