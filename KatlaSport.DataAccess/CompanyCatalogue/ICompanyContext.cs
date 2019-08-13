namespace KatlaSport.DataAccess.CompanyCatalogue
{
    /// <summary>
    /// Represents a context for company domain.
    /// </summary>
    public interface ICompanyContext
    {
        /// <summary>
        /// Gets a set of <see cref="CatalogueCompany"/> entities.
        /// </summary>
        IEntitySet<CatalogueCompany> Companies { get; }
    }
}
