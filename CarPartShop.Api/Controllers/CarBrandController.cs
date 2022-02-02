using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using CarPartShop.Services.CarBrands.Contracts;
using CarPartShop.Services.CarBrands.Contracts.Dtos;

namespace CarPartShop.Api.Controllers
{
    [Route("api/brand")]
    [ApiController]
    public class CarBrandController : ControllerBase
    {
        private readonly CarBrandService _carBrandService;

        public CarBrandController(CarBrandService carBrandService)
        {
            _carBrandService = carBrandService;
        }

        [HttpPost]
        public void Add(AddCarBrand dto)
        {
            _carBrandService.Add(dto);
        }

        [HttpGet]
        public List<GetCarBrand> GetAll()
        {
            return _carBrandService.GetAll();
        }

        [HttpGet("detail")]
        public GetCarBrand GetDetail(Guid id)
        {
            return _carBrandService.GetDetail(id);
        }

        [HttpPut("{id}")]
        public void Edit(Guid id, EditCarBrand dto)
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
