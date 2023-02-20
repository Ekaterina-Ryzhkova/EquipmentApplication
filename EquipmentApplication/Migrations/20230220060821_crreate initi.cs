using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EquipmentApplication.Migrations
{
    /// <inheritdoc />
    public partial class crreateiniti : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "ResponsePerson",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Initials = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsePerson", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "TypeEquipment",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeEquipment", x => x.TypeId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_ResponsePerson_ResponsePersonPersonId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_TypeEquipment_TypeEquipmentTypeId",
                table: "Equipment");

            migrationBuilder.DropTable(
                name: "ResponsePerson");

            migrationBuilder.DropTable(
                name: "TypeEquipment");

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
        }
    }
}
