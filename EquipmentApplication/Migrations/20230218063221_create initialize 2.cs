using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EquipmentApplication.Migrations
{
    /// <inheritdoc />
    public partial class createinitialize2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Equipment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
