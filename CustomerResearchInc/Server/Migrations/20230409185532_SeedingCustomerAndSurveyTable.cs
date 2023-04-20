using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CustomerResearchInc.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedingCustomerAndSurveyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Advisor", "CallCenterAgent", "CustNo", "Date", "FirstName", "LaborType", "LastName", "OvarallCSI", "Technician", "TelePhone", "VINno", "Vehicle" },
                values: new object[,]
                {
                    { 1, "Bobby Eskey", "", 1, new DateTime(2023, 4, 10, 0, 25, 31, 994, DateTimeKind.Local).AddTicks(2415), "DONNA", "Warranty", "BRAZALOVICH", 100.0m, "", 8604500709L, "5XYPGDA32GG169581", "2016 KIA SORENTO" },
                    { 2, "Brian Roush", "", 2, new DateTime(2023, 4, 10, 0, 25, 31, 994, DateTimeKind.Local).AddTicks(2436), "DENISE", "Warranty", "ROMAN", 66.7m, "", 8602167672L, "KNDP6CAC3L7712568", "2020 KIA SPORTAGE" },
                    { 3, "Fernamdo Cruz", "", 3, new DateTime(2023, 4, 10, 0, 25, 31, 994, DateTimeKind.Local).AddTicks(2441), "SELIN", "Warranty", "SCHILBERG", 40.0m, "", 8609900867L, "5XYP3DGC3PG330569", "2023 KIA TELLURID" },
                    { 4, "Fernamdo Cruz", "", 4, new DateTime(2023, 4, 10, 0, 25, 31, 994, DateTimeKind.Local).AddTicks(2445), "SARAH", "Warranty", "LATHROP", 83.3m, "", 8603016339L, "KNDRHDLG9P5170080", "2023 KIA SORENTO" },
                    { 5, "Brian Roush", "", 5, new DateTime(2023, 4, 10, 0, 25, 31, 994, DateTimeKind.Local).AddTicks(2449), "MARGARET", "Warranty", "JACOBSON", 83.3m, "", 8602679936L, "KNAGM4A71B5096410", "2011 KIA OPTIMA H" },
                    { 6, "Joe Berube", "", 6, new DateTime(2023, 4, 10, 0, 25, 31, 994, DateTimeKind.Local).AddTicks(2452), "JOSEPH", "Warranty", "SCHULTZ", 83.3m, "", 8608107098L, "KNDRG4LG5N5084281", "2022 KIA SORENTO" }
                });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "Id", "Comments", "CusId", "Q1", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7", "Q8", "Q9" },
                values: new object[,]
                {
                    { 1, "Donna said she has been buying vehicles from this business for years. Every now and then there is something with the service and it gets tweaked, and it all works out. (Customer chose not to answer all the questions.)", 1, true, false, false, false, false, true, false, false, "" },
                    { 2, "Denise stated that carfax keeps sending emails for an oil change and she wants it stopped. It took two hours to get her oil changed and the gentleman stated that they got backed up and should not have to wait so long for an oil change. The gentleman did not charge her and even gave her a free car wash. (Customer chose not to answer all the questions.)", 2, true, false, true, false, true, true, false, false, "" },
                    { 3, "Selin said it was not ready, she had to contact them, it was a half hour before closing and they hadn't even worked on her vehicle. They could be more transparent and communicate better. This was her first time there, so she doesn't know if she would recommend them. (Customer chose not to answer all the questions.)", 3, false, true, false, false, true, false, false, false, "" },
                    { 4, "Sarah stated that she was dissatisfied with the East Harbor visit work.", 4, true, true, true, false, true, true, false, false, "" },
                    { 5, "Margaret said everything was done that needed to be done, she also purchased her vehicle from them and she is happy with them.", 5, true, false, true, true, true, true, false, true, "" },
                    { 6, "", 6, true, true, true, false, true, true, false, true, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
