using Crud.Repository.DataModels;
using Crud.Repository.IRepository;
using Crud.Services.ICrudServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Services.CrudServices
{
    public class EmployeeCrudServices : IEmployeeCrudServices
    {
        private readonly ICrudRepository _repo;
        public EmployeeCrudServices(ICrudRepository repo)
        {
            _repo = repo;
        }

        public int AddNewEmployee(Employee employee)
        {
            return _repo.AddEmployeeDetails(employee);
        }
    }
}
