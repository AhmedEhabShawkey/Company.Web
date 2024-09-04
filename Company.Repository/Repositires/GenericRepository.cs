using Company.Data.Contexr;
using Company.Data.Models;
using Company.Repository.IGenericRepositiory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository.Repositires
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly CompanyContext _context;

        public GenericRepository(CompanyContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
           _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll()
        
           =>_context.Set<T>().ToList();

       

        public T Getbyid(int id)
        
         =>   _context.Set<T>().Find(id);
        

        public void Update(T entity)
        {
          _context.Set<T>().Update(entity);
        }
    }
}
