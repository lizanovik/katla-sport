using System.Data.Entity.ModelConfiguration;

namespace KatlaSport.DataAccess.CompanyCatalogue
{
    internal sealed class CompanyConfiguration : EntityTypeConfiguration<CatalogueCompany>
    {
        public CompanyConfiguration()
        {
            ToTable("company_records");
            HasKey(i => i.Id);
            Property(i => i.Id).HasColumnName("company_id");
            Property(i => i.Name).HasColumnName("company_name");
            Property(i => i.City).HasColumnName("company_city");
            Property(i => i.Address).HasColumnName("company_address");
            Property(i => i.ChiefId).HasColumnName("company_chiefId");
        }
    }
}
