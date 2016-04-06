namespace Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class playlistalbum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Playlists", "Album_AlbumID", c => c.Int());
            CreateIndex("dbo.Playlists", "Album_AlbumID");
            AddForeignKey("dbo.Playlists", "Album_AlbumID", "dbo.Albums", "AlbumID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Playlists", "Album_AlbumID", "dbo.Albums");
            DropIndex("dbo.Playlists", new[] { "Album_AlbumID" });
            DropColumn("dbo.Playlists", "Album_AlbumID");
        }
    }
}
