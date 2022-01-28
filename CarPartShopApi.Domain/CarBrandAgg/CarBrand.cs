using CarPartShopApi.Domain.CarModelAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShopApi.Domain.CarBrandAgg
{
    public class CarBrand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<CarModel> Models { get; set; }

        public CarBrand(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Models = new List<CarModel>();
        }

        public CarBrand()
        {
            Id = Guid.NewGuid();
        }
    }
}
