using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.WebApplication._7586.DAL.DBO
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        public int? CategoryId { get; set; }

        [Required]
        public Availability Availability { get; set; }

        public virtual Category Category { get; set; }
    }
    public enum Availability
    {
        Available,
        NotAvailable
    }
}
