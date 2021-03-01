using Crud.Repository.IRepository;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Crud.Repository.Repository
{
    public class SqlConnectionFactory : IDbConnectionFactory
    {
        public IDbConnection CreateConnection(string dbConnectionString)
        {
            return new SqlConnection(dbConnectionString);
        }

        public void Execute(string query, IDbConnection db)
        {
            db.Execute(query);
        }
    }
}
