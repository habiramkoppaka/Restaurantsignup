namespace RestarurantSignup.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZIPCodestring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mangers", "Zipcode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mangers", "Zipcode", c => c.Int(nullable: false));
        }
    }
}
