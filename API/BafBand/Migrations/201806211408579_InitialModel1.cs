namespace BafBand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "Name", c => c.String());
            AddColumn("dbo.Reservations", "Place", c => c.String());
            AddColumn("dbo.Reservations", "Rating", c => c.String());
            AddColumn("dbo.Reservations", "Date", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "Date");
            DropColumn("dbo.Reservations", "Rating");
            DropColumn("dbo.Reservations", "Place");
            DropColumn("dbo.Reservations", "Name");
        }
    }
}
