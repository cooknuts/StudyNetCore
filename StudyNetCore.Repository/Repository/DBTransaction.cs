using StudyNetCore.Repository.IRepository;
using System.Data;
using System.Data.Common;

namespace StudyNetCore.Repository.Repository
{
    internal class DBTransaction : IDBTransaction, IDisposable
    {
        DbConnection connection { get; set; }
        DbTransaction transaction { get; set; }

        public DBTransaction(DbConnection connection)
        {
            this.connection = connection;
            this.connection.Open();
            this.transaction = this.connection.BeginTransaction();
        }

        public DbTransaction GetDBTranscation()
        {
            return transaction;
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

        public void Dispose()
        {
            this.transaction.Dispose();
            this.connection.Dispose();
        }
    }
}
