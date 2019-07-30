using HighSchool.Infrastructure.Entities.Students;
using HighSchool.Infrastructure.Repositories.Base;
using HighSchool.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HighSchool.Infrastructure.Repositories
{
    public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}