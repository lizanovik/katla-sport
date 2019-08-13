using System.Collections.Generic;

namespace KatlaSport.Services.CompanyManagement
{
    /// <summary>
    /// Represents a company.
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Gets or sets a company identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a company name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a company location.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets a company address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets a company chief.
        /// </summary>
        public int ChiefId { get; set; }

        /// <summary>
        /// Gets or sets a list of company departments.
        /// </summary>
        public virtual ICollection<Department> Departments { get; set; }
    }
}
