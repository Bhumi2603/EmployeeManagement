using EmployeeManagement.BL;
using EmployeeManagement.Core;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class EmployeeFamilyDetailController : Controller
    {
        EmployeeFamilyDetailBL _bl;
        public EmployeeFamilyDetailController(EmployeeFamilyDetailBL bl)
        {
            _bl = bl;
        }

        [HttpGet]

        public List<EmployeeFamilyDetail> GetAllEmployeeFamilyDetail()
        {
            return _bl.GetAllEmployeeFamilyDetail();
        }

        [HttpGet]

        public EmployeeFamilyDetail? Search (Guid Id)
        {
           
            return _bl.Search(new EmployeeFamilyDetail() { Id = Id });
        }
        [HttpPost]
        public EmployeeFamilyDetail? AddEmployeeFamilyDetail(EmployeeFamilyDetail employeeFamilyDetail)
        
        {
            return _bl.AddEmployeeFamilyDetail(employeeFamilyDetail);
        }
        
        
        //[HttpPut]
        //public EmployeeFamilyDetail? UpdateEmployeeFamilyDetail( EmployeeFamilyDetail employeeFamilyDetail)
        //{
        //    return _bl.UpdateEmployeeFamilyDetail(employeeFamilyDetail);
        //}

        [HttpPut]
        public EmployeeFamilyDetail? UpdateEmployeeFamilyDetail(Guid id, EmployeeFamilyDetail employeeFamilyDetail)
        {
            return _bl.UpdateEmployeeFamilyDetail(id, employeeFamilyDetail);
        }

        [HttpDelete]

        public bool? DeleteEmployeeFamilyDetail(Guid id)
        {
            return _bl.DeleteEmployeeFamilyDetail(id);
        }
    }
}
