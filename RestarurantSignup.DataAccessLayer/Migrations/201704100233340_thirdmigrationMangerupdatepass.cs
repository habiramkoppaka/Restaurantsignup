namespace RestarurantSignup.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdmigrationMangerupdatepass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mangers", "Email", c => c.String());
            AddColumn("dbo.Mangers", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mangers", "Password");
            DropColumn("dbo.Mangers", "Email");
        }
    }
}
