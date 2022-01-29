using CarPartShop.Application.CarModelDtos;
using CarPartShop.Infrastructure;
using CarPartShop.Infrastructure.RepositoryContracts;
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
        private readonly CarModelRepository carModelRepository;
        private readonly UnitOfWork unitOfWork;

        public CarModelController(CarModelRepository carModelRepository, UnitOfWork unitOfWork)
        {
            this.carModelRepository = carModelRepository;
            this.unitOfWork = unitOfWork;
        }

        [HttpPost]
        public void Add(AddCarModel dto)
        {
            var model = new CarModel(dto.Name, dto.BrandId);

            carModelRepository.Add(model);

            unitOfWork.Save();
        }

        [HttpGet]
        public List<GetCarModel> GetAll()
        {
            return carModelRepository.GetAll();
        }

        [HttpGet("detail")]
        public GetCarModel GetDetail(Guid id)
        {
            return carModelRepository.GetById(id);
        }

        [HttpPut("{id}")]
        public void Edit(Guid id, EditCarModel dto)
        {
            var model = carModelRepository.FindById(id);
            if (model == null)
                throw new Exception();
            model.Name = dto.Name;
            model.BrandId = dto.BrandId;

            unitOfWork.Save();
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var model = carModelRepository.FindById(id);
            if (model == null)
                throw new Exception();
            carModelRepository.Delete(model);

            unitOfWork.Save();
        }
    }
}
