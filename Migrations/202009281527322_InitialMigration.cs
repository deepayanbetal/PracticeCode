namespace PracticeProgramms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentRoll = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Class = c.String(),
                    })
                .PrimaryKey(t => t.StudentRoll);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
