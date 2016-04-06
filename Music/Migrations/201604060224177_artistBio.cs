namespace Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class artistBio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Artists", "Bio", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Artists", "Bio");
        }
    }
}
