using HighSchool.Infrastructure.Entities.Students;
using HighSchool.Infrastructure.Repositories.Base;
using System.Linq;

namespace HighSchool.Infrastructure.Repositories.Interfaces
{
    public interface IMarkRepository : IRepository<Mark>
    {
        IQueryable<Mark> FilterByScoreBiggerThanValue(int value);
        IQueryable<Mark> FilterByStudentName(string studentName);
        IQueryable<Mark> FilterBySubjectName(string subjectName);
    }
}
