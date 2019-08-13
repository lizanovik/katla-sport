namespace KatlaSport.Services.CompanyManagement
{
    /// <summary>
    /// Represents an employee.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets an employee identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets an employee name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets an employee location.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets an employee address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets an employee department.
        /// </summary>
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets URI of an employee photo.
        /// </summary>
        public string Photo { get; set; }
    }
}