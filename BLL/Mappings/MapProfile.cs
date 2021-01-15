using AutoMapper;
using BLL.DTOs.LawSuit;
using BLL.DTOs.Person;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Mappings
{ 
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Person, PersonListDTO>()
                .ForMember(dest =>
                dest.Type,
                opt => opt.MapFrom(src => src.Type.Name));
            CreateMap<LawSuit, LawSuitListDTO>()
                .ForMember(dest =>
                dest.Status,
                opt => opt.MapFrom(src => src.Status.Name));

            CreateMap<LawSuit, LawSuitListDTO>()
                .ForMember(dest =>
                dest.Person,
                opt => opt.MapFrom(src => src.person.FirstName));
        }
    }
}
