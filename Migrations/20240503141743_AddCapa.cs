using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DarpinosPizzaria.Migrations
{
    /// <inheritdoc />
    public partial class AddCapa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Capa",
                table: "Pizzas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capa",
                table: "Pizzas");
        }
    }
}
