using Data.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IRepository<T>  : IRepositoryBase where T : Entity
    {
        void Add(T entity);
        void Delte(T entity);
        void CommitChanges();
    }
}
