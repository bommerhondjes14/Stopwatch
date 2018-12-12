namespace Stopwatch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changed_KeyToIntIdToString : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Recommendeds", "StaticChampion_Id", "dbo.StaticChampions");
            DropForeignKey("dbo.Skins", "StaticChampion_Id", "dbo.StaticChampions");
            DropForeignKey("dbo.StaticChampionSpells", "StaticChampion_Id", "dbo.StaticChampions");
            RenameColumn(table: "dbo.Recommendeds", name: "StaticChampion_Id", newName: "StaticChampion_Key");
            RenameColumn(table: "dbo.Skins", name: "StaticChampion_Id", newName: "StaticChampion_Key");
            RenameColumn(table: "dbo.StaticChampionSpells", name: "StaticChampion_Id", newName: "StaticChampion_Key");
            RenameIndex(table: "dbo.Recommendeds", name: "IX_StaticChampion_Id", newName: "IX_StaticChampion_Key");
            RenameIndex(table: "dbo.Skins", name: "IX_StaticChampion_Id", newName: "IX_StaticChampion_Key");
            RenameIndex(table: "dbo.StaticChampionSpells", name: "IX_StaticChampion_Id", newName: "IX_StaticChampion_Key");
            DropPrimaryKey("dbo.StaticChampions");
            AddColumn("dbo.StaticChampions", "Version", c => c.String());
            AlterColumn("dbo.StaticChampions", "Id", c => c.String());
            AlterColumn("dbo.StaticChampions", "Key", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.StaticChampions", "Key");
            AddForeignKey("dbo.Recommendeds", "StaticChampion_Key", "dbo.StaticChampions", "Key");
            AddForeignKey("dbo.Skins", "StaticChampion_Key", "dbo.StaticChampions", "Key");
            AddForeignKey("dbo.StaticChampionSpells", "StaticChampion_Key", "dbo.StaticChampions", "Key");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StaticChampionSpells", "StaticChampion_Key", "dbo.StaticChampions");
            DropForeignKey("dbo.Skins", "StaticChampion_Key", "dbo.StaticChampions");
            DropForeignKey("dbo.Recommendeds", "StaticChampion_Key", "dbo.StaticChampions");
            DropPrimaryKey("dbo.StaticChampions");
            AlterColumn("dbo.StaticChampions", "Key", c => c.String());
            AlterColumn("dbo.StaticChampions", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.StaticChampions", "Version");
            AddPrimaryKey("dbo.StaticChampions", "Id");
            RenameIndex(table: "dbo.StaticChampionSpells", name: "IX_StaticChampion_Key", newName: "IX_StaticChampion_Id");
            RenameIndex(table: "dbo.Skins", name: "IX_StaticChampion_Key", newName: "IX_StaticChampion_Id");
            RenameIndex(table: "dbo.Recommendeds", name: "IX_StaticChampion_Key", newName: "IX_StaticChampion_Id");
            RenameColumn(table: "dbo.StaticChampionSpells", name: "StaticChampion_Key", newName: "StaticChampion_Id");
            RenameColumn(table: "dbo.Skins", name: "StaticChampion_Key", newName: "StaticChampion_Id");
            RenameColumn(table: "dbo.Recommendeds", name: "StaticChampion_Key", newName: "StaticChampion_Id");
            AddForeignKey("dbo.StaticChampionSpells", "StaticChampion_Id", "dbo.StaticChampions", "Id");
            AddForeignKey("dbo.Skins", "StaticChampion_Id", "dbo.StaticChampions", "Id");
            AddForeignKey("dbo.Recommendeds", "StaticChampion_Id", "dbo.StaticChampions", "Id");
        }
    }
}
