namespace DW.CodeFirst.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DimDate",
                c => new
                    {
                        DimDateKey = c.Int(nullable: false),
                        FullDate = c.DateTime(nullable: false),
                        Day = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        MonthName = c.String(),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DimDateKey);
            
            CreateTable(
                "dbo.DimTime",
                c => new
                    {
                        DimTimeKey = c.Int(nullable: false),
                        Hour = c.Int(nullable: false),
                        Minute = c.Int(nullable: false),
                        Second = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DimTimeKey);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DimTime");
            DropTable("dbo.DimDate");
        }
    }
}
