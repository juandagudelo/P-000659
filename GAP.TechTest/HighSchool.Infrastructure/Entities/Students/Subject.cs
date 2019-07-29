using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HighSchool.Infrastructure.Entities.Students
{
    public partial class Subject
    {
        public Subject()
        {
            Marks = new HashSet<Mark>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }

    }
}
