using Crud.Repository.DataModels;
using Crud.Services.ICrudServices;
using Microsoft.AspNetCore.Mvc;

namespace Crud.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeCrudServices _services;
        public EmployeeController(IEmployeeCrudServices services)
        {
            _services = services;
        }

        [HttpPost("addNewEmployee")]
        public ActionResult AddEmployee(Employee employee)
        {
            var createNewEmployee = _services.AddNewEmployee(employee);

            if (createNewEmployee == 0)
            {
                return Ok(new { message = $"Employee with name {employee.EmployeeName} created successfully" });
            }
            else
            {
                return BadRequest(new { message = $"Employee with name {employee.EmployeeName} Can't created at the moment" });
            }
        }

    }
}
