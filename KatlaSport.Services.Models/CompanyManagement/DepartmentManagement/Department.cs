using System.Collections.Generic;

namespace KatlaSport.Services.CompanyManagement
{
    /// <summary>
    /// Represents a department.
    /// </summary>
    public class Department
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
        public virtual ICollection<Department> Departments { get; set; }

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
        public virtual ICollection<Employee> Employees { get; set; }
    }
}