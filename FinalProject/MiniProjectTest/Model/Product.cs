using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Range(1.0, Double.PositiveInfinity)]
        public double Price { get; set; }
        public string Brand { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }


    }
}
