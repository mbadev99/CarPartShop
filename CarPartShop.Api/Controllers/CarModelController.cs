using CarPartShop.Application.CarModelDtos;
using CarPartShop.Infrastructure;
using CarPartShopApi.Domain.CarModelAgg;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPartShop.Api.Controllers
{
    [Route("api/model")]
    [ApiController]
    public class CarModelController : ControllerBase
    {
        private readonly EfCarPartContext _context;

        public CarModelController(EfCarPartContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void Add(AddCarModel dto)
        {
            var model = new CarModel(dto.Name, dto.BrandId);

            _context.Add(model);

            _context.SaveChanges();
        }

        [HttpGet]
        public List<GetCarModel> GetAll()
        {
            return _context.CarModels.Select(_ => new GetCarModel
            {
                Id = _.Id,
                Name = _.Name,
                BrandId = _.BrandId,
                Brand = _.Brand.Name
            }).ToList();
        }

        [HttpGet("detail")]
        public GetCarModel GetDetail(Guid id)
        {
            return _context.CarModels.Select(_ => new GetCarModel
            {
                Id = _.Id,
                Name = _.Name,
                BrandId = _.BrandId,
                Brand = _.Brand.Name
            }).FirstOrDefault(_ => _.Id == id);
        }

        [HttpPut("{id}")]
        public void Edit(Guid id, EditCarModel dto)
        {
            var model = _context.CarModels.SingleOrDefault(_ => _.Id == id);
            if (model == null)
                throw new Exception();
            model.Name = dto.Name;
            model.BrandId = dto.BrandId;

            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var model = _context.CarModels.SingleOrDefault(_ => _.Id == id);
            if (model == null)
                throw new Exception();
            _context.Remove(model);

            _context.SaveChanges();
        }
    }
}
