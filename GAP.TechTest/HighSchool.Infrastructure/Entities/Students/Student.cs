using System.Collections.Generic;

namespace HighSchool.Infrastructure.Entities.Students
{
    public partial class Student : BaseEntity
    {
        public Student()
        {
            Marks = new HashSet<Mark>();
        }

        public string FullName { get; set; }

        public ICollection<Mark> Marks { get; set; }
    }
}
