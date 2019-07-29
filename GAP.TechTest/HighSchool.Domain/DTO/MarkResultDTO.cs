using System;
using System.Collections.Generic;
using System.Text;

namespace HighSchool.Domain.DTO
{
    public class MarkResultDTO
    {
        public string StudentName { get; set; }
        public List<MarkDTO> Marks { get; set; }
    }
}
