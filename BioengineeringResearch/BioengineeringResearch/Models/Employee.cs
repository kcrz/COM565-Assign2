using System;
using System.Collections.Generic;

namespace BioengineeringResearch.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.AccessHistories = new List<AccessHistory>();
        }

        public int InternalEmpId { get; set; }
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PIN { get; set; }
        public int AccessLevel { get; set; }
        public System.DateTime AccessGrantedDate { get; set; }
        public System.DateTime AuthorizedUntilDate { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public virtual ICollection<AccessHistory> AccessHistories { get; set; }
    }
}
