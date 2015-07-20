namespace ExemploEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usuario_perfil : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuario", "IdPerfil", c => c.Int());
            CreateIndex("dbo.Usuario", "IdPerfil");
            AddForeignKey("dbo.Usuario", "IdPerfil", "dbo.Perfil", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "IdPerfil", "dbo.Perfil");
            DropIndex("dbo.Usuario", new[] { "IdPerfil" });
            DropColumn("dbo.Usuario", "IdPerfil");
        }
    }
}
