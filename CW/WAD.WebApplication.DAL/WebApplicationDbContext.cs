using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAD.WebApplication._7586.DAL.DBO;

namespace WAD.WebApplication._7586.DAL
{
    public class WebApplicationDbContext: DbContext
    {
        public WebApplicationDbContext(DbContextOptions<WebApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
            public virtual DbSet<Product> Products { get; set; }
            public virtual DbSet<Category> Categories { get; set; }
    }
}
