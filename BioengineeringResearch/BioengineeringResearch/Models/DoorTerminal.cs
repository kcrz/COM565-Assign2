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

        public int DoorId { get; set; }
        public int MinimumLevelReq { get; set; }
        public virtual ICollection<AccessHistory> AccessHistories { get; set; }
    }
}
