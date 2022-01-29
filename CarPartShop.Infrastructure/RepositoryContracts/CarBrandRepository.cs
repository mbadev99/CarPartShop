using CarPartShop.Application.CarBrandDtos;
using CarPartShopApi.Domain.CarBrandAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.Infrastructure.RepositoryContracts
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
