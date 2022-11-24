using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyNetCore.Repository.IRepository
{
    public interface IDBTransaction
    {
        public void Commit();
        public void Rollback();
    }
}
