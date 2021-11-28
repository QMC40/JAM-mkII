using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAM_mkII.Migrations
{
    public partial class NomalTesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33ea3f31-a94e-4f4a-828f-f85d3485d481");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b296f53e-69f3-447b-90d0-220fe1d64fb4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b99ece79-3190-46e2-ac63-d3628a01db65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d93a1628-ae9c-4f1d-b223-3d87ee3a66f5");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FName", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7453627c-f692-49d8-95de-5ebdee4b495d", 0, "Countryside", "0848fd18-149a-455e-b2d0-c4468b49b4bc", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hotstuff@yahoops.com", false, "Trogdor", "Burninator", false, null, "HOTSTUFF@YAHOOPS.COM", null, null, "555-1212", false, 1, "000-00-0001", "c22cf7c0-672c-4d5a-8697-29a562af4ec0", false, "hotstuff@yahoops.com" },
                    { "09013053-1e6e-43cf-b485-0ff33041c185", 0, "southside", "d7252a5c-7725-444e-9264-5f10debe7a7c", new DateTime(1934, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duke@yahoops.com", false, "John", "Wayne", false, null, "DUKE@YAHOOPS.COM", null, null, "555-4242", false, 3, "123-45-6789", "8b40d06e-500a-467d-827b-6ef19a217a9f", false, "Duke@yahoops.com" },
                    { "d223823e-9fd7-474d-845e-02a967cab3c3", 0, "Portland", "31ec2cce-7b76-4421-894b-e2ec8bbe4d48", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OMGawd@yahoops.com", false, "Tammy", "Baker", false, null, "OMGAWD@YAHOOPS.COM", null, null, "555-3578", false, 2, "987-65-4321", "23c3c37d-dc52-49f1-820d-c80bb003e0f4", false, "OMGawd@yahoops.com" },
                    { "fbca6037-32f9-4a3f-9b0c-1d0c25624851", 0, "Annaville", "193941d0-ee39-4b51-a9bb-665a1f8ae08f", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "wyrm@yahoops.com", false, "Larry", "Linville", false, null, "WYRM@YAHOOPS.COM", null, null, "555-8946", false, 2, "556-28-1867", "57c06a97-3094-44d4-893a-02631e913a6d", false, "wyrm@yahoops.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09013053-1e6e-43cf-b485-0ff33041c185");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7453627c-f692-49d8-95de-5ebdee4b495d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d223823e-9fd7-474d-845e-02a967cab3c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbca6037-32f9-4a3f-9b0c-1d0c25624851");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FName", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b296f53e-69f3-447b-90d0-220fe1d64fb4", 0, "Countryside", "10465306-a4d9-4c77-8256-7621dd34ef2b", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hotstuff@yahoops.com", false, "Trogdor", "Burninator", false, null, null, null, null, "555-1212", false, 1, "000-00-0001", "c38d1bc9-4e72-4bb1-8408-6b77d9b898e4", false, "hotstuff@yahoops.com" },
                    { "33ea3f31-a94e-4f4a-828f-f85d3485d481", 0, "southside", "f3bb6c52-4c3c-46a9-94b1-00e97b748382", new DateTime(1934, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duke@yahoops.com", false, "John", "Wayne", false, null, null, null, null, "555-4242", false, 3, "123-45-6789", "8b33b5f1-850c-4c6c-8c53-f41b9e3a4808", false, "Duke@yahoops.com" },
                    { "d93a1628-ae9c-4f1d-b223-3d87ee3a66f5", 0, "Portland", "33bdfc6e-7131-436f-8667-60ac80cb1945", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OMGawd@yahoops.com", false, "Tammy", "Baker", false, null, null, null, null, "555-3578", false, 2, "987-65-4321", "474d8cdb-8fd5-4e17-927b-8a5aed52afaa", false, "OMGawd@yahoops.com" },
                    { "b99ece79-3190-46e2-ac63-d3628a01db65", 0, "Annaville", "284e9976-0530-4b5e-9b4c-d21cf9d10e58", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "wyrm@yahoops.com", false, "Larry", "Linville", false, null, null, null, null, "555-8946", false, 2, "556-28-1867", "1c5008e4-eb2e-4100-99b8-2e3515f4b17f", false, "wyrm@yahoops.com" }
                });
        }
    }
}
