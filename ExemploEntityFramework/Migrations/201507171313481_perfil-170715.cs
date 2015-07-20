namespace ExemploEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class perfil170715 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Perfil", "ValorMaximoDescontoCaixa", c => c.Decimal(storeType: "money"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Perfil", "ValorMaximoDescontoCaixa");
        }
    }
}
