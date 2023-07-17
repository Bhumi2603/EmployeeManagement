using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core
{
    public class Employee
    {
        public Guid? Id { get; set; }
        public string EmpCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }    
        public string Email { get; set; }
        public DateTime DOJ { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string EmergencyContactNo { get; set; }
        public string EmergencyContactName { get; set; }
    }
}
