using Microsoft.EntityFrameworkCore;
using StudyNetCore.Model;
using StudyNetCore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudyNetCore.Repository.Repository
{
    internal class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly DbContext db;

        public RepositoryBase(postgresContext dbEntities)
        {
            this.db = dbEntities;
        }
        public virtual bool Add(T entity)
        {
            db.Set<T>().Add(entity);
            return db.SaveChanges() > 0;
        }
        public virtual bool AddRange(List<T> entities)
        {
            db.Set<T>().AddRange(entities);
            return db.SaveChanges() > 0;
        }
        public virtual T Query(Expression<Func<T, bool>> whereLambda)
        {
            return db.Set<T>().SingleOrDefault(whereLambda);
        }
        public virtual List<T> QueryList(Expression<Func<T, bool>> whereLambda)
        {
            return db.Set<T>().Where(whereLambda).ToList();
        }
    }
}
