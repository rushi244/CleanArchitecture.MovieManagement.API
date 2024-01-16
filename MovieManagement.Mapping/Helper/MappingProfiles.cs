using AutoMapper;
using MovieManagement.Domain.Entities;
using MovieManagement.Mapping.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Mapping.Helper
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {       
        CreateMap<Actor,ActorDTO>();
        CreateMap<ActorDTO, Actor>();
        CreateMap<Movie,MovieDTO>();
        CreateMap<MovieDTO,Movie>();
        CreateMap<Genre,GenreDTO>();
        CreateMap<GenreDTO, Genre>();
        CreateMap<Biography,BiographyDTO>();
        CreateMap<BiographyDTO, Biography>();
        }
    }
}
