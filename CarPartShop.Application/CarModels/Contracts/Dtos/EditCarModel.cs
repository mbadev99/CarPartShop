using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartShop.Services.CarModels.Contracts.Dtos
{
    public class EditCarModel : AddCarModel
    {
        public Guid Id { get; set; }
    }
}
