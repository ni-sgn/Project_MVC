using AutoMapper;
using BLL.DTOs.LawSuit;
using BLL.DTOs.Person;
using BLL.DTOs.SystemUser;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            CreateMap<LawSuitCUDTO, LawSuit>();

            CreateMap<PhoneNumberDTO, PhoneNumber>();
            CreateMap<PhoneNumber, PhoneNumberDTO>();
            CreateMap<PersonCUDTO, Person>()
                .ForMember(dest =>
                dest.Id,
                opt => opt.Ignore())
                .ForMember(dest =>
                dest.Numbers,
                opt => opt.MapFrom(src => src.Numbers.Select(x => new PhoneNumberDTO() { Id = x.Id, Number = x.Number, TypeId = x.TypeId }).ToList()));

            CreateMap<Person, PersonCUDTO>()
                .ForMember(dest =>
                dest.Numbers,
                opt => opt.MapFrom(src => src.Numbers.Select(x => new PhoneNumberDTO() { Id = x.Id, Number = x.Number, TypeId = x.TypeId }).ToList()));

        }
    }
}
