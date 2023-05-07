using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bugtracker.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProjectAccess1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAccess_AspNetRoles_AccessTypeId",
                table: "ProjectAccess");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAccess_AspNetUsers_UserId1",
                table: "ProjectAccess");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "ProjectAccess");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProjectAccess");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "ProjectAccess",
                newName: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AccessTypeId",
                table: "ProjectAccess",
                newName: "AspNetRoles");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectAccess_UserId1",
                table: "ProjectAccess",
                newName: "IX_ProjectAccess_AspNetUsers");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectAccess_AccessTypeId",
                table: "ProjectAccess",
                newName: "IX_ProjectAccess_AspNetRoles");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAccess_AspNetRoles_AspNetRoles",
                table: "ProjectAccess",
                column: "AspNetRoles",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAccess_AspNetUsers_AspNetUsers",
                table: "ProjectAccess",
                column: "AspNetUsers",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAccess_AspNetRoles_AspNetRoles",
                table: "ProjectAccess");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAccess_AspNetUsers_AspNetUsers",
                table: "ProjectAccess");

            migrationBuilder.RenameColumn(
                name: "AspNetUsers",
                table: "ProjectAccess",
                newName: "UserId1");

            migrationBuilder.RenameColumn(
                name: "AspNetRoles",
                table: "ProjectAccess",
                newName: "AccessTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectAccess_AspNetUsers",
                table: "ProjectAccess",
                newName: "IX_ProjectAccess_UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectAccess_AspNetRoles",
                table: "ProjectAccess",
                newName: "IX_ProjectAccess_AccessTypeId");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "ProjectAccess",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ProjectAccess",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAccess_AspNetRoles_AccessTypeId",
                table: "ProjectAccess",
                column: "AccessTypeId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAccess_AspNetUsers_UserId1",
                table: "ProjectAccess",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
