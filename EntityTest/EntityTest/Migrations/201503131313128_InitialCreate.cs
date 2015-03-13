namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunoes",
                c => new
                    {
                        AlunoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Endereco_Lougradouro = c.String(),
                        Endereco_Numero = c.Int(nullable: false),
                        Endereco_CEP = c.String(),
                        Turma_TurmaId = c.Int(),
                    })
                .PrimaryKey(t => t.AlunoID)
                .ForeignKey("dbo.Turmas", t => t.Turma_TurmaId)
                .Index(t => t.Turma_TurmaId);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        ProfessorID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Endereco_Lougradouro = c.String(),
                        Endereco_Numero = c.Int(nullable: false),
                        Endereco_CEP = c.String(),
                    })
                .PrimaryKey(t => t.ProfessorID);
            
            CreateTable(
                "dbo.Turmas",
                c => new
                    {
                        TurmaId = c.Int(nullable: false, identity: true),
                        Vagas = c.Int(nullable: false),
                        Professor_ProfessorID = c.Int(),
                    })
                .PrimaryKey(t => t.TurmaId)
                .ForeignKey("dbo.Professors", t => t.Professor_ProfessorID)
                .Index(t => t.Professor_ProfessorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turmas", "Professor_ProfessorID", "dbo.Professors");
            DropForeignKey("dbo.Alunoes", "Turma_TurmaId", "dbo.Turmas");
            DropIndex("dbo.Turmas", new[] { "Professor_ProfessorID" });
            DropIndex("dbo.Alunoes", new[] { "Turma_TurmaId" });
            DropTable("dbo.Turmas");
            DropTable("dbo.Professors");
            DropTable("dbo.Alunoes");
        }
    }
}
