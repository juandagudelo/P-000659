using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HighSchool.Infrastructure.Entities.Students
{
    public partial class Student
    {
        [Key]
        public string Id { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
    }
}
