using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAM_mkII.Migrations
{
    public partial class tests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31d888db-792e-4687-b2d9-f22702e641ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "501a4259-8742-4339-b518-7c9da8823f30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f38a9a1-5944-4159-87d3-ab46306edb6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dacdb058-8f8f-42dd-b3ae-0417e08f2768");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FName", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6f47e220-6f7e-44d7-85d1-57a399decee8", 0, "Countryside", "cf648af3-e53c-4108-8775-7a8deb48a18b", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hotstuff@yahoops.com", false, "Trogdor", "Burninator", false, null, "HOTSTUFF@YAHOOPS.COM", null, null, "555-1212", false, 1, "000-00-0001", "b816fa1e-ac2c-4215-b7fd-85b5433d1ec8", false, "hotstuff@yahoops.com" },
                    { "63d9c227-afe2-42c4-a668-5f658311037c", 0, "southside", "8a23041b-972c-414d-b5f9-5d50b7cac2e4", new DateTime(1934, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duke@yahoops.com", false, "John", "Wayne", false, null, "DUKE@YAHOOPS.COM", null, null, "555-4242", false, 3, "123-45-6789", "4d29a3f5-e43f-4f01-bfd0-8b9e5397355b", false, "Duke@yahoops.com" },
                    { "50f3f596-42e8-4616-86fa-f5804d7408ec", 0, "Portland", "3cbc8cb3-f8e1-4b02-983a-a3b43b584e23", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OMGawd@yahoops.com", false, "Tammy", "Baker", false, null, "OMGAWD@YAHOOPS.COM", null, null, "555-3578", false, 2, "987-65-4321", "a08b75df-5448-48dd-977b-242a444c8a3c", false, "OMGawd@yahoops.com" },
                    { "7a9dd996-9c27-4fe6-9c74-84d2d967dd92", 0, "Annaville", "16666ebf-5f1a-4113-93b9-83226ceee9f3", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "wyrm@yahoops.com", false, "Larry", "Linville", false, null, "WYRM@YAHOOPS.COM", null, null, "555-8946", false, 2, "556-28-1867", "70d54e96-de42-4105-a94a-e835ba6257ad", false, "wyrm@yahoops.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50f3f596-42e8-4616-86fa-f5804d7408ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63d9c227-afe2-42c4-a668-5f658311037c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f47e220-6f7e-44d7-85d1-57a399decee8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a9dd996-9c27-4fe6-9c74-84d2d967dd92");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FName", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8f38a9a1-5944-4159-87d3-ab46306edb6f", 0, "Countryside", "ae2e7064-348d-4185-a87d-5ec6ed4c7ba1", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hotstuff@yahoops.com", false, "Trogdor", "Burninator", false, null, "HOTSTUFF@YAHOOPS.COM", null, null, "555-1212", false, 1, "000-00-0001", "aa1b603a-3456-4f50-9b22-50543873e31f", false, "hotstuff@yahoops.com" },
                    { "31d888db-792e-4687-b2d9-f22702e641ae", 0, "southside", "d0378bda-58f3-47a6-bc09-034f40e10ff6", new DateTime(1934, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duke@yahoops.com", false, "John", "Wayne", false, null, "DUKE@YAHOOPS.COM", null, null, "555-4242", false, 3, "123-45-6789", "f3bf2908-abb4-48f2-9085-8101f7127a17", false, "Duke@yahoops.com" },
                    { "501a4259-8742-4339-b518-7c9da8823f30", 0, "Portland", "49392bcf-3193-44ba-a908-eeca118bfd70", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OMGawd@yahoops.com", false, "Tammy", "Baker", false, null, "OMGAWD@YAHOOPS.COM", null, null, "555-3578", false, 2, "987-65-4321", "5e79efe4-65be-4f73-896a-bd4a58f7b87b", false, "OMGawd@yahoops.com" },
                    { "dacdb058-8f8f-42dd-b3ae-0417e08f2768", 0, "Annaville", "5b1131d0-4e2c-481f-843a-efd3e395d180", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "wyrm@yahoops.com", false, "Larry", "Linville", false, null, "WYRM@YAHOOPS.COM", null, null, "555-8946", false, 2, "556-28-1867", "6fb96f6c-7fc8-46a9-9978-04b39a0e4c79", false, "wyrm@yahoops.com" }
                });
        }
    }
}
