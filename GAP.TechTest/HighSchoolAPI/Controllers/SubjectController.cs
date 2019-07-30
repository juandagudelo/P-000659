using HighSchool.Domain.DTO;
using HighSchool.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HighSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService _subjectService;
        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        // GET: api/Subject
        [HttpGet]
        public ActionResult<List<SubjectDTO>> Get()
        {
            return Ok(_subjectService.GetAll());
        }
    }
}