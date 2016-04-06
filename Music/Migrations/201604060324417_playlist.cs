namespace Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class playlist : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Playlist", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "Playlist");
        }
    }
}
