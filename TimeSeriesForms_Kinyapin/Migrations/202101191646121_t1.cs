namespace TimeSeriesForms_Kinyapin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ValueCurrencies", "Date", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ValueCurrencies", "Date");
        }
    }
}
