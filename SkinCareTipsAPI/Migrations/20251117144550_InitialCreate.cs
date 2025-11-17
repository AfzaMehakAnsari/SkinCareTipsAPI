using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkinCareTipsAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Table already exists in DB, so we skip creation to prevent error
            // migrationBuilder.CreateTable(
            //     name: "Tips",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("SqlServer:Identity", "1, 1"),
            //         TipTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         TipText = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //         Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Tips", x => x.Id);
            //     });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Skip dropping the table to prevent data loss
            // migrationBuilder.DropTable(
            //     name: "Tips");
        }
    }
}
