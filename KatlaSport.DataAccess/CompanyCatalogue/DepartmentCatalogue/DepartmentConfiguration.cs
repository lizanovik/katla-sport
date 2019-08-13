using System.Data.Entity.ModelConfiguration;

namespace KatlaSport.DataAccess.CompanyCatalogue.DepartmentCatalogue
{
    internal sealed class DepartmentConfiguration : EntityTypeConfiguration<CatalogueDepartment>
    {
        public DepartmentConfiguration()
        {
            ToTable("department_records");
            HasKey(i => i.Id);
            Property(i => i.Id).HasColumnName("department_id");
            Property(i => i.Name).HasColumnName("department_name");
            Property(i => i.ParentDepartmentId).HasColumnName("parent_department_id");
            Property(i => i.ChiefId).HasColumnName("department_chiefId");
        }
    }
}
