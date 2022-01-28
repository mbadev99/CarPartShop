using CarPartShop.Application.CarBrandDtos;
using CarPartShop.Infrastructure;
using CarPartShopApi.Domain.CarBrandAgg;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPartShop.Api.Controllers
{
    [Route("api/brand")]
    [ApiController]
    public class CarBrandController : ControllerBase
    {
        private readonly EfCarPartContext _context;

        public CarBrandController(EfCarPartContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void Add(AddCarBrand dto)
        {
            var brand = new CarBrand(dto.Name);

            _context.Add(brand);

            _context.SaveChanges();
        }

        [HttpGet]
        public List<GetCarBrand> GetAll()
        {
            return _context.CarBrands.Select(_ => new GetCarBrand
            {
                Id = _.Id,
                Name = _.Name
            }).ToList();
        }

        [HttpGet("detail")]
        public GetCarBrand GetDetail(Guid id)
        {
            return _context.CarBrands.Select(_ => new GetCarBrand
            {
                Id = _.Id,
                Name = _.Name
            }).FirstOrDefault(_ => _.Id == id);
        }

        [HttpPut("{id}")]
        public void Edit(Guid id, EditCarBrand dto)
        {
            var brand = _context.CarBrands.SingleOrDefault(_ => _.Id == id);
            if (brand == null)
                throw new Exception();
            brand.Name = dto.Name;

            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var brand = _context.CarBrands.SingleOrDefault(_ => _.Id == id);
            if (brand == null)
                throw new Exception();
            _context.Remove(brand);

            _context.SaveChanges();
        }
    }
}
