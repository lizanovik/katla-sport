using System.Collections.Generic;
using System.Threading.Tasks;

namespace KatlaSport.Services.CompanyManagement
{
    /// <summary>
    /// Represents a company service.
    /// </summary>
    public interface ICompanyService
    {
        /// <summary>
        /// Gets a companies list.
        /// </summary>
        /// <returns>A <see cref="Task{List{Company}}"/>.</returns>
        Task<List<Company>> GetCompaniesAsync();

        /// <summary>
        /// Gets a company with specified identifier.
        /// </summary>
        /// <param name="companyId">A hive identifier.</param>
        /// <returns>A <see cref="Task{Company}"/>.</returns>
        Task<Company> GetCompanyAsync(int companyId);

        /// <summary>
        /// Creates a new company.
        /// </summary>
        /// <param name="createRequest">A <see cref="Company"/>.</param>
        /// <returns>A <see cref="Task{Company}"/>.</returns>
        Task<Company> CreateCompanyAsync(Company createRequest);

        /// <summary>
        /// Updates an existed company.
        /// </summary>
        /// <param name="companyId">A company identifier.</param>
        /// <param name="updateRequest">A <see cref="Company"/>.</param>
        /// <returns>A <see cref="Task{Hive}"/>.</returns>
        Task<Company> UpdateCompanyAsync(int companyId, Company updateRequest);

        /// <summary>
        /// Deletes an existed company.
        /// </summary>
        /// <param name="companyId">A company identifier.</param>
        /// <returns><placeholder>A <see cref="Task"/> representing the asynchronous operation.</placeholder></returns>
        Task DeleteCompanyAsync(int companyId);
    }
}
