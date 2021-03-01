using Crud.Repository.DataModels;
using Crud.Repository.IRepository;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Crud.Repository.Repository
{
    public class CrudRepository : ICrudRepository
    {
        private readonly string dbConnectionString;
        private readonly IDbConnectionFactory _connectionFactory;
        public CrudRepository(IConfiguration config, IDbConnectionFactory connectionFactory)
        {
            dbConnectionString = config["WebApiDatabase"];
            _connectionFactory = connectionFactory;
        }
        public int AddEmployeeDetails(Employee employee)
        {
            using (IDbConnection db = _connectionFactory.CreateConnection(dbConnectionString))
            {
                string createNewEmployeeQuery = $"EXEC [dbo].[CreateEmployee] @EmployeeName='{employee.EmployeeName}',@Designation='{employee.Designation}',@Salary='{employee.Salary}',@DateOfJoining='{employee.DateOfJoining}'";

                return db.Query<int>(createNewEmployeeQuery).FirstOrDefault();
            }
        }
    }
}
