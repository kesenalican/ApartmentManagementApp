using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApartmentManagement.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aparments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Block = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Floor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApartmentNo = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aparments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manager_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdentityNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CarPlate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    InvoiceElectricity = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    InvoiceWater = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    InvoiceGas = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    InvoiceInternet = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Dues = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Payment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Aparments",
                columns: new[] { "Id", "ApartmentNo", "Block", "CreatedByName", "CreatedDate", "Floor", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Status", "Type" },
                values: new object[,]
                {
                    { 1, 1, "A", "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 586, DateTimeKind.Local).AddTicks(6625), "1", true, false, "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 586, DateTimeKind.Local).AddTicks(7165), "Dolu", "1+0" },
                    { 2, 2, "A", "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 586, DateTimeKind.Local).AddTicks(7441), "1", true, false, "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 586, DateTimeKind.Local).AddTicks(7442), "Boş", "1+1" },
                    { 3, 3, "A", "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 586, DateTimeKind.Local).AddTicks(7446), "2", true, false, "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 586, DateTimeKind.Local).AddTicks(7448), "Boş", "2+1" },
                    { 4, 4, "A", "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 586, DateTimeKind.Local).AddTicks(7451), "2", true, false, "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 586, DateTimeKind.Local).AddTicks(7452), "Boş", "3+1" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 591, DateTimeKind.Local).AddTicks(3484), "Admin Tüm haklara sahiptir.", true, false, "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 591, DateTimeKind.Local).AddTicks(3494), "Admin" },
                    { 2, "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 591, DateTimeKind.Local).AddTicks(3502), "Kiracı", true, false, "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 591, DateTimeKind.Local).AddTicks(3503), "Kiracı" }
                });

            migrationBuilder.InsertData(
                table: "Manager",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "PasswordHash", "RoleId" },
                values: new object[] { 1, "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 589, DateTimeKind.Local).AddTicks(5700), "ali@ali.com", "Alican", true, false, "Kesen", "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 589, DateTimeKind.Local).AddTicks(5711), new byte[] { 102, 49, 98, 51, 99, 49, 98, 52, 99, 48, 51, 51, 53, 101, 54, 57, 48, 54, 101, 101, 48, 100, 99, 102, 57, 54, 100, 48, 98, 54, 49, 55 }, 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CarPlate", "CreatedByName", "CreatedDate", "Dues", "Email", "FirstName", "IdentityNo", "InvoiceElectricity", "InvoiceGas", "InvoiceInternet", "InvoiceWater", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "PasswordHash", "Payment", "PhoneNumber", "RoleId" },
                values: new object[] { 1, "34 LOGO 34", "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 607, DateTimeKind.Local).AddTicks(319), "100", "adsoyad@adsoyad.com", "Ad", "12345678901", 200, 300, 100, 100, true, false, "Soyad", "InitialCreate", new DateTime(2022, 4, 16, 4, 29, 1, 607, DateTimeKind.Local).AddTicks(331), new byte[] { 100, 50, 48, 53, 51, 97, 57, 97, 50, 55, 55, 51, 53, 55, 102, 97, 51, 48, 101, 99, 52, 48, 100, 101, 101, 101, 51, 98, 56, 101, 52, 100 }, null, "05551113322", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Manager_RoleId",
                table: "Manager",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aparments");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
