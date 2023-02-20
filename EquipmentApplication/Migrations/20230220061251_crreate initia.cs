using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EquipmentApplication.Migrations
{
    /// <inheritdoc />
    public partial class crreateinitia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Initials",
                table: "ResponsePerson",
                newName: "Position");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "ResponsePerson",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "ResponsePerson");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "ResponsePerson",
                newName: "Initials");
        }
    }
}
