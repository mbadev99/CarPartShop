using CarPartShop.Services.CarModels.Contracts.Dtos;
using CarPartShop.Services.CarModels.Contracts;
using CarPartShop.Services.RepositoryContracts;
using System.Collections.Generic;
using CarPartShop.Entity;
using System;

namespace CarPartShop.Services.CarModels
{
    public class CarModelAppService : CarModelService
    {
        private readonly CarModelRepository carModelRepository;
        private readonly UnitOfWork unitOfWork;

        public CarModelAppService(CarModelRepository carModelRepository, UnitOfWork unitOfWork)
        {
            this.carModelRepository = carModelRepository;
            this.unitOfWork = unitOfWork;
        }

        public void Add(AddCarModel dto)
        {
            var model = new CarModel(dto.Name, dto.BrandId);

            carModelRepository.Add(model);

            unitOfWork.Save();
        }

        public List<GetCarModel> GetAll()
        {
            return carModelRepository.GetAll();
        }

        public GetCarModel GetDetail(Guid id)
        {
            return carModelRepository.GetById(id);
        }

        public void Edit(Guid id, EditCarModel dto)
        {
            var model = carModelRepository.FindById(id);
            if (model == null)
                throw new Exception();
            model.Name = dto.Name;
            model.BrandId = dto.BrandId;

            unitOfWork.Save();
        }

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
