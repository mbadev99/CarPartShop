using CarPartShop.Application.CarModelDtos;
using CarPartShopApi.Domain.CarModelAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.Infrastructure.RepositoryContracts
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
