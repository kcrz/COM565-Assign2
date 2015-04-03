using System;
using System.Collections.Generic;

namespace BioengineeringResearch.Models
{
    public partial class DoorTerminal
    {
        public DoorTerminal()
        {
            this.AccessHistories = new List<AccessHistory>();
        }

        public int InternalDoorId { get; set; }
        public string DoorId { get; set; }
        public int MinimumLevelReq { get; set; }
        public string DoorName { get; set; }
        public virtual ICollection<AccessHistory> AccessHistories { get; set; }
    }
}
