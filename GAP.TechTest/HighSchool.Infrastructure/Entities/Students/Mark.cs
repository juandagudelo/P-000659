using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HighSchool.Infrastructure.Entities.Students
{
    public partial class Mark
    {
        [Key]
        public int Id { get; set; }

        public int Score { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }

        public Subject Subject { get; set; }
        public Student Student { get; set; }
    }
}
