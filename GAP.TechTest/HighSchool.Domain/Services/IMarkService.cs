using HighSchool.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace HighSchool.Domain.Services
{
    public interface IMarkService
    {
        List<MarkDTO> GetMarkResultsFiltered();
    }
}
