using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Core
{
    public interface IBaseRepository<T> where T : class
    {
        //Default metotları burada yazıp daha sonra oluşturduğumuz repositorylerin içerisinde implemente ediyorum.
        public List<T> List();

        public T Find(int Id);

        public T Find(Guid Id);

        public bool Update(T entity);

        public bool Delete(T entity);

        public bool Add(T entity);

        public DbSet<T> Set();
    }
}