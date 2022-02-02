using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using CarPartShop.Services.CarModels.Contracts;
using CarPartShop.Services.CarModels.Contracts.Dtos;

namespace CarPartShop.Api.Controllers
{
    [Route("api/model")]
    [ApiController]
    public class CarModelController : ControllerBase
    {
        private readonly CarModelService _carBrandService;

        public CarModelController(CarModelService carBrandService)
        {
            _carBrandService = carBrandService;
        }

        [HttpPost]
        public void Add(AddCarModel dto)
        {
            _carBrandService.Add(dto);
        }

        [HttpGet]
        public List<GetCarModel> GetAll()
        {
            return _carBrandService.GetAll();
        }

        [HttpGet("detail")]
        public GetCarModel GetDetail(Guid id)
        {
            return _carBrandService.GetDetail(id);
        }

        [HttpPut("{id}")]
        public void Edit(Guid id, EditCarModel dto)
        {
            _carBrandService.Edit(id, dto);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _carBrandService.Delete(id);
        }
    }
}
