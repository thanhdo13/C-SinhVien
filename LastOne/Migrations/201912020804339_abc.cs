namespace LastOne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 128),
                        HoTen = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                        GioiTinh = c.Int(nullable: false),
                        chuyennganh = c.Int(nullable: false),
                        cn1 = c.Single(nullable: false),
                        cn2 = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaSinhVien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SinhViens");
        }
    }
}
