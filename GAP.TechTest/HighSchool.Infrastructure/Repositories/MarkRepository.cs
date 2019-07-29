using HighSchool.Infrastructure.Entities.Students;
using HighSchool.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HighSchool.Infrastructure.Repositories
{
    public class MarkRepository : BaseRepository<Mark>, IMarkRepository
    {
        public MarkRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public IQueryable<Mark> FilterByScoreBiggerThanValue(int value)
        {
            return Table.Where(p => p.Score > value);
        }

        public IQueryable<Mark> FilterByStudentName(string studentName)
        {
            return Table.Where(p => p.Student.FullName.Contains(studentName));
        }

        public IQueryable<Mark> FilterBySubjectName(string subjectName)
        {
            return Table.Where(p => p.Subject.Name.Contains(subjectName));
        }
    }
}
