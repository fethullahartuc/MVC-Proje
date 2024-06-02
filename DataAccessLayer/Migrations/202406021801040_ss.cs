namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ImageFiles", "ImageName", c => c.String(maxLength: 100));
            DropColumn("dbo.ImageFiles", "ImageNamesteryo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ImageFiles", "ImageNamesteryo", c => c.String(maxLength: 100));
            DropColumn("dbo.ImageFiles", "ImageName");
        }
    }
}
