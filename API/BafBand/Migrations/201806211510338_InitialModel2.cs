namespace BafBand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Concerts", "Rating", c => c.String());
            AlterColumn("dbo.Concerts", "Date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Concerts", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Concerts", "Rating", c => c.Single(nullable: false));
        }
    }
}
