using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.WebApplication._7586.DAL.DBO
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
