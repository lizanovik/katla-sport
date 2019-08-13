using System.Data.Entity.Migrations;

namespace KatlaSport.DataAccess.Migrations
{
    public partial class AddPsrentDepartmentColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.department_records", "parent_department_id", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.department_records", "parent_department_id");
        }
    }
}
