using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Step.Hotel.Atr.RealPortal.Migrations
{
    /// <inheritdoc />
    public partial class addClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientImageHoverUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
