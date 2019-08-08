namespace SchoolSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovoMigration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Materias",
                c => new
                    {
                        IdMateria = c.Int(nullable: false, identity: true),
                        NomeMateria = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdMateria);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        IdProfessor = c.Int(nullable: false, identity: true),
                        NomeProfessor = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdProfessor);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Professors");
            DropTable("dbo.Materias");
        }
    }
}
