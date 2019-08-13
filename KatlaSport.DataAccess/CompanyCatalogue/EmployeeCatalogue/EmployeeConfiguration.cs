using System.Data.Entity.ModelConfiguration;

namespace KatlaSport.DataAccess.CompanyCatalogue.EmployeeCatalogue
{
    internal sealed class EmployeeConfiguration : EntityTypeConfiguration<CatalogueEmployee>
    {
        public EmployeeConfiguration()
        {
            ToTable("employee_records");
            HasKey(i => i.Id);
            Property(i => i.Id).HasColumnName("employee_id");
            Property(i => i.Name).HasColumnName("employee_name");
            Property(i => i.City).HasColumnName("employee_city");
            Property(i => i.Address).HasColumnName("employee_address");
            Property(i => i.DepartmentId).HasColumnName("employee_departmentId");
            Property(i => i.Photo).HasColumnName("employee_photo");
        }
    }
}
