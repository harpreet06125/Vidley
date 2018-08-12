namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'12cceff4-b1c5-4a7d-b8df-ba5855b8c8d5', N'guest@vidly.com', 0, N'AEEql+b4zctdtlTglsvhPoB6jFbGabrTauEyBrzMK48yFCUQtPrfbhhkLPO2r/UJFg==', N'd9bb350b-36c0-4b98-b0cc-c701372b245b', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'60f54128-87e6-4a8a-b59c-7d8aaec50e20', N'admin@vidly.com', 0, N'AKzmVrUsR6j+t8tcbtjYTVSEPJXfvOrGLMywtTqWOMEMeXsXw/vHpuUxdvTVgBDElg==', N'7bd9263c-1787-4a6e-ae14-f459ca33de37', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bf016bd8-9744-40ee-b09c-db7a42cb4202', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'60f54128-87e6-4a8a-b59c-7d8aaec50e20', N'bf016bd8-9744-40ee-b09c-db7a42cb4202')


            ");
        }

        public override void Down()
        {
        }
    }
}
