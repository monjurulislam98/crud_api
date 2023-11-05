﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductMiniFullstckApi.Models.Domain
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string ? Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [NotMapped]
        public string ? CategoryName { get; set; }
    }
}
