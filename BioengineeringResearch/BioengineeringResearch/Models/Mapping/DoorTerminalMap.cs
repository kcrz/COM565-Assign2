using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BioengineeringResearch.Models.Mapping
{
    public class DoorTerminalMap : EntityTypeConfiguration<DoorTerminal>
    {
        public DoorTerminalMap()
        {
            // Primary Key
            this.HasKey(t => t.DoorId);

            // Properties
            this.Property(t => t.InternalDoorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.DoorId)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.DoorName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DoorTerminal");
            this.Property(t => t.InternalDoorId).HasColumnName("InternalDoorId");
            this.Property(t => t.DoorId).HasColumnName("DoorId");
            this.Property(t => t.MinimumLevelReq).HasColumnName("MinimumLevelReq");
            this.Property(t => t.DoorName).HasColumnName("DoorName");
        }
    }
}
