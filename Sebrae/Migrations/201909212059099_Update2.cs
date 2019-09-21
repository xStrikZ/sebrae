namespace Sebrae.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HistoricoEnderecos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CNPJ = c.String(),
                        CEP = c.String(),
                        Estado = c.String(),
                        Cidade = c.String(),
                        Rua = c.String(),
                        Numero = c.String(),
                        Complemento = c.String(),
                        DataRegistro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PESSOA_JURIDICA",
                c => new
                    {
                        CPF_CNPJ = c.Long(nullable: false, identity: true),
                        DS_RAZAO = c.String(),
                        NM_FANTASIA = c.String(),
                        DS_PORTE = c.String(),
                        NR_COLABORADOR = c.String(),
                        DT_FUNDACAO = c.String(),
                        DS_CEP = c.String(),
                        SG_UF = c.String(),
                        DS_CIDADE = c.String(),
                        DS_ESTADO = c.String(),
                        DS_RUA = c.String(),
                        NR_RESIDENCIA = c.String(),
                        DS_COMPLEMENTO = c.String(),
                        DS_LATITUTE = c.String(),
                        DS_LONGITUDE = c.String(),
                        DS_MAPA = c.String(),
                        DS_EMAIL = c.String(),
                        DS_TELEFONE = c.String(),
                        DS_CELULAR = c.String(),
                        DS_COMERCIAL = c.String(),
                        DS_SETOR = c.String(),
                        DS_ATIVIDADE = c.String(),
                        QT_CLIENTES = c.Int(nullable: false),
                        QT_VISITAS = c.Int(nullable: false),
                        QT_REALIZADAS = c.Int(nullable: false),
                        QT_HORAS = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CPF_CNPJ);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Senha = c.String(nullable: false, maxLength: 120),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.PESSOA_JURIDICA");
            DropTable("dbo.HistoricoEnderecos");
        }
    }
}
