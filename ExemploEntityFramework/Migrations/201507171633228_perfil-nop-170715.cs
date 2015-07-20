namespace ExemploEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class perfilnop170715 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nop",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 80, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PerfilNop",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IdNop = c.Int(nullable: false),
                        IdPerfil = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nop", t => t.IdNop, cascadeDelete: true)
                .ForeignKey("dbo.Perfil", t => t.IdPerfil, cascadeDelete: true)
                .Index(t => t.IdNop)
                .Index(t => t.IdPerfil);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PerfilNop", "IdPerfil", "dbo.Perfil");
            DropForeignKey("dbo.PerfilNop", "IdNop", "dbo.Nop");
            DropIndex("dbo.PerfilNop", new[] { "IdPerfil" });
            DropIndex("dbo.PerfilNop", new[] { "IdNop" });
            DropTable("dbo.PerfilNop");
            DropTable("dbo.Nop");
        }
    }
}
