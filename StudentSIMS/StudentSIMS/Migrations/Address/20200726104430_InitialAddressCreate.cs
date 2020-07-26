using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentSIMS.Migrations.Address
{
    public partial class InitialAddressCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    studentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetNumber = table.Column<int>(maxLength: 100, nullable: false),
                    Street = table.Column<string>(nullable: false),
                    Suburb = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Postcode = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    timeCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.studentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
