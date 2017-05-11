namespace RestarurantSignup.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedRestaccmangId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "LocationName", c => c.String());
            DropColumn("dbo.Locations", "MetroArea");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locations", "MetroArea", c => c.String());
            DropColumn("dbo.Locations", "LocationName");
        }
    }
}
