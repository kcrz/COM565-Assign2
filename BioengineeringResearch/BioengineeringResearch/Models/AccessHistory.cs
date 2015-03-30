using System;
using System.Collections.Generic;

namespace BioengineeringResearch.Models
{
    public partial class AccessHistory
    {
        public int HistoryId { get; set; }
        public int DoorId { get; set; }
        public int EmployeeId { get; set; }
        public System.DateTime DateTimeStamp { get; set; }
        public virtual DoorTerminal DoorTerminal { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
