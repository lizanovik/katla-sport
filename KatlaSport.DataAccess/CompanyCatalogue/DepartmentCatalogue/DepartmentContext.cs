namespace KatlaSport.DataAccess.CompanyCatalogue.DepartmentCatalogue
{
    internal sealed class DepartmentContext : DomainContextBase<ApplicationDbContext>, IDepartmentContext
    {
        public DepartmentContext(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        public IEntitySet<CatalogueDepartment> Departments => GetDbSet<CatalogueDepartment>();
    }
}
