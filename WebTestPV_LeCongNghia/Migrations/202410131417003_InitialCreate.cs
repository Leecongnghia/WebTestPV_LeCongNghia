namespace WebTestPV_LeCongNghia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhoaHocs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenKhoaHoc = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenMonHoc = c.String(),
                        MoTa = c.String(),
                        KhoaHocID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.KhoaHocs", t => t.KhoaHocID, cascadeDelete: true)
                .Index(t => t.KhoaHocID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MonHocs", "KhoaHocID", "dbo.KhoaHocs");
            DropIndex("dbo.MonHocs", new[] { "KhoaHocID" });
            DropTable("dbo.MonHocs");
            DropTable("dbo.KhoaHocs");
        }
    }
}
