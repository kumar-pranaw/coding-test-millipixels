using Crud.Repository.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Services.ICrudServices
{
    public interface IEmployeeCrudServices
    {
        int AddNewEmployee(Employee employee);
    }
}
