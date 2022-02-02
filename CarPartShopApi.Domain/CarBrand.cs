using System;
using System.Collections.Generic;

namespace CarPartShop.Entity
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
