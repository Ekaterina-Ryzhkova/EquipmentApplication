using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EquipmentApplication.Migrations
{
    /// <inheritdoc />
    public partial class createinitttt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_ResponsePerson_ResponsePersonPersonId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_TypeEquipment_TypeEquipmentTypeId",
                table: "Equipment");

            migrationBuilder.AlterColumn<int>(
                name: "TypeEquipmentTypeId",
                table: "Equipment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ResponsePersonPersonId",
                table: "Equipment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_ResponsePerson_ResponsePersonPersonId",
                table: "Equipment",
                column: "ResponsePersonPersonId",
                principalTable: "ResponsePerson",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_TypeEquipment_TypeEquipmentTypeId",
                table: "Equipment",
                column: "TypeEquipmentTypeId",
                principalTable: "TypeEquipment",
                principalColumn: "TypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_ResponsePerson_ResponsePersonPersonId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_TypeEquipment_TypeEquipmentTypeId",
                table: "Equipment");

            migrationBuilder.AlterColumn<int>(
                name: "TypeEquipmentTypeId",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ResponsePersonPersonId",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_ResponsePerson_ResponsePersonPersonId",
                table: "Equipment",
                column: "ResponsePersonPersonId",
                principalTable: "ResponsePerson",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_TypeEquipment_TypeEquipmentTypeId",
                table: "Equipment",
                column: "TypeEquipmentTypeId",
                principalTable: "TypeEquipment",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
