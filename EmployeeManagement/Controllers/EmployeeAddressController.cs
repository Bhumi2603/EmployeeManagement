using EmployeeManagement.BL;
using EmployeeManagement.Core;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    
        [Route("api/[controller]/[action]")]
        [ApiController]

    public class EmployeeAddressController : Controller
    {        
            EmployeeAddressBL _bl;

        public EmployeeAddressController(EmployeeAddressBL bl)
        { 
            _bl = bl;
        }

       
        [HttpGet]
        [Route("GetAll")]

        public List<EmployeeAddress> GetAll()
        {
            return _bl.GetAllEmployeeAddress();
        }

        [HttpGet]

        public EmployeeAddress Get(Guid id)
        {
            return _bl.Search(new EmployeeAddress() { Id = id });
        }
        [HttpPost]
        public EmployeeAddress? AddEmployeeAddress(EmployeeAddress employeeAddress)
        {
            return _bl.AddEmployeeAddress(employeeAddress);
        }

        [HttpPost]
        

        //[HttpPut]

        //public EmployeeAddress? UpdateEmployeeAddress(EmployeeAddress employeeAddress)
        //{
        //    return _bl.UpdateEmployeeAddress(employeeAddress);
        //}

        [HttpPut]
        public EmployeeAddress UpdateEmployeeAddress(Guid id, EmployeeAddress employeeAddress)
        {
            return _bl.UpdateEmployeeAddress(id, employeeAddress);
        }

        [HttpDelete]

        public bool? DeleteEmployeeAddress(Guid id)
        {
            return _bl.DeleteEmployeeAddress(id);
        }
    }
}
