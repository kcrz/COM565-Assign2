using System;
using System.Collections.Generic;

namespace BioengineeringResearch.Models
{
    public partial class AccessHistory
    {
        public int InternalHistoryId { get; set; }
        public string HistoryId { get; set; }
        public string DoorId { get; set; }
        public string EmployeeId { get; set; }
        public string VisitorId { get; set; }
        public System.DateTime DateTimeStamp { get; set; }
        public virtual DoorTerminal DoorTerminal { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Visitor Visitor { get; set; }
    }
}
