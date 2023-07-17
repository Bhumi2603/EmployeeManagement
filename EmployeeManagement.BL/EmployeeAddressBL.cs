using EmployeeManagement.Core;
using EmployeeManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BL
{
    public class EmployeeAddressBL
    {
        EmployeeAddressRepository _repository;

        public EmployeeAddressBL(EmployeeAddressRepository repository)
        {
            _repository = repository;
        }


        //Add
        //public EmployeeAddress? AddEmployeeAddress(EmployeeAddress employeeAddress)
        //{
        //    var id = _repository.AddEmployeeAddress(employeeAddress);

        //    if (id != null)
        //    {
        //        employeeAddress.Id = id;
        //    }
        //    return employeeAddress;
        //}
        public EmployeeAddress? AddEmployeeAddress(EmployeeAddress employeeAddress)
        {

            var id = _repository.AddEmployeeAddress(employeeAddress);
            if (id != null)
            {
                employeeAddress.Id = (Guid)id;
            }

            return employeeAddress;
        }

            public List<EmployeeAddress> GetAllEmployeeAddress()
        {
            return _repository.GetAllEmployeeAddress();
        }
        public EmployeeAddress Search(EmployeeAddress employeeAddress)
        {
            return _repository.Search(employeeAddress);
        }
        //Update

        //public EmployeeAddress? UpdateEmployeeAddress(EmployeeAddress employeeAddress)
        //{
        //    var existingEmployeeAddress = Search(new EmployeeAddress() { Id = employeeAddress.Id });
        //    if (existingEmployeeAddress == null)
        //    {
        //        throw new Exception("please enter correct id");
        //    }
        //    return _repository.UpdateEmployeeAddress(employeeAddress);
        //}
        public bool? DeleteEmployeeAddress(Guid id)
        {
            return _repository.DeleteEmployeeAddress(id);

        }
        public EmployeeAddress UpdateEmployeeAddress(Guid id, EmployeeAddress employeeAddress)
        {
            return _repository.UpdateEmployeeAddress(id, employeeAddress);

        }

    }
}
