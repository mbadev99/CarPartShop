﻿using CarPartShop.Entity;
using CarPartShop.Services.CarModels.Contracts.Dtos;
using CarPartShop.Services.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.PersistenceEF.Repository
{
    public class EFCarModelRepository : CarModelRepository
    {
        private readonly EfCarPartContext _context;

        public EFCarModelRepository(EfCarPartContext context)
        {
            _context = context;
        }

        public void Add(CarModel model)
        {
            _context.CarModels.Add(model);
        }

        public void Delete(CarModel model)
        {
            _context.CarModels.Remove(model);
        }

        public CarModel FindById(Guid id)
        {
            return _context.CarModels.SingleOrDefault(_ => _.Id == id);
        }

        public List<GetCarModel> GetAll()
        {
            return _context.CarModels.Select(_ => new GetCarModel
            {
                Id = _.Id,
                Name = _.Name,
                BrandId = _.BrandId,
                Brand = _.Brand.Name,
            }).ToList();
        }

        public GetCarModel GetById(Guid id)
        {
            return _context.CarModels.Select(_ => new GetCarModel
            {
                Id = _.Id,
                Name = _.Name,
                BrandId = _.BrandId,
                Brand = _.Brand.Name
            }).SingleOrDefault(_ => _.Id == id);
        }

        public bool IsExistsById(Guid id)
        {
            return _context.CarModels.Any(_ => _.Id == id);
        }
    }
}
