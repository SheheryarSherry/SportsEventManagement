namespace SportsEventManagement.DbModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "Name");
        }
    }
}
