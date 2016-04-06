namespace Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class playlist1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Albums", "Playlist");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Albums", "Playlist", c => c.String());
        }
    }
}
