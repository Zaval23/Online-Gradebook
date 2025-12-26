using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGradebook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixDiaryEntryRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_diary_entries_users_StudentId",
                table: "diary_entries");

            migrationBuilder.DropForeignKey(
                name: "FK_diary_entries_users_TeacherId",
                table: "diary_entries");

            migrationBuilder.AddForeignKey(
                name: "FK_diary_entries_students_StudentId",
                table: "diary_entries",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_diary_entries_teachers_TeacherId",
                table: "diary_entries",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_diary_entries_students_StudentId",
                table: "diary_entries");

            migrationBuilder.DropForeignKey(
                name: "FK_diary_entries_teachers_TeacherId",
                table: "diary_entries");

            migrationBuilder.AddForeignKey(
                name: "FK_diary_entries_users_StudentId",
                table: "diary_entries",
                column: "StudentId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_diary_entries_users_TeacherId",
                table: "diary_entries",
                column: "TeacherId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
