using CarPartShopApi.Domain.CarBrandAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShopApi.Domain.CarModelAgg
{
    public class CarModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public CarBrand Brand { get; set; }
        public Guid BrandId { get; set; }

        public CarModel(string name,Guid brandId)
        {
            Id = Guid.NewGuid();
            Name = name;
            BrandId = brandId;
        }

        public CarModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
