using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.Application.CarModelDtos
{
    public class EditCarModel: AddCarModel
    {
        public Guid Id { get; set; }
    }
}
