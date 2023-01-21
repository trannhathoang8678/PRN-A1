using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    interface IRepository<T>
    {
        public IEnumerable<T> GetAll();
        public T GetById(string id);
        public void Add(T t);
        public void Update(T t);
        public void Delete(T t);
    }
}
