using HighSchool.Domain.DTO;
using HighSchool.Domain.DTO.Filters;
using HighSchool.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HighSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkController : ControllerBase
    {
        private readonly IMarkService _markService;
        public MarkController(IMarkService markService)
        {
            _markService = markService;
        }

        // GET: api/Mark
        [HttpPost]
        [ActionName("FilterData")]
        public ActionResult<List<MarkDTO>> FilterData(FilterDTO filterDTO)
        {
            return Ok(_markService.GetMarkResultsFiltered(filterDTO));
        }

       
    }
}
