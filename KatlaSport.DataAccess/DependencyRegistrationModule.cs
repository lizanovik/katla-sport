using Autofac;

namespace KatlaSport.DataAccess
{
    /// <summary>
    /// Represents an assembly dependency registration <see cref="Module"/>.
    /// </summary>
    public sealed class DependencyRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().InstancePerRequest();
            builder.RegisterType<ProductCatalogue.ProductCatalogueContext>().As<ProductCatalogue.IProductCatalogueContext>().InstancePerRequest();
            builder.RegisterType<ProductStoreHive.ProductStoreHiveContext>().As<ProductStoreHive.IProductStoreHiveContext>().InstancePerRequest();
            builder.RegisterType<ProductStore.ProductStoreContext>().As<ProductStore.IProductStoreContext>().InstancePerRequest();
            builder.RegisterType<CustomerCatalogue.CustomerContext>().As<CustomerCatalogue.ICustomerContext>().InstancePerRequest();
            builder.RegisterType<CompanyCatalogue.CompanyContext>().As<CompanyCatalogue.ICompanyContext>()
                .InstancePerRequest();
            builder.RegisterType<CompanyCatalogue.DepartmentCatalogue.DepartmentContext>().As<CompanyCatalogue.DepartmentCatalogue.IDepartmentContext>()
                .InstancePerRequest();
            builder.RegisterType<CompanyCatalogue.EmployeeCatalogue.EmployeeContext>().As<CompanyCatalogue.EmployeeCatalogue.IEmployeeContext>()
                .InstancePerRequest();
            builder.RegisterType<DebugDatabaseLogger>().As<IDatabaseLogger>();
        }
    }
}
