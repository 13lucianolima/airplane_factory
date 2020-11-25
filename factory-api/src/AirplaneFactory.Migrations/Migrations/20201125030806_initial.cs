using Microsoft.EntityFrameworkCore.Migrations;

namespace AirplaneFactory.Migrations.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "airplanes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirplaneType = table.Column<int>(nullable: false),
                    MotorQuantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_airplanes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "motors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotorType = table.Column<int>(nullable: false),
                    AirplaneId = table.Column<int>(nullable: false),
                    Running = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_motors_airplanes_AirplaneId",
                        column: x => x.AirplaneId,
                        principalTable: "airplanes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_motors_AirplaneId",
                table: "motors",
                column: "AirplaneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "motors");

            migrationBuilder.DropTable(
                name: "airplanes");
        }
    }
}
