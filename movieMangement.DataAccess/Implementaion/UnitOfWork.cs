using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.DataAccess.Implementaion
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly MovieManagementDBContext _dBContext;

        public UnitOfWork(MovieManagementDBContext dBContext)
        {
            _dBContext = dBContext;
            ActorRepository = new ActorRepository(_dBContext);
            MovieRepository = new MovieRepository(_dBContext);
            GenreRepository=new GenreRepository(_dBContext);
            BiographyRepository = new BiographyRepository(_dBContext);
        }
        public IActorRepository ActorRepository { get; private set; }
        public IMovieRepository MovieRepository { get; private set; }

        public IGenreRepository GenreRepository { get; private set; }
        public IBiographyRepository BiographyRepository { get; private set;}

        public void Save()
        {
            _dBContext.SaveChanges();
        }
        public void Dispose()
        {
            _dBContext.Dispose();
        }
    }
}
