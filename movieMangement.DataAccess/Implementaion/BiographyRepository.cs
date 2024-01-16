using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.DataAccess.Implementaion
{
    public class BiographyRepository : GenericRepository<Biography>, IBiographyRepository
    {
        public BiographyRepository(MovieManagementDBContext dbContext) : base(dbContext)
        {
        }
    }
}
