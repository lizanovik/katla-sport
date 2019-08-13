namespace KatlaSport.DataAccess.CompanyCatalogue.EmployeeCatalogue
{
    /// <summary>
    /// Represents a context for employee domain.
    /// </summary>
    public interface IEmployeeContext
    {
        /// <summary>
        /// Gets a set of <see cref="CatalogueEmployee"/> entities.
        /// </summary>
        IEntitySet<CatalogueEmployee> Employees { get; }
    }
}
