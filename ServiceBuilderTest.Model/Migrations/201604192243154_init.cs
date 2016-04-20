namespace ServiceBuilderTest.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Application",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Privilege",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ApplicationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Application", t => t.ApplicationId, cascadeDelete: true)
                .Index(t => t.ApplicationId);
            
            CreateTable(
                "dbo.GroupPrivilege",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupId = c.Int(nullable: false),
                        PrivilegeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Privilege", t => t.PrivilegeId, cascadeDelete: true)
                .ForeignKey("dbo.Group", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.GroupId)
                .Index(t => t.PrivilegeId);
            
            CreateTable(
                "dbo.OrganizationPrivilege",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        PrivilegeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Privilege", t => t.PrivilegeId, cascadeDelete: true)
                .ForeignKey("dbo.Organization", t => t.OrganizationId, cascadeDelete: true)
                .Index(t => t.OrganizationId)
                .Index(t => t.PrivilegeId);
            
            CreateTable(
                "dbo.UserPrivilege",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        PrivilegeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Privilege", t => t.PrivilegeId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.PrivilegeId);
            
            CreateTable(
                "dbo.Group",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ParentOrganizationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organization", t => t.ParentOrganizationId, cascadeDelete: true)
                .Index(t => t.ParentOrganizationId);
            
            CreateTable(
                "dbo.Organization",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserOrganization",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        OrganizationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organization", t => t.OrganizationId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.OrganizationId);
            
            CreateTable(
                "dbo.UserGroup",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Group", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserPrivilege", "UserId", "dbo.User");
            DropForeignKey("dbo.UserOrganization", "UserId", "dbo.User");
            DropForeignKey("dbo.UserGroup", "UserId", "dbo.User");
            DropForeignKey("dbo.UserGroup", "GroupId", "dbo.Group");
            DropForeignKey("dbo.UserOrganization", "OrganizationId", "dbo.Organization");
            DropForeignKey("dbo.OrganizationPrivilege", "OrganizationId", "dbo.Organization");
            DropForeignKey("dbo.Group", "ParentOrganizationId", "dbo.Organization");
            DropForeignKey("dbo.GroupPrivilege", "GroupId", "dbo.Group");
            DropForeignKey("dbo.UserPrivilege", "PrivilegeId", "dbo.Privilege");
            DropForeignKey("dbo.OrganizationPrivilege", "PrivilegeId", "dbo.Privilege");
            DropForeignKey("dbo.GroupPrivilege", "PrivilegeId", "dbo.Privilege");
            DropForeignKey("dbo.Privilege", "ApplicationId", "dbo.Application");
            DropIndex("dbo.UserGroup", new[] { "GroupId" });
            DropIndex("dbo.UserGroup", new[] { "UserId" });
            DropIndex("dbo.UserOrganization", new[] { "OrganizationId" });
            DropIndex("dbo.UserOrganization", new[] { "UserId" });
            DropIndex("dbo.Group", new[] { "ParentOrganizationId" });
            DropIndex("dbo.UserPrivilege", new[] { "PrivilegeId" });
            DropIndex("dbo.UserPrivilege", new[] { "UserId" });
            DropIndex("dbo.OrganizationPrivilege", new[] { "PrivilegeId" });
            DropIndex("dbo.OrganizationPrivilege", new[] { "OrganizationId" });
            DropIndex("dbo.GroupPrivilege", new[] { "PrivilegeId" });
            DropIndex("dbo.GroupPrivilege", new[] { "GroupId" });
            DropIndex("dbo.Privilege", new[] { "ApplicationId" });
            DropTable("dbo.User");
            DropTable("dbo.UserGroup");
            DropTable("dbo.UserOrganization");
            DropTable("dbo.Organization");
            DropTable("dbo.Group");
            DropTable("dbo.UserPrivilege");
            DropTable("dbo.OrganizationPrivilege");
            DropTable("dbo.GroupPrivilege");
            DropTable("dbo.Privilege");
            DropTable("dbo.Application");
        }
    }
}
