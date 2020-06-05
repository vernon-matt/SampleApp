using Microsoft.EntityFrameworkCore.Migrations;

namespace VerticalAITCodeSample.Migrations
{
    public partial class SubTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WidgetSubTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubType = table.Column<string>(nullable: true),
                    WidgetTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WidgetSubTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "WidgetSubTypes",
                columns: new[] { "Id", "SubType", "WidgetTypeId" },
                values: new object[,]
                {
                    { 1, "Apple", 1 },
                    { 2, "Aardvark", 1 },
                    { 3, "Astronaut", 1 },
                    { 4, "Bear", 2 },
                    { 5, "Bobcat", 2 },
                    { 6, "Beaver", 2 },
                    { 7, "First", 3 },
                    { 8, "One", 3 },
                    { 9, "Primary", 3 },
                    { 10, "Uno", 3 },
                    { 11, "Second", 4 },
                    { 12, "Two", 4 },
                    { 13, "Secondary", 4 },
                    { 14, "Dos", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WidgetSubTypes");
        }
    }
}
