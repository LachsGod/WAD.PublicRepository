using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAD.WebApplication.DAL.Repository
{
    public interface IRepository<T> where T:class
    {
        bool Exists(int id);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(int id);
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
    }
}
