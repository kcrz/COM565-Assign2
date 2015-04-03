using System;
using System.Collections.Generic;

namespace BioengineeringResearch.Models
{
    public partial class Visitor
    {
        public Visitor()
        {
            this.AccessHistories = new List<AccessHistory>();
        }

        public int InternalVisitorId { get; set; }
        public string VisitorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PIN { get; set; }
        public int AccessLevel { get; set; }
        public System.DateTime AuthorizedUntilDate { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public virtual ICollection<AccessHistory> AccessHistories { get; set; }
    }
}
