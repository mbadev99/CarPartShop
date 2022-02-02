using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.Services.CarBrands.Contracts.Dtos
{
    public class GetCarBrand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
