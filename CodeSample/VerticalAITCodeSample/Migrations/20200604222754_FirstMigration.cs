using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VerticalAITCodeSample.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WidgetTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WidgetTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Widgets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    WidgetName = table.Column<string>(nullable: true),
                    WidgetTypeId = table.Column<int>(nullable: false),
                    WidgetSubTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widgets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Widgets_WidgetTypes_WidgetTypeId",
                        column: x => x.WidgetTypeId,
                        principalTable: "WidgetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "WidgetTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "A" },
                    { 2, "B" },
                    { 3, "1" },
                    { 4, "2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Widgets_WidgetTypeId",
                table: "Widgets",
                column: "WidgetTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Widgets");

            migrationBuilder.DropTable(
                name: "WidgetTypes");
        }
    }
}
