using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoAsyncApi.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Demo_User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(maxLength: 200, nullable: false),
                    FullName = table.Column<string>(maxLength: 200, nullable: false),
                    Desc = table.Column<string>(maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demo_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Demo_User",
                columns: new[] { "Id", "Desc", "FullName", "Username" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "User Desc ...", "User01", "User01" },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "User Desc ...", "User18", "User18" },
                    { new Guid("00000000-0000-0000-0000-000000000017"), "User Desc ...", "User17", "User17" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "User Desc ...", "User16", "User16" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "User Desc ...", "User15", "User15" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "User Desc ...", "User14", "User14" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "User Desc ...", "User13", "User13" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "User Desc ...", "User12", "User12" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "User Desc ...", "User11", "User11" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "User Desc ...", "User10", "User10" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "User Desc ...", "User09", "User09" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "User Desc ...", "User08", "User08" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "User Desc ...", "User07", "User07" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "User Desc ...", "User06", "User06" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "User Desc ...", "User05", "User05" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "User Desc ...", "User04", "User04" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "User Desc ...", "User03", "User03" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "User Desc ...", "User02", "User02" },
                    { new Guid("00000000-0000-0000-0000-000000000019"), "User Desc ...", "User19", "User19" },
                    { new Guid("00000000-0000-0000-0000-000000000020"), "User Desc ...", "User20", "User20" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Demo_User");
        }
    }
}
