using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.Application.CarModelDtos
{
    public class AddCarModel
    {
        public string Name { get; set; }
        public Guid BrandId { get; set; }
    }
}
