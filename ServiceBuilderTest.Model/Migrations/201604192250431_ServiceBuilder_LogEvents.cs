namespace ServiceBuilderTest.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServiceBuilder_LogEvents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogEvent",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LogEventType = c.String(),
                        EntityType = c.String(),
                        EntityId = c.String(),
                        ChangedByUserId = c.String(),
                        ChangedByUserName = c.String(),
                        Date = c.DateTime(nullable: false),
                        PropertyName = c.String(),
                        PropertyType = c.String(),
                        OldValue = c.String(),
                        NewValue = c.String(),
                        ErrorMessage = c.String(),
                        StackTrace = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LogEvent");
        }
    }
}
