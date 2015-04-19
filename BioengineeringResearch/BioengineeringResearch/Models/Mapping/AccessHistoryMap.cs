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
            this.Property(t => t.InternalHistoryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.HistoryId)
                .IsRequired()
                .HasMaxLength(14)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.DoorId)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.EmployeeId)
                .HasMaxLength(14);

            this.Property(t => t.VisitorId)
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("AccessHistory");
            this.Property(t => t.InternalHistoryId).HasColumnName("InternalHistoryId");
            this.Property(t => t.HistoryId).HasColumnName("HistoryId");
            this.Property(t => t.DoorId).HasColumnName("DoorId");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.VisitorId).HasColumnName("VisitorId");
            this.Property(t => t.DateTimeStamp).HasColumnName("DateTimeStamp");

            // Relationships
            this.HasRequired(t => t.DoorTerminal)
                .WithMany(t => t.AccessHistories)
                .HasForeignKey(d => d.DoorId);
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.AccessHistories)
                .HasForeignKey(d => d.EmployeeId);
            this.HasOptional(t => t.Visitor)
                .WithMany(t => t.AccessHistories)
                .HasForeignKey(d => d.VisitorId);

        }
    }
}
