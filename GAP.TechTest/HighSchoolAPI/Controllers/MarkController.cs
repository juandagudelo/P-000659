using HighSchool.Domain.DTO;
using HighSchool.Domain.DTO.Filters;
using HighSchool.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HighSchool.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MarkController : ControllerBase
    {
        private readonly IMarkService _markService;
        public MarkController(IMarkService markService)
        {
            _markService = markService;
        }

        // POST: api/Mark/GetFiltered
        [HttpPost]
        public ActionResult<List<MarkResultDTO>> GetFiltered(FilterDTO filterDTO)
        {
            return Ok(_markService.GetMarkResultsFiltered(filterDTO));
        }

       
    }
}
