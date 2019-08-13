namespace KatlaSport.DataAccess.CompanyCatalogue.EmployeeCatalogue
{
    internal sealed class EmployeeContext : DomainContextBase<ApplicationDbContext>, IEmployeeContext
    {
        public EmployeeContext(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        public IEntitySet<CatalogueEmployee> Employees => GetDbSet<CatalogueEmployee>();
    }
}
