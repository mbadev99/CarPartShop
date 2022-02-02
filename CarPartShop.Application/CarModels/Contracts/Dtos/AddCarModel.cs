using System;

namespace CarPartShop.Services.CarModels.Contracts.Dtos
{
    public class AddCarModel
    {
        public string Name { get; set; }
        public Guid BrandId { get; set; }
    }
}