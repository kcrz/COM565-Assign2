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
            this.Property(t => t.DoorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DoorTerminal");
            this.Property(t => t.DoorId).HasColumnName("DoorId");
            this.Property(t => t.MinimumLevelReq).HasColumnName("MinimumLevelReq");
        }
    }
}
