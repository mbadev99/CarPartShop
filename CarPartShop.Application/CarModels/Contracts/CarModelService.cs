using CarPartShop.Services.CarModels.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.Services.CarModels.Contracts
{
    public interface CarModelService
    {
        void Add(AddCarModel dto);
        void Delete(Guid id);
        void Edit(Guid id, EditCarModel dto);
        List<GetCarModel> GetAll();
        GetCarModel GetDetail(Guid id);
    }
}
