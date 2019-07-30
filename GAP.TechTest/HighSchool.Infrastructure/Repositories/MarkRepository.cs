using HighSchool.Infrastructure.Entities.Students;
using HighSchool.Infrastructure.Repositories.Base;
using HighSchool.Infrastructure.Repositories.Interfaces;
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
            return GetAll().Where(p => p.Score > value);
        }

        public IQueryable<Mark> FilterByStudentName(string studentName)
        {
            return GetAll().Where(p => p.Student.FullName.Contains(studentName));
        }

        public IQueryable<Mark> FilterBySubjectName(string subjectName)
        {
            return GetAll().Where(p => p.Subject.Name.Contains(subjectName));
        }


        public override IQueryable<Mark> GetAll()
        {
            return Table
                .Include(relation => relation.Student)
                .Include(relation => relation.Subject);
        }

    }
}
