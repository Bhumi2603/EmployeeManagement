using EmployeeManagement.BL;
using EmployeeManagement.Core;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeRelationController : Controller
    {
        EmployeeRelationBL _rl;

        public EmployeeRelationController(EmployeeRelationBL rl)
        {
            _rl = rl;
        }

        [HttpGet]


        public List<EmployeeRelation> GetAllEmployeeRelation()
        {
            return _rl.GetAllEmployeeRelation();
        }

        [HttpGet]

        public EmployeeRelation? Get(Guid id)
        {
            return _rl.Search(new EmployeeRelation() { Id = id });
        }

        [HttpPost]
        public EmployeeRelation? AddEmployeeRelation(EmployeeRelation employeeRelation)
        {
            return _rl.AddEmployeeRelation(employeeRelation);
        }

        [HttpPut]

        public EmployeeRelation? UpdateEmployeeRelation(EmployeeRelation employeeRelation)
        {
            return _rl.UpdateEmployeeRelation(employeeRelation);
        }

        [HttpDelete]

        public bool? DeleteEmployeeRelatio(Guid id)
        {
            return _rl.DeleteEmployeeRelation(id);
        }
    }
}