using EmployeeManagement.BL;
using EmployeeManagement.Core;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressTypeController : Controller
    {
        AddressTypeBL _bl;
        public AddressTypeController(AddressTypeBL bl)
        {
            _bl = bl;
        }

        [HttpGet]

        public List<AddressType> GetAllAddressType()
        {
            return _bl.GetAllAddressType();
        }

        [HttpGet]
        public AddressType? GetAddressTypeById(Guid Id)
        {
            //return _bl.GetAddressTypeById(Id);
            return _bl.Search(new AddressType() { Id = Id });
        }


        [HttpPost]

        public AddressType AddAddressType(AddressType addressType)
        //public Guid? AddAddressType(AddressType AddressType)
        {
            return _bl.AddAddressType(addressType);
        }

        [HttpPut]
        public AddressType? UpdateAddressType(AddressType addressType)
        //public Employee UpdateEmployeeRelation(EmployeeRelation employeeRelation)
        {
            return _bl.UpdateAddressType(addressType);
        }

        [HttpDelete]

        public bool? DeleteAddressType(Guid Id)

        {
            return _bl.DeleteAddressType(Id);
        }

    }
}
