using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookKeeping.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YearlyIncomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TotalIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearlyIncomes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CostDynamics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostValueJson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearlyIncomeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostDynamics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostDynamics_YearlyIncomes_YearlyIncomeId",
                        column: x => x.YearlyIncomeId,
                        principalTable: "YearlyIncomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncomeDynamics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncomeValueJson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearlyIncomeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeDynamics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncomeDynamics_YearlyIncomes_YearlyIncomeId",
                        column: x => x.YearlyIncomeId,
                        principalTable: "YearlyIncomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyCosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YearlyIncomeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonthlyCosts_YearlyIncomes_YearlyIncomeId",
                        column: x => x.YearlyIncomeId,
                        principalTable: "YearlyIncomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyIncomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Income = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YearlyIncomeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyIncomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonthlyIncomes_YearlyIncomes_YearlyIncomeId",
                        column: x => x.YearlyIncomeId,
                        principalTable: "YearlyIncomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CostDynamics_YearlyIncomeId",
                table: "CostDynamics",
                column: "YearlyIncomeId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeDynamics_YearlyIncomeId",
                table: "IncomeDynamics",
                column: "YearlyIncomeId");

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyCosts_YearlyIncomeId",
                table: "MonthlyCosts",
                column: "YearlyIncomeId");

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyIncomes_YearlyIncomeId",
                table: "MonthlyIncomes",
                column: "YearlyIncomeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostDynamics");

            migrationBuilder.DropTable(
                name: "IncomeDynamics");

            migrationBuilder.DropTable(
                name: "MonthlyCosts");

            migrationBuilder.DropTable(
                name: "MonthlyIncomes");

            migrationBuilder.DropTable(
                name: "YearlyIncomes");
        }
    }
}
