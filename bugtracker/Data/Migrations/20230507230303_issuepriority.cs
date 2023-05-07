using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bugtracker.Data.Migrations
{
    /// <inheritdoc />
    public partial class issuepriority : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Issue_Priority",
                table: "Issues",
                newName: "Priority");

            migrationBuilder.CreateTable(
                name: "IssuePriority",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssuePriority", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Issues_Priority",
                table: "Issues",
                column: "Priority");

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_IssuePriority_Priority",
                table: "Issues",
                column: "Priority",
                principalTable: "IssuePriority",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issues_IssuePriority_Priority",
                table: "Issues");

            migrationBuilder.DropTable(
                name: "IssuePriority");

            migrationBuilder.DropIndex(
                name: "IX_Issues_Priority",
                table: "Issues");

            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "Issues",
                newName: "Issue_Priority");
        }
    }
}
