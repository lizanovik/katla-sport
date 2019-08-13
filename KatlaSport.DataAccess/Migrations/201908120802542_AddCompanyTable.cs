using System.Data.Entity.Migrations;

namespace KatlaSport.DataAccess.Migrations
{
    public partial class AddCompanyTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.company_records",
                c => new
                    {
                        company_id = c.Int(nullable: false, identity: true),
                        company_name = c.String(),
                        company_city = c.String(),
                        company_address = c.String(),
                        company_chiefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.company_id);

            CreateTable(
                "dbo.department_records",
                c => new
                    {
                        department_id = c.Int(nullable: false, identity: true),
                        department_name = c.String(),
                        department_chiefId = c.Int(nullable: false),
                        CatalogueDepartment_Id = c.Int(),
                        CatalogueCompany_Id = c.Int(),
                    })
                .PrimaryKey(t => t.department_id)
                .ForeignKey("dbo.department_records", t => t.CatalogueDepartment_Id)
                .ForeignKey("dbo.company_records", t => t.CatalogueCompany_Id)
                .Index(t => t.CatalogueDepartment_Id)
                .Index(t => t.CatalogueCompany_Id);

            CreateTable(
                "dbo.employee_records",
                c => new
                    {
                        employee_id = c.Int(nullable: false, identity: true),
                        employee_name = c.String(),
                        employee_city = c.String(),
                        employee_address = c.String(),
                        employee_departmentId = c.Int(),
                        employee_photo = c.String(),
                        CatalogueDepartment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.employee_id)
                .ForeignKey("dbo.department_records", t => t.CatalogueDepartment_Id)
                .Index(t => t.CatalogueDepartment_Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.department_records", "CatalogueCompany_Id", "dbo.company_records");
            DropForeignKey("dbo.employee_records", "CatalogueDepartment_Id", "dbo.department_records");
            DropForeignKey("dbo.department_records", "CatalogueDepartment_Id", "dbo.department_records");
            DropIndex("dbo.employee_records", new[] { "CatalogueDepartment_Id" });
            DropIndex("dbo.department_records", new[] { "CatalogueCompany_Id" });
            DropIndex("dbo.department_records", new[] { "CatalogueDepartment_Id" });
            DropTable("dbo.employee_records");
            DropTable("dbo.department_records");
            DropTable("dbo.company_records");
        }
    }
}
