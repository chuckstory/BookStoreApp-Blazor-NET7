using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultUserandRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a5f", null, "User", "USER" },
                    { "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a6f", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a7f", 0, "4ca4919f-8bae-4d1e-9b1a-9035bf2c378a", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEF3jfXA5R1T5ebQX+kcXjOU8JrrhyMaMuzG2xSc2JXv6rUTrhOMtU2Bj9Hmc7oXopg==", null, false, "7c416436-3c60-4a83-9ea6-828f1ba27fb9", false, "admin@bookstore.com" },
                    { "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a8f", 0, "9fc52600-084c-43a0-8840-f18301c13e64", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEJa/Pcdo5a/9TLVLTyJmtH6nJ2A5YNB6X46+gFuLzbsLI1+xosyessZPI+mp44exUQ==", null, false, "8bd65845-8cec-434f-a2b4-5a516781bde0", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a6f", "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a7f" },
                    { "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a5f", "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a8f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a6f", "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a7f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a5f", "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a8f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3d9d8b7-9d7c-4a3c-9b3b-8d4a3c2e1a8f");
        }
    }
}
