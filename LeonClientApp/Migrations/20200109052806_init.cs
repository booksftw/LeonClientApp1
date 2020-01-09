using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeonClientApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    first_name = table.Column<string>(nullable: false),
                    last_name = table.Column<string>(nullable: true),
                    birthday = table.Column<DateTime>(nullable: false),
                    spending = table.Column<int>(nullable: false),
                    rank = table.Column<int>(nullable: false),
                    notes = table.Column<string>(nullable: true),
                    date_created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
