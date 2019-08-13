using System.Collections.Generic;
using KatlaSport.DataAccess.CompanyCatalogue.EmployeeCatalogue;

namespace KatlaSport.DataAccess.CompanyCatalogue.DepartmentCatalogue
{
    public class CatalogueDepartment
    {
        /// <summary>
        /// Gets or sets a department identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a department name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a list of department subdepartments.
        /// </summary>
        public virtual ICollection<CatalogueDepartment> Departments { get; set; }

        /// <summary>
        /// Gets or sets an id of parent departments.
        /// </summary>
        public virtual int ParentDepartmentId { get; set; }

        /// <summary>
        /// Gets or sets a department chief.
        /// </summary>
        public int ChiefId { get; set; }

        /// <summary>
        /// Gets or sets a list of department employees.
        /// </summary>
        public virtual ICollection<CatalogueEmployee> Employees { get; set; }
    }
}
