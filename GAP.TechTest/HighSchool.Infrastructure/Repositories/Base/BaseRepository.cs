using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HighSchool.Infrastructure.Repositories.Base
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        public DbContext DataBaseConnection;
        public DbSet<T> Table;

        public BaseRepository(DbContext dbContext)
        {
            DataBaseConnection = dbContext;
            Table = DataBaseConnection.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return Table;
        }
    }
}
