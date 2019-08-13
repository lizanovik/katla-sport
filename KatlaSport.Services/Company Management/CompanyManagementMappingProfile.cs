using AutoMapper;
using KatlaSport.DataAccess.CompanyCatalogue;
using KatlaSport.DataAccess.CompanyCatalogue.DepartmentCatalogue;
using KatlaSport.DataAccess.CompanyCatalogue.EmployeeCatalogue;
using KatlaSport.Services.CompanyManagement;

namespace KatlaSport.Services.Company_Management
{
    public sealed class CompanyManagementMappingProfile: Profile
    {
        public CompanyManagementMappingProfile()
        {
            CreateMap<CatalogueCompany, Company>();
            CreateMap<CatalogueDepartment, Department>();
            CreateMap<CatalogueEmployee, Employee>();
        }
    }
}
