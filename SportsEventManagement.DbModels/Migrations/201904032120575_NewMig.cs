namespace SportsEventManagement.DbModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Sports_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sports", t => t.Sports_Id)
                .Index(t => t.Sports_Id);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        teamId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.teamId, cascadeDelete: true)
                .Index(t => t.teamId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatchId = c.Int(nullable: false),
                        ParticipantId = c.Int(nullable: false),
                        score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Matches", t => t.MatchId, cascadeDelete: true)
                .ForeignKey("dbo.Participants", t => t.ParticipantId, cascadeDelete: true)
                .Index(t => t.MatchId)
                .Index(t => t.ParticipantId);
            
            CreateTable(
                "dbo.TeamManagments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamId = c.Int(nullable: false),
                        CompetitionId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId)
                .Index(t => t.CompetitionId);
            
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventId = c.Int(nullable: false),
                        Name = c.String(),
                        ISActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .Index(t => t.EventId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamManagments", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.TeamManagments", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.Competitions", "EventId", "dbo.Events");
            DropForeignKey("dbo.Scores", "ParticipantId", "dbo.Participants");
            DropForeignKey("dbo.Scores", "MatchId", "dbo.Matches");
            DropForeignKey("dbo.Matches", "teamId", "dbo.Teams");
            DropForeignKey("dbo.Events", "Sports_Id", "dbo.Sports");
            DropIndex("dbo.Competitions", new[] { "EventId" });
            DropIndex("dbo.TeamManagments", new[] { "CompetitionId" });
            DropIndex("dbo.TeamManagments", new[] { "TeamId" });
            DropIndex("dbo.Scores", new[] { "ParticipantId" });
            DropIndex("dbo.Scores", new[] { "MatchId" });
            DropIndex("dbo.Matches", new[] { "teamId" });
            DropIndex("dbo.Events", new[] { "Sports_Id" });
            DropTable("dbo.Competitions");
            DropTable("dbo.TeamManagments");
            DropTable("dbo.Scores");
            DropTable("dbo.Participants");
            DropTable("dbo.Teams");
            DropTable("dbo.Matches");
            DropTable("dbo.Sports");
            DropTable("dbo.Events");
        }
    }
}
