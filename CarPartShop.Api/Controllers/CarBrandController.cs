using CarPartShop.Application.CarBrandDtos;
using CarPartShop.Infrastructure;
using CarPartShop.Infrastructure.RepositoryContracts;
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
        private readonly CarBrandRepository carBrandRepository;
        private readonly UnitOfWork unitOfWork;

        public CarBrandController(CarBrandRepository carBrandRepository, UnitOfWork unitOfWork)
        {
            this.carBrandRepository = carBrandRepository;
            this.unitOfWork = unitOfWork;
        }

        [HttpPost]
        public void Add(AddCarBrand dto)
        {
            var brand = new CarBrand(dto.Name);

            carBrandRepository.Add(brand);

            unitOfWork.Save();
        }

        [HttpGet]
        public List<GetCarBrand> GetAll()
        {
            return carBrandRepository.GetAll();
        }

        [HttpGet("detail")]
        public GetCarBrand GetDetail(Guid id)
        {
            return carBrandRepository.GetById(id);
        }

        [HttpPut("{id}")]
        public void Edit(Guid id, EditCarBrand dto)
        {
            var brand = carBrandRepository.GetById(id);
            if (brand == null)
                throw new Exception();
            brand.Name = dto.Name;

            unitOfWork.Save();
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var brand = carBrandRepository.FindById(id);
            if (brand == null)
                throw new Exception();
            carBrandRepository.Delete(brand);

            unitOfWork.Save();
        }
    }
}
