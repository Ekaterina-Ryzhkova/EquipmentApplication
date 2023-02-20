using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EquipmentApplication.Migrations
{
    /// <inheritdoc />
    public partial class abcd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_ResponsePerson_PersonId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_TypeEquipment_TypeId",
                table: "Equipment");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_ResponsePerson_PersonId",
                table: "Equipment",
                column: "PersonId",
                principalTable: "ResponsePerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_TypeEquipment_TypeId",
                table: "Equipment",
                column: "TypeId",
                principalTable: "TypeEquipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_ResponsePerson_PersonId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_TypeEquipment_TypeId",
                table: "Equipment");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Equipment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Equipment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_ResponsePerson_PersonId",
                table: "Equipment",
                column: "PersonId",
                principalTable: "ResponsePerson",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_TypeEquipment_TypeId",
                table: "Equipment",
                column: "TypeId",
                principalTable: "TypeEquipment",
                principalColumn: "Id");
        }
    }
}
