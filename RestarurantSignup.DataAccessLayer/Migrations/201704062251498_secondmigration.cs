namespace RestarurantSignup.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "Menu_MenuID", "dbo.Menus");
            DropForeignKey("dbo.Menus", "ItemID_ItemID", "dbo.Items");
            DropForeignKey("dbo.Locations", "Mangers_MangerID", "dbo.Mangers");
            DropForeignKey("dbo.Menus", "Item_ItemID", "dbo.Items");
            DropIndex("dbo.Items", new[] { "Menu_MenuID" });
            DropIndex("dbo.Menus", new[] { "ItemID_ItemID" });
            DropIndex("dbo.Menus", new[] { "Item_ItemID" });
            DropIndex("dbo.Locations", new[] { "Mangers_MangerID" });
            CreateTable(
                "dbo.MenuItems",
                c => new
                    {
                        Menu_MenuID = c.Int(nullable: false),
                        Item_ItemID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Menu_MenuID, t.Item_ItemID })
                .ForeignKey("dbo.Menus", t => t.Menu_MenuID, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.Item_ItemID, cascadeDelete: true)
                .Index(t => t.Menu_MenuID)
                .Index(t => t.Item_ItemID);
            
            DropColumn("dbo.Items", "MenuID");
            DropColumn("dbo.Items", "Menu_MenuID");
            DropColumn("dbo.Menus", "ItemID_ItemID");
            DropColumn("dbo.Menus", "Item_ItemID");
            DropColumn("dbo.Locations", "Mangers_MangerID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locations", "Mangers_MangerID", c => c.Int());
            AddColumn("dbo.Menus", "Item_ItemID", c => c.Int());
            AddColumn("dbo.Menus", "ItemID_ItemID", c => c.Int());
            AddColumn("dbo.Items", "Menu_MenuID", c => c.Int());
            AddColumn("dbo.Items", "MenuID", c => c.Int(nullable: false));
            DropForeignKey("dbo.MenuItems", "Item_ItemID", "dbo.Items");
            DropForeignKey("dbo.MenuItems", "Menu_MenuID", "dbo.Menus");
            DropIndex("dbo.MenuItems", new[] { "Item_ItemID" });
            DropIndex("dbo.MenuItems", new[] { "Menu_MenuID" });
            DropTable("dbo.MenuItems");
            CreateIndex("dbo.Locations", "Mangers_MangerID");
            CreateIndex("dbo.Menus", "Item_ItemID");
            CreateIndex("dbo.Menus", "ItemID_ItemID");
            CreateIndex("dbo.Items", "Menu_MenuID");
            AddForeignKey("dbo.Menus", "Item_ItemID", "dbo.Items", "ItemID");
            AddForeignKey("dbo.Locations", "Mangers_MangerID", "dbo.Mangers", "MangerID");
            AddForeignKey("dbo.Menus", "ItemID_ItemID", "dbo.Items", "ItemID");
            AddForeignKey("dbo.Items", "Menu_MenuID", "dbo.Menus", "MenuID");
        }
    }
}
