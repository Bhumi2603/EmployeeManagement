using EmployeeManagement.Core;
using EmployeeManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BL
{
    public class EmployeeRelationBL
    {
        EmployeeRelationRepository _repository;

        public EmployeeRelationBL(EmployeeRelationRepository repository)
        {
            _repository = repository;
        }
        //public EmployeeRelation? AddEmployeeRelation(EmployeeRelation employeeRelation)
        //{
        //    var id = _repository.AddEmployeeRelation(employeeRelation);
        //    if (id != null)
        //    {
        //        employeeRelation.Id = (Guid)id;
        //    }

        //    return employeeRelation;

        //}

        //public List<EmployeeRelation> GetAllEmployeeRelation()
        //{
        //    return _repository.GetAllEmployeeRelation();
        //}

        ////public EmployeeRelation? Search(EmployeeRelation employeeRelation)
        //{
        //    return _repository.Search(employeeRelation);
        //}
        //public EmployeeRelation? EmployeeRelation(Guid Id)
        //{
        //    return _repository.EmployeeRelation();
        //}

        //public EmployeeRelation? GetEmployeeRelationById(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public EmployeeRelation UpdateEmployeeRelation(EmployeeRelation employeeRelation)
        //{
        //    return _repository.UpdateEmployeeRelation(employeeRelation);

        //}
        //public bool? DeleteEmployeeRelation(Guid Id)
        //{
        //    return _repository.DeleteEmployeeRelation(Id);
        //}

        //public Employee UpdateEmployeeRelation(EmployeeRelation employeeRelation)
        //{
        //    throw new NotImplementedException();
        //}

        //Get All

        public List<EmployeeRelation> GetAllEmployeeRelation()
        {
            return _repository.GetAllEmployeeRelation();
        }

        //Get

        public EmployeeRelation? Search(EmployeeRelation employeeRelation)
        {
            return _repository.Search(employeeRelation);
        }

        //Add
        public EmployeeRelation? AddEmployeeRelation(EmployeeRelation employeeRelation)
        {
            var id = _repository.AddEmployeeRelation(employeeRelation);
            if (id != null)
            {
                employeeRelation.Id = (Guid)id;
            }

            return employeeRelation;
        }

        //Update
        public EmployeeRelation? UpdateEmployeeRelation(EmployeeRelation employeeRelation)
        {
            var exiatingEmployeeRelation = Search(new EmployeeRelation() { Id = employeeRelation.Id });
            if (exiatingEmployeeRelation == null)
            {
                throw new Exception("please enter a new correct update id");
            }
            return _repository.UpdateEmployeeRelation(employeeRelation);
        }

        //Delete
        public bool? DeleteEmployeeRelation(Guid id)
        {
            return _repository.DeleteEmployeeRelation(id);
        }
    }
}
    

