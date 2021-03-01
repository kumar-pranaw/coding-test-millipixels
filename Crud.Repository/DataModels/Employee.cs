using System;

namespace Crud.Repository.DataModels
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string Salary { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
}
