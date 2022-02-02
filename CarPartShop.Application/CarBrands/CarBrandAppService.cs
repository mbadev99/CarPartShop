using CarPartShop.Services.CarBrands.Contracts.Dtos;
using CarPartShop.Services.RepositoryContracts;
using System.Collections.Generic;
using CarPartShop.Entity;
using System;

namespace CarPartShop.Services.CarBrands
{
    public class CarBrandAppService : Contracts.CarBrandService
    {
        private readonly CarBrandRepository carBrandRepository;
        private readonly UnitOfWork unitOfWork;

        public CarBrandAppService(CarBrandRepository carBrandRepository, UnitOfWork unitOfWork)
        {
            this.carBrandRepository = carBrandRepository;
            this.unitOfWork = unitOfWork;
        }

        public void Add(AddCarBrand dto)
        {
            var brand = new CarBrand(dto.Name);

            carBrandRepository.Add(brand);

            unitOfWork.Save();
        }

        public List<GetCarBrand> GetAll()
        {
            return carBrandRepository.GetAll();
        }

        public GetCarBrand GetDetail(Guid id)
        {
            return carBrandRepository.GetById(id);
        }

        public void Edit(Guid id, EditCarBrand dto)
        {
            var brand = carBrandRepository.FindById(id);
            if (brand == null)
                throw new Exception();
            brand.Name = dto.Name;

            unitOfWork.Save();
        }

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
