using EmployeeManagement.Core;
using EmployeeManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BL
{
    public class AddressTypeBL
    {
        AddressTypeRepository _repository;
        //private AddressTypeRepository _repository;

        public AddressTypeBL(AddressTypeRepository repository)
        {
            _repository = repository;
        }

        public AddressType? AddAddressType(AddressType addressType)
        {
            var id = _repository.AddAddressType(addressType);
            if (id != null)
            {
                addressType.Id = (Guid)id;
            }

            return addressType;

        }


        public AddressType? Search(AddressType addressType)
        {
            return _repository.Search(addressType);
        }



        public List<AddressType> GetAllAddressType()
        {
            return _repository.GetAllAddressType();
        }

        public AddressType UpdateAddressType(AddressType addressType)
        {
            return _repository.UpdateAddressType(addressType);

        }
        public bool? DeleteAddressType(Guid Id)
        {
            return _repository.DeleteAddressType(Id);
        }

    }
}
