namespace TimeSeriesForms_Kinyapin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameCurrency = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IsAnomalyCurrencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrencyId = c.Int(nullable: false),
                        IsAnomaly = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId, cascadeDelete: true)
                .Index(t => t.CurrencyId);
            
            CreateTable(
                "dbo.MathOfCurrencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrencyId = c.Int(nullable: false),
                        PredictionValue = c.Double(nullable: false),
                        PredictionValueMax = c.Double(nullable: false),
                        PredictionValueMin = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId, cascadeDelete: true)
                .Index(t => t.CurrencyId);
            
            CreateTable(
                "dbo.ValueCurrencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrencyId = c.Int(nullable: false),
                        Value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId, cascadeDelete: true)
                .Index(t => t.CurrencyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ValueCurrencies", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.MathOfCurrencies", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.IsAnomalyCurrencies", "CurrencyId", "dbo.Currencies");
            DropIndex("dbo.ValueCurrencies", new[] { "CurrencyId" });
            DropIndex("dbo.MathOfCurrencies", new[] { "CurrencyId" });
            DropIndex("dbo.IsAnomalyCurrencies", new[] { "CurrencyId" });
            DropTable("dbo.ValueCurrencies");
            DropTable("dbo.MathOfCurrencies");
            DropTable("dbo.IsAnomalyCurrencies");
            DropTable("dbo.Currencies");
        }
    }
}
