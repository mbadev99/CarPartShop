using CarPartShop.Services.CarBrands.Contracts.Dtos;
using System.Collections.Generic;
using CarPartShop.Entity;
using System;

namespace CarPartShop.Services.RepositoryContracts
{
    public interface CarBrandRepository
    {
        void Add(CarBrand brand);
        List<GetCarBrand> GetAll();
        void Delete(CarBrand brand);
        CarBrand FindById(Guid id);
        GetCarBrand GetById(Guid id);
        bool IsExistsById(Guid id);
    }
}
