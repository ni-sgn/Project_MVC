using DAL.Context;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repositories
{
    public class UOW : IUOW
    {

        // This Class is for optimization...
        // Don't commit, which means don't send queries
        // to the database server until bunch of queries are in the que...
        // this will probably optimze things...

        // we can probably have commit in individual repositories...
        // but this works better I guess...
        private DatabaseContext _context;
        
        private IPersonRepository _personRepository;
        private ILawSuitRepository _lawSuitRepository;
        
        // private ISystemUserRepository _systemUserRepository;
        private IDictionaryRepository _lawSuitDictionaryRepository;

        public UOW(DatabaseContext context)
        {
            _context = context;
        }

        public IPersonRepository Person
        {
            get
            {
                if (_personRepository == null)
                    _personRepository = new PersonRepository(_context);
                return _personRepository;

            }
        }
        public ILawSuitRepository LawSuit
        {
            get
            {
                if (_lawSuitRepository == null)
                    _lawSuitRepository = new LawSuitRepository(_context);
                return _lawSuitRepository;
            }
        }

        // public ISystemUserRepository SystemUser
        // {
        //     get
        //     {
        //         if (_systemUserRepository == null)
        //             _systemUserRepository = new SystemUserRepository(_context);
        //         return _systemUserRepository;
        //     }
        // }

        //singleton pattern?
        public IDictionaryRepository LawSuitDictionary
        {
            get
            {
                if (_lawSuitDictionaryRepository == null)
                    _lawSuitDictionaryRepository = new DictionaryRepository(_context);
                return _lawSuitDictionaryRepository;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }


    }
}
