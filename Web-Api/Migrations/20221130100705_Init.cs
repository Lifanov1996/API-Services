using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Archivs",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LsClientOut = table.Column<string>(type: "TEXT", nullable: false),
                    LsClientIn = table.Column<string>(type: "TEXT", nullable: false),
                    TypeCurrency = table.Column<string>(type: "TEXT", nullable: false),
                    TypeTransfer = table.Column<string>(type: "TEXT", nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archivs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ls = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ls = table.Column<string>(type: "TEXT", nullable: false),
                    BTC = table.Column<decimal>(type: "TEXT", nullable: false),
                    ETH = table.Column<decimal>(type: "TEXT", nullable: false),
                    DOGE = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Archivs",
                columns: new[] { "id", "DateTime", "LsClientIn", "LsClientOut", "TypeCurrency", "TypeTransfer" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2222 - 2222", "1111-1111", "BTC", "online" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6666-6666", "1111-1111", "ETH", "online" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5555-5555", "3333-3333", "DOGE", "online" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2222-2222", "6666-6666", "ETH", "online" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4444-4444", "2222-2222", "BTC", "online" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6666-6666", "3333-3333", "DOGE", "online" },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2222-2222", "5555-5555", "BTC", "online" },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4444-4444", "6666-6666", "ETH", "online" },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6666-6666", "2222-2222", "BTC", "online" },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2222-2222", "6666-6666", "ETH", "online" },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4444-4444", "2222-2222", "BTC", "online" },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6666-6666", "3333-3333", "DOGE", "online" },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2222-2222", "5555-5555", "BTC", "online" },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4444-4444", "6666-6666", "ETH", "online" },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6666-6666", "2222-2222", "BTC", "online" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "id", "Ls", "Name" },
                values: new object[,]
                {
                    { 1, "1111-1111", "Nix" },
                    { 2, "3333-3333", "Son" },
                    { 3, "4444-4444", "Max" },
                    { 4, "5555-5555", "Bob" },
                    { 5, "6666-6666", "Ana" },
                    { 6, "2222-2222", "Tim" }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "id", "BTC", "DOGE", "ETH", "Ls" },
                values: new object[,]
                {
                    { 1, 2m, 5m, 0.03m, "1111-1111" },
                    { 2, 5m, 2m, 0.3m, "2222-2222" },
                    { 3, 0.12m, 0.12m, 2m, "4444-4444" },
                    { 4, 12m, 22m, 1m, "3333-3333" },
                    { 5, 0.33m, 5m, 5m, "5555-5555" },
                    { 6, 0.002m, 12m, 12m, "6666-6666" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Archivs");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Wallets");
        }
    }
}
