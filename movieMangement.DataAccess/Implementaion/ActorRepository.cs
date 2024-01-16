using Microsoft.EntityFrameworkCore;
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
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(MovieManagementDBContext dbContext) : base(dbContext)
        {
           
        }

        public IEnumerable<Actor> GetActorsWithMovies()
        {
            var actorsWithmovies=_dbContext.Actors.Include(x => x.Movies).ToList();
            return actorsWithmovies;
        }
    }
}
