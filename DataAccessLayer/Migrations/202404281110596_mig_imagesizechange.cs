﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_imagesizechange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Writers", "WriterImage", c => c.String(maxLength: 250));
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 250));
            AlterColumn("dbo.Writers", "WriterImage", c => c.String(maxLength: 100));
        }
    }
}
