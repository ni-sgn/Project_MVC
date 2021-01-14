using DAL.Context;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repositories
{
    public class UOW : IUOW
    {
        private DatabaseContext _context;
        private IPersonRepository _personRepository;

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
