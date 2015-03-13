namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIdadeToAluno : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alunoes", "idade", c => c.Int(nullable: false));           
        }
        
        public override void Down()
        {
            DropColumn("dbo.Alunoes", "idade");
        }
    }
}
