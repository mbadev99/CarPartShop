using CarPartShop.Services.CarModels.Contracts.Dtos;
using System.Collections.Generic;
using CarPartShop.Entity;
using System;

namespace CarPartShop.Services.RepositoryContracts
{
    public interface CarModelRepository
    {
        void Add(CarModel model);
        List<GetCarModel> GetAll();
        void Delete(CarModel model);
        CarModel FindById(Guid id);
        bool IsExistsById(Guid id);
        GetCarModel GetById(Guid id);
    }
}
