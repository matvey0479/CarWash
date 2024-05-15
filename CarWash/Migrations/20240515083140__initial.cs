using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarWash.Migrations
{
    public partial class _initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumper = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FreeTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreeTimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "takenTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_takenTimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    timeId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ServiceItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_ServiceItems_ServiceItemId",
                        column: x => x.ServiceItemId,
                        principalTable: "ServiceItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_takenTimes_timeId",
                        column: x => x.timeId,
                        principalTable: "takenTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5e8cf896-f975-4254-906c-afd297b9855b", "7e89a541-5bf9-4d7a-bf6a-187b2bbc8152", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6f0feb5e-47f8-41c0-9d57-5de5372c4ae2", 0, "dc983567-f9aa-490c-9398-529ce2814005", "my@mail.com", true, false, null, "MY@MAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEEpFspJ9iKw0gbW26xb7JlViPNxuVnifR3rW7w6ycd29sfCCkvWu4h4kKnyErBdGsw==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 2, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 3, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 4, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 5, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 6, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 7, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 8, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 9, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 10, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 11, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 12, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 13, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 14, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 15, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 16, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 17, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 18, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 19, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 20, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 21, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 22, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 23, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 24, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 25, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 26, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 27, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 28, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 29, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 30, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 31, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 32, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 33, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 34, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 35, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 36, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 37, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 38, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 39, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 40, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 41, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 42, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 43, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 44, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 45, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 46, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 47, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 48, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 49, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 50, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 51, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 52, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 53, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 54, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 55, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 56, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 57, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 58, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 59, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 60, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 61, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 62, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 63, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 64, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 65, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 66, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 67, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 68, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 69, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 70, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 71, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 72, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 73, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 74, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 75, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 76, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 77, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 78, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 79, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 80, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 81, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 82, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 83, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 84, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 85, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 86, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 87, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 88, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 89, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 90, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 91, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 92, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 93, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 94, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 95, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 96, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 97, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 98, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 99, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 100, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 101, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 102, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 103, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 104, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 105, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 106, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 107, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 108, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 109, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 110, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 111, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 112, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 113, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 114, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 115, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 116, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 117, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 118, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 119, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 120, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 121, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 122, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 123, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 124, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 125, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 126, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 127, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 128, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 129, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 130, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 131, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 132, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 133, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 134, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 135, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 136, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 137, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 138, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 139, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 140, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 141, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 142, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 143, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 144, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 145, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 146, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 147, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 148, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 149, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 150, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 151, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 152, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 153, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 154, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 155, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 156, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 157, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 158, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 159, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 160, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 161, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 162, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 163, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 164, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 165, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 166, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 167, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 168, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 169, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 170, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 171, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 172, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 173, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 174, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 175, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 176, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 177, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 178, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 179, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 180, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 181, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 182, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 183, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 184, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 185, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 186, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 187, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 188, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 189, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 190, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 191, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 192, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 193, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 194, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 195, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 196, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 197, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 198, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 199, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 200, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 201, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 202, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 203, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 204, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 205, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 206, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 207, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 208, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 209, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 210, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 211, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 212, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 213, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 214, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 215, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 216, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 217, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 218, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 219, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 220, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 221, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 222, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 223, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 224, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 225, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 226, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 227, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 228, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 229, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 230, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 231, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 232, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 233, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 234, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 235, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 236, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 237, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 238, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 239, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 240, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 241, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 242, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 243, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 244, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 245, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 246, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 247, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 248, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 249, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 250, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 251, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 252, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 253, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 254, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 255, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 256, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 257, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 258, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 259, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 260, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 261, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 262, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 263, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 264, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 265, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 266, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 267, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 268, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 269, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 270, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 271, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 272, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 273, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 274, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 275, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 276, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 277, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 278, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 279, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 280, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 281, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 282, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 283, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 284, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 285, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 286, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 287, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 288, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 289, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 290, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 291, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 292, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 293, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 294, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 295, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 296, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 297, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 298, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 299, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 300, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 301, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 302, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 303, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 304, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 305, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 306, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 307, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 308, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 309, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 310, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 311, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 312, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 313, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 314, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 315, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 316, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 317, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 318, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 319, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 320, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 321, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 322, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 323, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 324, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 325, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 326, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 327, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 328, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 329, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 330, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 331, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 332, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 333, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 334, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 335, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 336, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 337, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 338, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 339, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 340, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 341, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 342, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 343, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 344, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 345, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 346, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 347, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 348, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 349, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 350, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 351, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 352, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 353, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 354, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 355, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 356, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 357, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 358, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 359, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 360, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 361, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 362, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 363, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 364, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 365, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 366, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 367, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 368, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 369, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 370, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 371, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 372, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 373, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 374, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 375, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 376, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 377, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 378, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 379, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 380, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 381, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 382, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 383, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 384, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 385, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 386, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 387, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 388, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 389, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 390, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 391, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 392, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 393, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 394, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 395, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 396, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 397, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 398, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 399, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 400, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 401, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 402, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 403, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 404, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 405, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 406, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 407, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 408, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 409, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 410, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 411, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 412, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 413, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 414, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 415, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 416, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 417, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 418, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 419, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 420, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 421, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 422, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 423, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 424, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 425, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 426, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 427, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 428, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 429, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 430, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 431, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 432, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 433, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 434, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 435, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 436, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 437, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 438, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 439, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 440, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 441, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 442, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 443, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 444, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 445, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 446, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 447, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 448, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 449, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 450, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 451, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 452, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 453, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 454, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 455, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 456, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 457, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 458, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 459, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 460, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 461, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 462, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 463, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 464, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 465, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 466, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 467, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 468, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 469, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 470, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 471, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 472, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 473, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 474, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 475, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 476, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 477, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 478, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 479, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 480, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 481, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 482, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 483, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 484, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 485, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 486, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 487, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 488, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 489, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 490, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 491, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 492, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 493, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 494, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 495, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 496, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 497, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 498, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 499, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 500, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 501, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 502, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 503, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 504, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 505, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 506, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 507, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 508, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 509, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 510, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 511, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 512, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 513, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 514, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 515, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 516, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 517, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 518, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 519, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 520, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 521, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 522, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 523, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 524, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 525, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 526, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 527, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 528, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 529, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 530, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 531, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 532, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 533, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 534, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 535, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 536, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 537, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 538, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 539, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 540, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 541, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 542, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 543, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 544, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 545, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 546, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 547, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 548, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 549, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 550, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 551, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 552, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 553, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 554, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 555, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 556, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 557, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 558, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 559, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 560, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 561, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 562, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 563, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 564, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 565, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 566, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 567, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 568, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 569, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 570, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 571, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 572, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 573, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 574, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 575, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 576, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 577, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 578, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 579, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 580, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 581, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 582, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 583, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 584, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 585, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 586, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 587, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 588, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 589, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 590, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 591, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 592, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 593, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 594, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 595, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 596, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 597, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 598, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 599, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 600, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 601, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 602, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 603, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 604, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 605, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 606, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 607, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 608, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 609, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 610, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 611, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 612, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 613, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 614, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 615, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 616, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 617, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 618, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 619, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 620, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 621, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 622, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 623, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 624, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 625, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 626, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 627, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 628, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 629, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 630, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 631, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 632, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 633, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 634, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 635, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 636, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 637, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 638, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 639, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 640, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 641, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 642, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 643, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 644, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 645, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 646, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 647, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 648, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 649, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 650, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 651, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 652, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 653, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 654, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 655, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 656, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 657, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 658, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 659, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 660, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 661, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 662, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 663, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 664, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 665, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 666, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 667, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 668, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 669, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 670, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 671, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 672, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 673, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 674, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 675, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 676, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 677, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 678, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 679, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 680, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 681, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 682, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 683, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 684, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 685, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 686, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 687, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 688, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 689, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 690, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 691, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 692, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 693, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 694, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 695, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 696, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 697, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 698, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 699, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 700, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 701, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 702, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 703, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 704, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 705, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 706, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 707, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 708, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 709, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 710, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 711, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 712, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FreeTimes",
                columns: new[] { "Id", "Date", "Time" },
                values: new object[,]
                {
                    { 713, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 714, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 715, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 716, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 717, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 718, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 719, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 720, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) },
                    { 721, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0) },
                    { 722, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 30, 0, 0) },
                    { 723, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0) },
                    { 724, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 30, 0, 0) },
                    { 725, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0) },
                    { 726, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 30, 0, 0) },
                    { 727, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0) },
                    { 728, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 30, 0, 0) },
                    { 729, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0) },
                    { 730, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 30, 0, 0) },
                    { 731, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0) },
                    { 732, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 30, 0, 0) },
                    { 733, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0) },
                    { 734, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 30, 0, 0) },
                    { 735, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0) },
                    { 736, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 30, 0, 0) },
                    { 737, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { 738, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 30, 0, 0) },
                    { 739, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0) },
                    { 740, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 30, 0, 0) },
                    { 741, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 0, 0, 0) },
                    { 742, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 20, 30, 0, 0) },
                    { 743, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0) },
                    { 744, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "ServiceItems",
                columns: new[] { "Id", "Description", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Наружная мойка автомобиля при помощи моечной установки без использования химических средств и шампуней.", "300", "Техническая мойка" },
                    { 2, "Мойка кузова машины. Чистка салона, ковриков и сидений. Чистка багажника. Чистка шин и дисков и шин", "600", "Комплексная мойка" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5e8cf896-f975-4254-906c-afd297b9855b", "6f0feb5e-47f8-41c0-9d57-5de5372c4ae2" });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ClientId",
                table: "Appointments",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ServiceItemId",
                table: "Appointments",
                column: "ServiceItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_timeId",
                table: "Appointments",
                column: "timeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FreeTimes");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "ServiceItems");

            migrationBuilder.DropTable(
                name: "takenTimes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
