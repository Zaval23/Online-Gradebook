using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalonBeauty.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newConnectionMasterSignUps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_signs_up_users_UserId",
                table: "signs_up");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "UsersRoles");

            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "roles");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "roles");

            migrationBuilder.DropColumn(
                name: "ImageSize",
                table: "images");

            migrationBuilder.RenameColumn(
                name: "Parname",
                table: "users",
                newName: "Patronymic");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "signs_up",
                newName: "MasterId");

            migrationBuilder.RenameIndex(
                name: "IX_signs_up_UserId",
                table: "signs_up",
                newName: "IX_signs_up_MasterId");

            migrationBuilder.RenameColumn(
                name: "NameService",
                table: "services",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "images",
                newName: "FileName");

            migrationBuilder.RenameColumn(
                name: "Extension",
                table: "images",
                newName: "FileExtension");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "signs_up",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "roles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Content",
                table: "images",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.CreateIndex(
                name: "IX_signs_up_ClientId",
                table: "signs_up",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_signs_up_users_ClientId",
                table: "signs_up",
                column: "ClientId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_signs_up_users_MasterId",
                table: "signs_up",
                column: "MasterId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_signs_up_users_ClientId",
                table: "signs_up");

            migrationBuilder.DropForeignKey(
                name: "FK_signs_up_users_MasterId",
                table: "signs_up");

            migrationBuilder.DropIndex(
                name: "IX_signs_up_ClientId",
                table: "signs_up");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "signs_up");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "roles");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "images");

            migrationBuilder.RenameColumn(
                name: "Patronymic",
                table: "users",
                newName: "Parname");

            migrationBuilder.RenameColumn(
                name: "MasterId",
                table: "signs_up",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_signs_up_MasterId",
                table: "signs_up",
                newName: "IX_signs_up_UserId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "services",
                newName: "NameService");

            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "images",
                newName: "ImageName");

            migrationBuilder.RenameColumn(
                name: "FileExtension",
                table: "images",
                newName: "Extension");

            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "UsersRoles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "roles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "roles",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ImageSize",
                table: "images",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_signs_up_users_UserId",
                table: "signs_up",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
