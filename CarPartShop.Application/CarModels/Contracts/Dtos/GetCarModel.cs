using System;

namespace CarPartShop.Services.CarModels.Contracts.Dtos
{
    public class GetCarModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid BrandId { get; set; }
        public string Brand { get; set; }
    }
}
