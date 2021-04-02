namespace DongYang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuthorityGroups",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        AuthorityGroupName = c.String(),
                        Sort = c.Int(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserAuthorities",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(maxLength: 128),
                        AuthorityGroupId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AuthorityGroups", t => t.AuthorityGroupId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.AuthorityGroupId);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        WorkOrderId = c.String(),
                        PrintedDate = c.DateTime(nullable: false),
                        Barcode = c.String(),
                        QuantityActual = c.Single(nullable: false),
                        QuantityRemain = c.Single(nullable: false),
                        CompletedStatus = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LanguageLibraries",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Vietnamese = c.String(),
                        English = c.String(),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Productions",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Barcode = c.String(),
                        ScanDate = c.DateTime(nullable: false),
                        ProductionStatus = c.Int(nullable: false),
                        Action = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        PartNumber = c.String(),
                        Model = c.String(),
                        PartName = c.String(),
                        PartNameShort = c.String(),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SettingMasters",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Company = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        TaxCode = c.String(),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShipmentOrderDetails",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ShipmentOrderId = c.String(),
                        Barcode = c.String(),
                        ExportedDate = c.DateTime(nullable: false),
                        QuantityActual = c.Single(nullable: false),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShipmentOrders",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ShipmentOrderNo = c.String(),
                        ShipmentOrderDate = c.DateTime(nullable: false),
                        Model = c.String(),
                        PartNumber = c.String(),
                        PartName = c.String(),
                        PartNameShort = c.String(),
                        Quantity = c.Single(nullable: false),
                        CompletedStatus = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Username = c.String(),
                        Salt = c.String(),
                        Password = c.String(),
                        FullName = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        Gender = c.Int(nullable: false),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkOrders",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        WorkOrderNo = c.String(),
                        WorkOrderDate = c.DateTime(nullable: false),
                        PartNumber = c.String(),
                        Model = c.String(),
                        PartName = c.String(),
                        PartNameShort = c.String(),
                        Quantity = c.Single(nullable: false),
                        QuantityPerCart = c.Single(nullable: false),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserAuthorities", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserAuthorities", "AuthorityGroupId", "dbo.AuthorityGroups");
            DropIndex("dbo.UserAuthorities", new[] { "AuthorityGroupId" });
            DropIndex("dbo.UserAuthorities", new[] { "UserId" });
            DropTable("dbo.WorkOrders");
            DropTable("dbo.Users");
            DropTable("dbo.ShipmentOrders");
            DropTable("dbo.ShipmentOrderDetails");
            DropTable("dbo.SettingMasters");
            DropTable("dbo.Products");
            DropTable("dbo.Productions");
            DropTable("dbo.LanguageLibraries");
            DropTable("dbo.Inventories");
            DropTable("dbo.UserAuthorities");
            DropTable("dbo.AuthorityGroups");
        }
    }
}
