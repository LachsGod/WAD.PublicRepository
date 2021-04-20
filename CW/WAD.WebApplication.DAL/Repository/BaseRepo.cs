using System;
using System.Collections.Generic;
using System.Text;
using WAD.WebApplication._7586.DAL;

namespace WAD.WebApplication.DAL.Repository
{
    public abstract class BaseRepo
    {
        protected readonly WebApplicationDbContext _context;

        protected BaseRepo(WebApplicationDbContext context)
        {
            _context = context;
        }
    }
}
