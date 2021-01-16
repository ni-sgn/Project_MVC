using AutoMapper;
using BLL.DTOs.LawSuit;
using BLL.DTOs.Person;
using BLL.DTOs.SystemUser;
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
                opt => opt.MapFrom(src => src.Type.Name))
                .ForMember(dest =>
                dest.City,
                opt => opt.MapFrom(src => src.City.Name)); ;

            CreateMap<LawSuit, LawSuitListDTO>()
                .ForMember(dest =>
                dest.Status,
                opt => opt.MapFrom(src => src.Status.Name))
                .ForMember(dest =>
                dest.Person,
                opt => opt.MapFrom(src => src.person.FirstName));                

            CreateMap<SystemUser, SystemUserListDTO>()
                .ForMember(dest =>
                dest.Type,
                opt => opt.MapFrom(src => src.Type.Name))
                .ForMember(dest =>
                dest.Position,
                opt => opt.MapFrom(src => src.Position.Name)
                );

            CreateMap<PersonCUDTO, Person>();
            
        }
    }
}
