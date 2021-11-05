using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { "071ad743-731d-40f5-82b0-f549ec46a2f2", "Tom", "Day", "Physics" },
                    { "c2fb3407-1e41-4bbf-94d4-3183e7f90194", "Ann", "Fox", "Geology" },
                    { "32d5a4fa-7fa2-49c1-9095-555cc2ba3ba6", "Art", "Ash", "Nursing" },
                    { "f2b7d664-6437-4f72-8817-8daa74f047e8", "Mia", "Hay", "Science" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
