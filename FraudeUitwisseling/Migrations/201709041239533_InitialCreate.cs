namespace FraudeUitwisseling.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fraudesignaals",
                c => new
                    {
                        FraudesignaalId = c.Int(nullable: false, identity: true),
                        FraudeID_FraudeIDId = c.Int(),
                    })
                .PrimaryKey(t => t.FraudesignaalId)
                .ForeignKey("dbo.FraudeIDs", t => t.FraudeID_FraudeIDId)
                .Index(t => t.FraudeID_FraudeIDId);
            
            CreateTable(
                "dbo.FraudeIDs",
                c => new
                    {
                        FraudeIDId = c.Int(nullable: false, identity: true),
                        SignaalType = c.Int(nullable: false),
                        SignaalNummer = c.Int(nullable: false),
                        AanleverDatumTijd = c.DateTime(nullable: false),
                        AanleverOrganisatieID = c.String(maxLength: 3),
                        InternKenmerk = c.String(),
                        SignaleringDatumTijd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FraudeIDId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fraudesignaals", "FraudeID_FraudeIDId", "dbo.FraudeIDs");
            DropIndex("dbo.Fraudesignaals", new[] { "FraudeID_FraudeIDId" });
            DropTable("dbo.FraudeIDs");
            DropTable("dbo.Fraudesignaals");
        }
    }
}
