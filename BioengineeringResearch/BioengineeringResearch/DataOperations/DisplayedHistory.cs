using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioengineeringResearch.DataOperations
{
    /// <summary>
    /// Dedicated class for handling access histories
    /// Author: Kenneth Cruz
    /// 30 Apr 2015
    /// </summary>
    class DisplayedHistory
    {
        public System.DateTime DateStamp { get; set; }
        public System.TimeSpan TimeStamp { get; set; }
        public string DoorName { get; set; }
        public string EmployeeId { get; set; }
        public string VisitorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AccessLevel { get; set; }
    }
}
