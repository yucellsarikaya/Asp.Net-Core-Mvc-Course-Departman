using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjeCore.Migrations
{
    public partial class newDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birim",
                columns: table => new
                {
                    BirimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirimAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birim", x => x.BirimID);
                });

            migrationBuilder.CreateTable(
                name: "Personel",
                columns: table => new
                {
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirimID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel", x => x.PersonelID);
                    table.ForeignKey(
                        name: "FK_Personel_Birim_BirimID",
                        column: x => x.BirimID,
                        principalTable: "Birim",
                        principalColumn: "BirimID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personel_BirimID",
                table: "Personel",
                column: "BirimID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personel");

            migrationBuilder.DropTable(
                name: "Birim");
        }
    }
}
