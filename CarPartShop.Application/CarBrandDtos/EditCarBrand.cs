using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.Application.CarBrandDtos
{
    public class EditCarBrand:AddCarBrand
    {
        public Guid Id { get; set; }
    }
}
