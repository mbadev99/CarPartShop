using CarPartShop.Services.CarBrands.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.Services.CarBrands.Contracts
{
    public interface CarBrandService
    {
        void Add(AddCarBrand dto);
        void Delete(Guid id);
        void Edit(Guid id, EditCarBrand dto);
        List<GetCarBrand> GetAll();
        GetCarBrand GetDetail(Guid id);
    }
}
