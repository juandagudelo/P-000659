using System.Linq;

namespace HighSchool.Infrastructure.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
    }
}
