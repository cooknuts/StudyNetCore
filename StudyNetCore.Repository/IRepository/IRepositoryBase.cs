using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudyNetCore.Repository.Interface
{
    internal interface IRepositoryBase<T> where T : class
    {
        bool Add(T entity);
        bool AddRange(List<T> entities);
        T Query(Expression<Func<T, bool>> wherelambda);
        List<T> QueryList(Expression<Func<T, bool>> wherelambda);
    }
}
