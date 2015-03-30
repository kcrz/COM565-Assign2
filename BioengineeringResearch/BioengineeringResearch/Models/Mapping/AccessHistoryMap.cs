using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BioengineeringResearch.Models.Mapping
{
    public class AccessHistoryMap : EntityTypeConfiguration<AccessHistory>
    {
        public AccessHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.HistoryId);

            // Properties
            this.Property(t => t.HistoryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AccessHistory");
            this.Property(t => t.HistoryId).HasColumnName("HistoryId");
            this.Property(t => t.DoorId).HasColumnName("DoorId");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.DateTimeStamp).HasColumnName("DateTimeStamp");

            // Relationships
            this.HasRequired(t => t.DoorTerminal)
                .WithMany(t => t.AccessHistories)
                .HasForeignKey(d => d.DoorId);
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.AccessHistories)
                .HasForeignKey(d => d.EmployeeId);

        }
    }
}
