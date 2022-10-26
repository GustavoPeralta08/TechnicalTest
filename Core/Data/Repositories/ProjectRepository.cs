using Core.Data.Domain.TechnicalDbModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Core.Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        #region Private and protected properties

        private readonly TechnicalTestDBContext _dbContext;
        private readonly DbSet<Project> _entities;

        #endregion

        #region Constructor

        public ProjectRepository(TechnicalTestDBContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<Project>();
        }

        #endregion

        public IEnumerable<Project> GetProjects()
        {
         
            return _entities.Include(x=> x.Country)
                .Include(y=> y.State)
                .Include(c=> c.Tech);
        }
    }
}