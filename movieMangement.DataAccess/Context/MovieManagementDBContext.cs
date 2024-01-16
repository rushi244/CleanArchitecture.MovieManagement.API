using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.DataAccess.Context
{
    public class MovieManagementDBContext : DbContext
    {
        public MovieManagementDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Actor> Actors{get;set;}
        public DbSet<Movie> Movies { get;set;}
        public DbSet<Biography> Biographies { get;set;}
        public DbSet<Genre> Genres { get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id=1,FirstName="Chuck",LastName="Morris"},
                new Actor { Id=2,FirstName="Jane",LastName="Doe"},
                new Actor { Id=3,FirstName="Van",LastName="Damne"}
                );

            modelBuilder.Entity<Movie>().HasData(
                new Movie {Id=1, Name="Wakanda Forever",Description="Box Office we are coming",ActorId=1 },
                new Movie {Id=2, Name="Wakanda Forever",Description="Box Office we are coming",ActorId=2 },
                new Movie {Id=3, Name="Spiderman",Description="Sky scrappers be warned",ActorId=2 },
                new Movie {Id=4, Name="Matrix",Description="Blue or red pill",ActorId=2 }
                );
        }
    }
}
