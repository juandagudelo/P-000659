using System.Collections.Generic;

namespace HighSchool.Infrastructure.Entities.Students
{
    public partial class Subject : BaseEntity
    {
        public Subject()
        {
            Marks = new HashSet<Mark>();
        }

        public string Name { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }

    }
}
