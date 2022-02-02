using CarPartShop.Entity;
using CarPartShop.Services.CarBrands.Contracts.Dtos;
using CarPartShop.Services.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.PersistenceEF.Repository
{
    public class EFCarBrandRepository : CarBrandRepository
    {
        private readonly EfCarPartContext _context;

        public EFCarBrandRepository(EfCarPartContext context)
        {
            _context = context;
        }

        public void Add(CarBrand brand)
        {
            _context.CarBrands.Add(brand);
        }

        public void Delete(CarBrand brand)
        {
            _context.CarBrands.Remove(brand);
        }

        public CarBrand FindById(Guid id)
        {
            return _context.CarBrands.SingleOrDefault(_ => _.Id == id);
        }

        public List<GetCarBrand> GetAll()
        {
            return _context.CarBrands.Select(_ => new GetCarBrand
            {
                Id = _.Id,
                Name = _.Name
            }).ToList();
        }

        public GetCarBrand GetById(Guid id)
        {
            return _context.CarBrands.Select(_ => new GetCarBrand
            {
                Id = _.Id,
                Name = _.Name
            }).SingleOrDefault(_ => _.Id == id);
        }

        public bool IsExistsById(Guid id)
        {
            return _context.CarBrands.Any(_ => _.Id == id);
        }
    }
}
