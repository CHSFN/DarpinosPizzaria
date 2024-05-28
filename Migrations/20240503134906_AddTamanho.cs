using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DarpinosPizzaria.Migrations
{
    /// <inheritdoc />
    public partial class AddTamanho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tamanho",
                table: "Pizzas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tamanho",
                table: "Pizzas");
        }
    }
}
