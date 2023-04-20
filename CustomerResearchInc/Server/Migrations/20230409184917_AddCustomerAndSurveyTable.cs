using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerResearchInc.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerAndSurveyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LaborType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Advisor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustNo = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Technician = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VINno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelePhone = table.Column<long>(type: "bigint", nullable: false),
                    Vehicle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OvarallCSI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CallCenterAgent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CusId = table.Column<int>(type: "int", nullable: false),
                    Q1 = table.Column<bool>(type: "bit", nullable: false),
                    Q2 = table.Column<bool>(type: "bit", nullable: false),
                    Q3 = table.Column<bool>(type: "bit", nullable: false),
                    Q4 = table.Column<bool>(type: "bit", nullable: false),
                    Q5 = table.Column<bool>(type: "bit", nullable: false),
                    Q6 = table.Column<bool>(type: "bit", nullable: false),
                    Q7 = table.Column<bool>(type: "bit", nullable: false),
                    Q8 = table.Column<bool>(type: "bit", nullable: false),
                    Q9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Surveys");
        }
    }
}
