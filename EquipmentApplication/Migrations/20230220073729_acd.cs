using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EquipmentApplication.Migrations
{
    /// <inheritdoc />
    public partial class acd : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_Equipment_ResponsePersonPersonId",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_TypeEquipmentTypeId",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "ResponsePersonPersonId",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "TypeEquipmentTypeId",
                table: "Equipment");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "TypeEquipment",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "ResponsePerson",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "TypeName",
                table: "TypeEquipment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "ResponsePerson",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "ResponsePerson",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_PersonId",
                table: "Equipment",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_TypeId",
                table: "Equipment",
                column: "TypeId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_ResponsePerson_PersonId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_TypeEquipment_TypeId",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_PersonId",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_TypeId",
                table: "Equipment");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TypeEquipment",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ResponsePerson",
                newName: "PersonId");

            migrationBuilder.AlterColumn<string>(
                name: "TypeName",
                table: "TypeEquipment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "ResponsePerson",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "ResponsePerson",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.AddColumn<int>(
                name: "ResponsePersonPersonId",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeEquipmentTypeId",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ResponsePersonPersonId",
                table: "Equipment",
                column: "ResponsePersonPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_TypeEquipmentTypeId",
                table: "Equipment",
                column: "TypeEquipmentTypeId");

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
