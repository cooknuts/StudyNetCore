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
        private readonly DbContext dbContext;
        private readonly DBTransaction dbTransaction;

        public RepositoryBase(postgresContext dbContext, DBTransaction dbTransaction)
        {
            this.dbContext = dbContext;
            this.dbTransaction = dbTransaction;
        }
        public virtual bool Add(T entity)
        {
            dbContext.Set<T>().Add(entity);
            return this.SaveChanges() > 0;
        }
        public virtual bool AddRange(List<T> entities)
        {
            dbContext.Set<T>().AddRange(entities);
            return this.SaveChanges() > 0;
        }
        public virtual T Query(Expression<Func<T, bool>> whereLambda)
        {
            return dbContext.Set<T>().SingleOrDefault(whereLambda);
        }
        public virtual List<T> QueryList(Expression<Func<T, bool>> whereLambda)
        {
            return dbContext.Set<T>().Where(whereLambda).ToList();
        }
        private int SaveChanges()
        {
            if (dbContext.Database.CurrentTransaction == null)
            {
                if (dbTransaction != null)
                {
                    dbContext.Database.UseTransaction(dbTransaction.GetDBTranscation());
                }
            }
            return dbContext.SaveChanges();
        }
    }
}
