namespace TimeSeriesForms_Kinyapin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.IsAnomalyCurrencies", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.MathOfCurrencies", "CurrencyId", "dbo.Currencies");
            DropIndex("dbo.IsAnomalyCurrencies", new[] { "CurrencyId" });
            DropIndex("dbo.MathOfCurrencies", new[] { "CurrencyId" });
            AddColumn("dbo.IsAnomalyCurrencies", "ValueCurrencyId", c => c.Int(nullable: false));
            AddColumn("dbo.MathOfCurrencies", "ValueCurrencyId", c => c.Int(nullable: false));
            CreateIndex("dbo.IsAnomalyCurrencies", "ValueCurrencyId");
            CreateIndex("dbo.MathOfCurrencies", "ValueCurrencyId");
            AddForeignKey("dbo.IsAnomalyCurrencies", "ValueCurrencyId", "dbo.ValueCurrencies", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MathOfCurrencies", "ValueCurrencyId", "dbo.ValueCurrencies", "Id", cascadeDelete: true);
            DropColumn("dbo.IsAnomalyCurrencies", "CurrencyId");
            DropColumn("dbo.MathOfCurrencies", "CurrencyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MathOfCurrencies", "CurrencyId", c => c.Int(nullable: false));
            AddColumn("dbo.IsAnomalyCurrencies", "CurrencyId", c => c.Int(nullable: false));
            DropForeignKey("dbo.MathOfCurrencies", "ValueCurrencyId", "dbo.ValueCurrencies");
            DropForeignKey("dbo.IsAnomalyCurrencies", "ValueCurrencyId", "dbo.ValueCurrencies");
            DropIndex("dbo.MathOfCurrencies", new[] { "ValueCurrencyId" });
            DropIndex("dbo.IsAnomalyCurrencies", new[] { "ValueCurrencyId" });
            DropColumn("dbo.MathOfCurrencies", "ValueCurrencyId");
            DropColumn("dbo.IsAnomalyCurrencies", "ValueCurrencyId");
            CreateIndex("dbo.MathOfCurrencies", "CurrencyId");
            CreateIndex("dbo.IsAnomalyCurrencies", "CurrencyId");
            AddForeignKey("dbo.MathOfCurrencies", "CurrencyId", "dbo.Currencies", "Id", cascadeDelete: true);
            AddForeignKey("dbo.IsAnomalyCurrencies", "CurrencyId", "dbo.Currencies", "Id", cascadeDelete: true);
        }
    }
}
