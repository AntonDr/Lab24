namespace LabProductUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Production.Product",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        Category = c.Int(nullable: false),
                        PictureLink = c.String(),
                        ModifiedDate = c.DateTime(),
                        CreatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropTable("Production.Product");
        }
    }
}
