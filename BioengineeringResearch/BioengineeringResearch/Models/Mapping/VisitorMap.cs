using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BioengineeringResearch.Models.Mapping
{
    public class VisitorMap : EntityTypeConfiguration<Visitor>
    {
        public VisitorMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitorId);

            // Properties
            this.Property(t => t.InternalVisitorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.VisitorId)
                .IsRequired()
                .HasMaxLength(14)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Position)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Department)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Company)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Visitor");
            this.Property(t => t.InternalVisitorId).HasColumnName("InternalVisitorId");
            this.Property(t => t.VisitorId).HasColumnName("VisitorId");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.PIN).HasColumnName("PIN");
            this.Property(t => t.AccessLevel).HasColumnName("AccessLevel");
            this.Property(t => t.AccessGrantedDate).HasColumnName("AccessGrantedDate");
            this.Property(t => t.AuthorizedUntilDate).HasColumnName("AuthorizedUntilDate");
            this.Property(t => t.Position).HasColumnName("Position");
            this.Property(t => t.Department).HasColumnName("Department");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Email).HasColumnName("Email");
        }
    }
}
