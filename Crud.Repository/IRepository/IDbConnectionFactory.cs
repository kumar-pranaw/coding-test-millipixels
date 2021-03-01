using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Crud.Repository.IRepository
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection(string dbConnectionString);
        void Execute(string query, IDbConnection db);
    }
}
