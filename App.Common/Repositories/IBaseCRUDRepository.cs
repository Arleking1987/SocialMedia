using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.Clases.Base.Repositories
{
    public interface IBaseCRUDRepository<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);

        public TEntity Update(TEntity oldEntity, TEntity entity);
        TEntity Delete(int id);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();

        void SaveChanges();


    }
}