using HighSchool.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace HighSchool.Domain.Services.Interfaces
{
    public interface ISubjectService
    {
        List<SubjectDTO> GetAll();
    }
}
