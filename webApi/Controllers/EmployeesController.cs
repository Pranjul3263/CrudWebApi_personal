using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApi.Data;
using webApi.Model.Entity;
using webApi.Model.models;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDbConst appContext;

        public EmployeesController(AppDbConst appContext)
        {
            this.appContext = appContext;
        }

       

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
         var allemployees=  appContext.Employees.ToList();
            return Ok(allemployees);
        }


        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployees(Guid id)
        {
            var emp= appContext.Employees.Find(id);
            if (emp == null)
            {
                return NotFound();
            }
            return Ok(emp);

        }

        [HttpPost]
        public IActionResult AddEmployees(addEmployeesmod emp)
        {
            var empentity = new Employee()
            {
                Email = emp.Email,
                Name = emp.Name,
                Phone = emp.Phone,
                Salary = emp.Salary,
            };

            appContext.Employees.Add(empentity);
            appContext.SaveChanges();
            return Ok(empentity);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployees(Guid id, UpdateEmploymod upmod)
        {
            var  Employee= appContext.Employees.Find(id);
            if (Employee == null)
            { 
                return NotFound();
            }
            Employee.Name = upmod.Name;
            Employee.Email = upmod.Email;
            Employee.Phone = upmod.Phone;
            Employee.Salary = upmod.Salary; 
            appContext.SaveChanges();
            return Ok(Employee);
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteEmployees(Guid id) 
        {
            var emp= appContext.Employees.Find(id);
            if (emp == null) 
            { 
                return NotFound();
            }
            appContext.Employees.Remove(emp);
            appContext.SaveChanges();
            return Ok(emp); 

        }

    }
}
