namespace RestarurantSignup.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cusineupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RestarurantAccounts", "Cuisine", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RestarurantAccounts", "Cuisine", c => c.String());
        }
    }
}
