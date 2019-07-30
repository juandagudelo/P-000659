using HighSchool.Domain.DTO;
using HighSchool.Domain.DTO.Filters;
using System.Collections.Generic;

namespace HighSchool.Domain.Services.Interfaces
{
    public interface IMarkService
    {
        List<MarkResultDTO> GetMarkResultsFiltered(FilterDTO filterDTO);
    }
}
