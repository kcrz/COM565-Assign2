using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using BioengineeringResearch.Models.Mapping;

namespace BioengineeringResearch.Models
{
    public partial class BioEngResearchSecurityContext : DbContext
    {
        static BioEngResearchSecurityContext()
        {
            Database.SetInitializer<BioEngResearchSecurityContext>(null);
        }

        public BioEngResearchSecurityContext()
            : base("Name=BioEngResearchSecurityContext")
        {
        }

        public DbSet<AccessHistory> AccessHistories { get; set; }
        public DbSet<DoorTerminal> DoorTerminals { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Visitor> Visitors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccessHistoryMap());
            modelBuilder.Configurations.Add(new DoorTerminalMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new VisitorMap());
        }
    }
}
