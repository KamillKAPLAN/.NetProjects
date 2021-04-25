namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        /* Değişiklikleri kaydedersek burası gerçekleşecek. */
        public override void Up()
        {
            AddColumn("dbo.Contents", "WriterId", c => c.Long());
            CreateIndex("dbo.Contents", "WriterId");
            AddForeignKey("dbo.Contents", "WriterId", "dbo.Writers", "WriterId");
        }
        /* Değişiklikleri kaydetmezsek burası gerçekleşecek. */
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "WriterId", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "WriterId" });
            DropColumn("dbo.Contents", "WriterId");
        }
    }
}
