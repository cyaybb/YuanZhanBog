namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserInviteCodeAddUnique : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Users", "InviteCode", unique: true, name: "IX_Users_Invitecode");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", "IX_Users_Invitecode");
        }
    }
}
