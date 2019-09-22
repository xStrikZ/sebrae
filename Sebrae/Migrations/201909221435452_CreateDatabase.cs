namespace Sebrae.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Pontos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Pontos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PtsEndereco = c.Int(nullable: false),
                        PtsEmail = c.Int(nullable: false),
                        PtsSituacao = c.Int(nullable: false),
                        TotalPts = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
