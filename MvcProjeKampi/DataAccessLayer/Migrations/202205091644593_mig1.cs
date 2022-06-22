namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Contents", name: "Writer_WriterID", newName: "WriterID");
            RenameIndex(table: "dbo.Contents", name: "IX_Writer_WriterID", newName: "IX_WriterID");
            DropColumn("dbo.Contents", "WiterID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contents", "WiterID", c => c.Int());
            RenameIndex(table: "dbo.Contents", name: "IX_WriterID", newName: "IX_Writer_WriterID");
            RenameColumn(table: "dbo.Contents", name: "WriterID", newName: "Writer_WriterID");
        }
    }
}
