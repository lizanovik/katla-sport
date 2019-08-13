namespace KatlaSport.DataAccess.CompanyCatalogue.DepartmentCatalogue
{
    /// <summary>
    /// Represents a context for department domain.
    /// </summary>
    public interface IDepartmentContext
    {
        /// <summary>
        /// Gets a set of <see cref="CatalogueDepartment"/> entities.
        /// </summary>
        IEntitySet<CatalogueDepartment> Departments { get; }
    }
}
