using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.Services.CarBrands.Contracts.Dtos
{
    public class EditCarBrand : AddCarBrand
    {
        public Guid Id { get; set; }
    }
}
