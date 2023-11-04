using CompanyManagement.Domain.DatabaseEntities;
using CompanyManagement.Domain.EntityRepositoryInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public CustomerController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var employees = unitOfWork.Customer.GetAll();
            return Ok(employees);
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer model)
        {
            if (model is null) return BadRequest();
            unitOfWork.Customer.Add(model);
            int result = unitOfWork.SaveChanges();
            return Ok(result);
        }

        [HttpGet("name/{name}")]
        public ActionResult FindCustomer(string name)
        {
            var result = unitOfWork.Customer.Find(x => x.Name.Contains(name));
            if (result == null) return BadRequest();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public ActionResult FindCustomer(int id)
        {
            var result = unitOfWork.Customer.GetById(id);
            if (result == null) return BadRequest();
            return Ok(result);
        }

        [HttpDelete]
        public ActionResult DeleteCustomer(Customer model)
        {
            unitOfWork.Customer.Delete(model);
            int result = unitOfWork.SaveChanges();
            return Ok(result);
        }

        [HttpPut]
        public ActionResult UpdateCustomer(Customer model)
        {
            unitOfWork.Customer.Update(model);
            int result = unitOfWork.SaveChanges();
            return Ok(result);
        }



        // The following Action Methods are coming from Customized interface, they are not part of the general generic repo.
        [HttpGet("CustomerWithOrder")]
        public ActionResult CustomerWithOrder()
        {
            var result = unitOfWork.Customer.GetCustomersWithOrders();
            return Ok(result);
        }
    }
}
