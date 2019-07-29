using HighSchool.Domain.DTO;
using HighSchool.Domain.DTO.Filters;
using System.Collections.Generic;

namespace HighSchool.Domain.Services
{
    public interface IMarkService
    {
        List<MarkDTO> GetMarkResultsFiltered(FilterDTO filterDTO);
    }
}
