using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalonBeauty.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class LastMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalonsServices_services_SalonId",
                table: "SalonsServices");

            migrationBuilder.CreateIndex(
                name: "IX_SalonsServices_ServiceId",
                table: "SalonsServices",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalonsServices_services_ServiceId",
                table: "SalonsServices",
                column: "ServiceId",
                principalTable: "services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalonsServices_services_ServiceId",
                table: "SalonsServices");

            migrationBuilder.DropIndex(
                name: "IX_SalonsServices_ServiceId",
                table: "SalonsServices");

            migrationBuilder.AddForeignKey(
                name: "FK_SalonsServices_services_SalonId",
                table: "SalonsServices",
                column: "SalonId",
                principalTable: "services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
