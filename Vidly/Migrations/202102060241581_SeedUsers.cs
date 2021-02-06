namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3f76644c-140a-499e-9823-6d1b9ba215ae', N'admin@vidly.com', 0, N'ACHJMF0bm2dHGxmDe81xnVkuapDK5njpwf3tYDtn6Z7VbzQAwG4l9FsXED1N2B6DaQ==', N'a76322a8-668c-4aa0-96fc-6b74161fe1fe', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4c4a41b0-c10d-423a-884a-4ec2d413dda3', N'guest@vidly.com', 0, N'AMkX7FdUnYNsuOFvs+24c/Xm3vLwRE9wD5ZaZOumscsJfYJk9SYbwPvMUzvfsDJk0A==', N'031719b1-9cd9-43c5-824f-469c95e4dfc3', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bca52666-bb1f-4387-8812-d1f6b3a6336f', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3f76644c-140a-499e-9823-6d1b9ba215ae', N'bca52666-bb1f-4387-8812-d1f6b3a6336f')


");

        }
        
        public override void Down()
        {
        }
    }
}
