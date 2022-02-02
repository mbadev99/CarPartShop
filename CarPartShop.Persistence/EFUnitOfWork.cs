using CarPartShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.PersistenceEF
{
    public class EFUnitOfWork : UnitOfWork
    {
        private readonly EfCarPartContext _context;

        public EFUnitOfWork(EfCarPartContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
