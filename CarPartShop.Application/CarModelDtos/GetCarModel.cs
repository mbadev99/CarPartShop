﻿using System;

namespace CarPartShop.Application.CarModelDtos
{
    public class GetCarModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid BrandId { get; set; }
        public string Brand { get; set; }
    }
}
