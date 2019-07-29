using System;
using System.Collections.Generic;
using System.Text;

namespace HighSchool.Domain.DTO
{
    public class MarkDTO
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int Score { get; set; }
    }
}
