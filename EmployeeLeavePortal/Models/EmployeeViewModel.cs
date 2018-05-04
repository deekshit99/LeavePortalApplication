using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeLeavePortal.Models
{
    public class EmployeeViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }

        internal void getEmployeeDetails(string id)
        {
            this.Id = id;
        }
    }
}