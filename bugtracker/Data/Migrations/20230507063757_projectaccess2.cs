using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bugtracker.Data.Migrations
{
    /// <inheritdoc />
    public partial class projectaccess2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "UserIdFk");

            migrationBuilder.RenameColumn(
                name: "AspNetRoles",
                table: "ProjectAccess",
                newName: "AccessTypeFk");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectAccess_AspNetUsers",
                table: "ProjectAccess",
                newName: "IX_ProjectAccess_UserIdFk");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectAccess_AspNetRoles",
                table: "ProjectAccess",
                newName: "IX_ProjectAccess_AccessTypeFk");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAccess_AspNetRoles_AccessTypeFk",
                table: "ProjectAccess",
                column: "AccessTypeFk",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAccess_AspNetUsers_UserIdFk",
                table: "ProjectAccess",
                column: "UserIdFk",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAccess_AspNetRoles_AccessTypeFk",
                table: "ProjectAccess");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAccess_AspNetUsers_UserIdFk",
                table: "ProjectAccess");

            migrationBuilder.RenameColumn(
                name: "UserIdFk",
                table: "ProjectAccess",
                newName: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AccessTypeFk",
                table: "ProjectAccess",
                newName: "AspNetRoles");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectAccess_UserIdFk",
                table: "ProjectAccess",
                newName: "IX_ProjectAccess_AspNetUsers");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectAccess_AccessTypeFk",
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
    }
}
