namespace PostgreSQLEntityOrnek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Birims",
                c => new
                    {
                        birimid = c.Int(nullable: false, identity: true),
                        birimad = c.String(),
                    })
                .PrimaryKey(t => t.birimid);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        personelid = c.Int(nullable: false, identity: true),
                        adsoyad = c.String(),
                        birim = c.String(),
                    })
                .PrimaryKey(t => t.personelid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personels");
            DropTable("dbo.Birims");
        }
    }
}
