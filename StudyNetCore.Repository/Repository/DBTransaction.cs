using StudyNetCore.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyNetCore.Repository.Repository
{
    internal class DBTransaction : IDBTransaction
    {
        IDbConnection connection { get; set; }
        IDbTransaction transaction { get; set; }

        public DBTransaction(IDbConnection conn)
        {
            this.connection = conn;
            this.connection.Open();
            this.transaction = conn.BeginTransaction();
        }

        public void Dispose()
        {
            this.transaction.Dispose();
            this.connection.Close();
        }

        public void Commit()
        {
            this.transaction.Commit();
            this.connection.Close();
        }

        public void Rollback()
        {
            this.transaction.Rollback();
            this.connection.Close();
        }
    }
}
