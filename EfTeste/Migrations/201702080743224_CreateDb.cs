namespace EfTeste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Documento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PessoaId = c.Int(nullable: false),
                        DocumentoTipoId = c.Int(nullable: false),
                        Numero = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DocumentoTipo", t => t.DocumentoTipoId, cascadeDelete: true)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId, cascadeDelete: true)
                .Index(t => t.PessoaId)
                .Index(t => t.DocumentoTipoId);
            
            CreateTable(
                "dbo.DocumentoTipo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Documento", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.Documento", "DocumentoTipoId", "dbo.DocumentoTipo");
            DropIndex("dbo.Documento", new[] { "DocumentoTipoId" });
            DropIndex("dbo.Documento", new[] { "PessoaId" });
            DropTable("dbo.Pessoa");
            DropTable("dbo.DocumentoTipo");
            DropTable("dbo.Documento");
        }
    }
}
