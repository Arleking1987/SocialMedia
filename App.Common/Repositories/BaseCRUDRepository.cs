using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.Clases.Base.Repositories
{
    public abstract class BaseCRUDRepository<TEntity> : IBaseCRUDRepository<TEntity> where TEntity : class
    {
        protected DbContext _Database;

        protected DbSet<TEntity> _Table;



        public BaseCRUDRepository(DbContext context)
        {
            _Database = context;
            _Table = _Database.Set<TEntity>();

        }


        public TEntity Create(TEntity entity)
        {
            _Table.Add(entity);
            SaveChanges();

            return entity;
        }

        public TEntity Delete(int id)
        {
            TEntity list = _Table.Find(id);
            _Table.Remove(list);
            SaveChanges();
            return list;
        }



        public TEntity Update(TEntity oldEntity, TEntity entity)
        {
            _Database.Entry(oldEntity).CurrentValues.SetValues(entity);
            SaveChanges();
            return entity;
        }




        public void SaveChanges()
        {
            _Database.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            TEntity entity = _Table.Find(id);

            return entity;
        }

        public IQueryable<TEntity> GetAll()
        {
            IQueryable<TEntity> list = _Table;
            return list;
        }


    }
}
