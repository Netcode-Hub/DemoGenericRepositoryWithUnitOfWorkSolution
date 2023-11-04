using CompanyManagement.Domain.DatabaseEntities;
using CompanyManagement.Domain.EntityRepositoryInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public EmployeeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var employees = unitOfWork.Employee.GetAll();
            return Ok(employees);
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee model)
        {
            if (model is null) return BadRequest();
            unitOfWork.Employee.Add(model);
            int result = unitOfWork.SaveChanges();
            return Ok(result);
        }

        [HttpGet("name/{name}")]
        public ActionResult FindEmployees(string name)
        {
            var employee = unitOfWork.Employee.Find(x => x.Name.Contains(name));
            if (employee == null) return BadRequest();
            return Ok(employee);
        }

        [HttpGet("{id:int}")]
        public ActionResult FindEmployee(int id)
        {
            var employee = unitOfWork.Employee.GetById(id);
            if (employee == null) return BadRequest();
            return Ok(employee);
        }

        [HttpDelete]
        public ActionResult DeleteEmployee(Employee employee)
        {
            unitOfWork.Employee.Delete(employee);
            int result = unitOfWork.SaveChanges();
            return Ok(result);
        }

        [HttpPut]
        public ActionResult UpdateEmployee(Employee employee)
        {
            unitOfWork.Employee.Update(employee);
            int result = unitOfWork.SaveChanges();
            return Ok(result);
        }
    }
}
