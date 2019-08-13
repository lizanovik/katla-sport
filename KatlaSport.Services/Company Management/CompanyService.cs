using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using KatlaSport.DataAccess;
using KatlaSport.DataAccess.CompanyCatalogue;
using KatlaSport.Services.CompanyManagement;
using KatlaSport.Services.HiveManagement;

namespace KatlaSport.Services.Company_Management
{
    /// <summary>
    /// Represents a company service.
    /// </summary>
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyContext _context;
        private readonly IUserContext _userContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyService"/> class with specified <see cref="ICompanyContext"/> and <see cref="IUserContext"/>.
        /// </summary>
        /// <param name="context">A <see cref="ICompanyContext"/>.</param>
        /// <param name="userContext">A <see cref="IUserContext"/>.</param>
        public CompanyService(ICompanyContext context, IUserContext userContext)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _userContext = userContext ?? throw new ArgumentNullException();
        }

        /// <inheritdoc/>
        public Task<List<Company>> GetCompaniesAsync()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<Company> GetCompanyAsync(int companyId)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<Company> CreateCompanyAsync(Company createRequest)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<Company> UpdateCompanyAsync(int companyId, Company updateRequest)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task DeleteCompanyAsync(int companyId)
        {
            throw new System.NotImplementedException();
        }
    }
}
