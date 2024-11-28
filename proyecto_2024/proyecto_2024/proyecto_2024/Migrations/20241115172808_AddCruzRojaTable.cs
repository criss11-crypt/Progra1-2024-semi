using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyecto_2024.Migrations
{
    /// <inheritdoc />
    public partial class AddCruzRojaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CruzRoja",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Direccion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Dui = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DescripcionCaso = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CruzRoja__3213E83F5A2F1B8D", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Direccion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Dui = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DescripcionCaso = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Hospital__3213E83F80B6F1D3", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "UQ__CruzRoja__C0317D91223A4E5B",
                table: "CruzRoja",
                column: "Dui",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Hospital__C0317D91D4A3785F",
                table: "Hospital",
                column: "Dui",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CruzRoja");

            migrationBuilder.DropTable(
                name: "Hospital");
        }
    }
}
