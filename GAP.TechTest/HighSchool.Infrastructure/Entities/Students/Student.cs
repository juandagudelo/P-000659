using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HighSchool.Infrastructure.Entities.Students
{
    public partial class Student
    {
        public Student()
        {
            Marks = new HashSet<Mark>();
        }

        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }

        public ICollection<Mark> Marks { get; set; }
    }
}
