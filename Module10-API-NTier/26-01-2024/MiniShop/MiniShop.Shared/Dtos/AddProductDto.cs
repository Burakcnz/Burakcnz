﻿namespace MiniShop.Shared.Dtos
{
    public class AddProductDto
    {
        public string Name { get; set; }
        public string Properties { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public bool IsHome { get; set; }
        public int[] CategoryIds { get; set; }
    }
}
