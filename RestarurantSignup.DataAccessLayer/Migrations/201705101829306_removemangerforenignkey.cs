namespace RestarurantSignup.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removemangerforenignkey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RestarurantAccounts", "MangerID", "dbo.Mangers");
            DropIndex("dbo.RestarurantAccounts", new[] { "MangerID" });
            RenameColumn(table: "dbo.RestarurantAccounts", name: "MangerID", newName: "Mangers_MangerID");
            AlterColumn("dbo.RestarurantAccounts", "Mangers_MangerID", c => c.Int());
            CreateIndex("dbo.RestarurantAccounts", "Mangers_MangerID");
            AddForeignKey("dbo.RestarurantAccounts", "Mangers_MangerID", "dbo.Mangers", "MangerID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RestarurantAccounts", "Mangers_MangerID", "dbo.Mangers");
            DropIndex("dbo.RestarurantAccounts", new[] { "Mangers_MangerID" });
            AlterColumn("dbo.RestarurantAccounts", "Mangers_MangerID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.RestarurantAccounts", name: "Mangers_MangerID", newName: "MangerID");
            CreateIndex("dbo.RestarurantAccounts", "MangerID");
            AddForeignKey("dbo.RestarurantAccounts", "MangerID", "dbo.Mangers", "MangerID", cascadeDelete: true);
        }
    }
}
