namespace RestarurantSignup.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemID = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        Descrption = c.String(),
                        ItemImage = c.String(),
                        Quantity = c.String(),
                        deliveryOption = c.String(),
                        OfferedDay = c.Int(nullable: false),
                        ServeTimeIn = c.String(),
                        ServetimeOut = c.String(),
                        TimeToPrepare = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MenuID = c.Int(nullable: false),
                        Menu_MenuID = c.Int(),
                    })
                .PrimaryKey(t => t.ItemID)
                .ForeignKey("dbo.Menus", t => t.Menu_MenuID)
                .Index(t => t.Menu_MenuID);

            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        MenuID = c.Int(nullable: false, identity: true),
                        MenuName = c.String(),
                        LocationID = c.Int(nullable: false),
                        ItemID_ItemID = c.Int(),
                        Item_ItemID = c.Int(),
                    })
                .PrimaryKey(t => t.MenuID)
                .ForeignKey("dbo.Items", t => t.ItemID_ItemID)
                .ForeignKey("dbo.Locations", t => t.LocationID, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.Item_ItemID)
                .Index(t => t.LocationID)
                .Index(t => t.ItemID_ItemID)
                .Index(t => t.Item_ItemID);

            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationID = c.Int(nullable: false, identity: true),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zipcode = c.Int(nullable: false),
                        County = c.String(),
                        MetroArea = c.String(),
                        LocationPhone = c.String(),
                        LocationFaxNumber = c.Int(nullable: false),
                        RestarurantID = c.Int(nullable: false),
                        RestarurantAccount_RestarurantAccountID = c.Int(),
                        Mangers_MangerID = c.Int(),
                    })
                .PrimaryKey(t => t.LocationID)
                .ForeignKey("dbo.RestarurantAccounts", t => t.RestarurantAccount_RestarurantAccountID)
                .ForeignKey("dbo.Mangers", t => t.Mangers_MangerID)
                .Index(t => t.RestarurantAccount_RestarurantAccountID)
                .Index(t => t.Mangers_MangerID);

            CreateTable(
                "dbo.Mangers",
                c => new
                    {
                        MangerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Title = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zipcode = c.Int(nullable: false),
                        MetroArea = c.String(),
                        PrimaryPhone = c.String(),
                        FaxNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MangerID);

            CreateTable(
                "dbo.RestarurantAccounts",
                c => new
                    {
                        RestarurantAccountID = c.Int(nullable: false, identity: true),
                        RestarurantName = c.String(),
                        Image = c.String(),
                        Cuisine = c.String(),
                        MangerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RestarurantAccountID)
                .ForeignKey("dbo.Mangers", t => t.MangerID, cascadeDelete: true)
                .Index(t => t.MangerID);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Menus", "Item_ItemID", "dbo.Items");
            DropForeignKey("dbo.Menus", "LocationID", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Mangers_MangerID", "dbo.Mangers");
            DropForeignKey("dbo.RestarurantAccounts", "MangerID", "dbo.Mangers");
            DropForeignKey("dbo.Locations", "RestarurantAccount_RestarurantAccountID", "dbo.RestarurantAccounts");
            DropForeignKey("dbo.Menus", "ItemID_ItemID", "dbo.Items");
            DropForeignKey("dbo.Items", "Menu_MenuID", "dbo.Menus");
            DropIndex("dbo.RestarurantAccounts", new[] { "MangerID" });
            DropIndex("dbo.Locations", new[] { "Mangers_MangerID" });
            DropIndex("dbo.Locations", new[] { "RestarurantAccount_RestarurantAccountID" });
            DropIndex("dbo.Menus", new[] { "Item_ItemID" });
            DropIndex("dbo.Menus", new[] { "ItemID_ItemID" });
            DropIndex("dbo.Menus", new[] { "LocationID" });
            DropIndex("dbo.Items", new[] { "Menu_MenuID" });
            DropTable("dbo.RestarurantAccounts");
            DropTable("dbo.Mangers");
            DropTable("dbo.Locations");
            DropTable("dbo.Menus");
            DropTable("dbo.Items");
        }
    }
}
