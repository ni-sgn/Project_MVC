﻿using AutoMapper;
using BLL.DTOs.LawSuit;
using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Operations
{
    public class LawSuitOperations : ILawSuitOperations
    {
        private readonly IMapper _mapper;
        private readonly IUOW _uow;

        public LawSuitOperations(IMapper mapper, IUOW uow)
        {
            _mapper = mapper;
            _uow = uow;
        }

        public IEnumerable<LawSuitListDTO> GetAll()
        {
            // Sql Query
            var LawSuits = _uow.LawSuit.GetAll();
            // transfer the result into business schemas
            return _mapper.Map<IEnumerable<LawSuitListDTO>>(LawSuits);
        }

        public void CreateLawSuit(LawSuitCUDTO model)
        {
            var lawsuit = _mapper.Map <LawSuit>(model);
            _uow.LawSuit.Create(lawsuit);
            _uow.Commit();
        }

        public LawSuitCUComponents GetLawSuitCUComponents()
        {
            var dictionaries = _uow.LawSuitDictionary.GetLawSuitFormComponents();
            //probably getting table with only id and name would be a better way
            var people = _uow.Person.GetAll();

            LawSuitCUComponents model = new LawSuitCUComponents();
            model.Statuses = dictionaries.Where(x => x.HasStatus == true).Select(x => new SelectListItem() { Text = x.Name, Value = x.Id.ToString() }).ToList();
            model.People = people.Select(x => new SelectListItem() { Text = x.FirstName, Value = x.Id.ToString() }).ToList();
            return model;
        }

        public LawSuitCUDTO GetLawSuit(int Id)
        {
            var lawsuit = _uow.LawSuit.GetLawSuit(Id);
            return _mapper.Map<LawSuitCUDTO>(lawsuit);
        }

        public void UpdateLawSuit(LawSuitCUDTO lawsuit)
        {
            LawSuit dbModel = _uow.LawSuit.GetLawSuit(lawsuit.Id);
            _mapper.Map<LawSuitCUDTO, LawSuit>(lawsuit, dbModel);
            _uow.LawSuit.Update(dbModel);
            _uow.Commit();
        }

        public void DeleteLawSuit(int Id)
        {
            var lawsuit = _uow.LawSuit.GetLawSuit(Id);
            _uow.LawSuit.Delete(lawsuit);
            _uow.Commit();
        }


        public IEnumerable<LawSuitListDTO> GetByStatusType(string StatusType)
        {
            // Sql Query
            var LawSuits = _uow.LawSuit.GetByStatusType(e => e.StatusId == Int32.Parse(StatusType));
            // transfer the result into business schemas
            return _mapper.Map<IEnumerable<LawSuitListDTO>>(LawSuits);
        }


    }
}
