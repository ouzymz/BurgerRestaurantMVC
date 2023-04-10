using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerMVC.DataLayer.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Desserts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desserts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sauce",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sauce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    DessertId = table.Column<int>(type: "int", nullable: true),
                    DrinkId = table.Column<int>(type: "int", nullable: true),
                    ExtraId = table.Column<int>(type: "int", nullable: true),
                    SauceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Desserts_DessertId",
                        column: x => x.DessertId,
                        principalTable: "Desserts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Comments_Drinks_DrinkId",
                        column: x => x.DrinkId,
                        principalTable: "Drinks",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Comments_Extras_ExtraId",
                        column: x => x.ExtraId,
                        principalTable: "Extras",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Comments_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Comments_Sauce_SauceId",
                        column: x => x.SauceId,
                        principalTable: "Sauce",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DessertOrder",
                columns: table => new
                {
                    DessertsID = table.Column<int>(type: "int", nullable: false),
                    OrdersOrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DessertOrder", x => new { x.DessertsID, x.OrdersOrderID });
                    table.ForeignKey(
                        name: "FK_DessertOrder_Desserts_DessertsID",
                        column: x => x.DessertsID,
                        principalTable: "Desserts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DessertOrder_Orders_OrdersOrderID",
                        column: x => x.OrdersOrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrinkOrder",
                columns: table => new
                {
                    DrinksID = table.Column<int>(type: "int", nullable: false),
                    OrdersOrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinkOrder", x => new { x.DrinksID, x.OrdersOrderID });
                    table.ForeignKey(
                        name: "FK_DrinkOrder_Drinks_DrinksID",
                        column: x => x.DrinksID,
                        principalTable: "Drinks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrinkOrder_Orders_OrdersOrderID",
                        column: x => x.OrdersOrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExtraOrder",
                columns: table => new
                {
                    ExtrasID = table.Column<int>(type: "int", nullable: false),
                    OrdersOrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraOrder", x => new { x.ExtrasID, x.OrdersOrderID });
                    table.ForeignKey(
                        name: "FK_ExtraOrder_Extras_ExtrasID",
                        column: x => x.ExtrasID,
                        principalTable: "Extras",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExtraOrder_Orders_OrdersOrderID",
                        column: x => x.OrdersOrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuOrder",
                columns: table => new
                {
                    MenusID = table.Column<int>(type: "int", nullable: false),
                    OrdersOrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuOrder", x => new { x.MenusID, x.OrdersOrderID });
                    table.ForeignKey(
                        name: "FK_MenuOrder_Menus_MenusID",
                        column: x => x.MenusID,
                        principalTable: "Menus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuOrder_Orders_OrdersOrderID",
                        column: x => x.OrdersOrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderSauce",
                columns: table => new
                {
                    OrdersOrderID = table.Column<int>(type: "int", nullable: false),
                    SaucesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderSauce", x => new { x.OrdersOrderID, x.SaucesID });
                    table.ForeignKey(
                        name: "FK_OrderSauce_Orders_OrdersOrderID",
                        column: x => x.OrdersOrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderSauce_Sauce_SaucesID",
                        column: x => x.SaucesID,
                        principalTable: "Sauce",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1ce9e927-2d41-4770-9816-edf5129fa0cc"), "5c215d4e-8ef1-4aaa-bf69-c8d5535d5144", "Admin", "ADMIN" },
                    { new Guid("5df094ba-45be-4736-a78e-935f949fa388"), "dbb12044-25ac-4ca0-b215-6aa7b13c5964", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Desserts",
                columns: new[] { "ID", "CreatedTime", "Image", "Name", "Price", "Status", "Stock", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3578), "/ProjeResimler/Cikolata.png", "Çikolata Cookie", 10m, true, 50, null },
                    { 2, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3580), "/ProjeResimler/Dondurma.png", "Dondurma", 10m, true, 10, null },
                    { 3, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3581), "/ProjeResimler/Elmali.png", "Elmalı Turta", 25m, true, 70, null },
                    { 4, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3583), "/ProjeResimler/sufle.png", "Sufle", 30m, true, 45, null },
                    { 5, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3584), "/ProjeResimler/sundae.png", "Sundae", 17m, true, 100, null }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "ID", "CreatedTime", "Image", "Name", "Price", "Status", "Stock", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3599), "/ProjeResimler/Ayran.png", "Ayran", 12m, true, 250, null },
                    { 2, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3601), "/ProjeResimler/Cola.png", "Kola", 16m, true, 450, null },
                    { 3, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3602), "/ProjeResimler/Fanta.png", "Fanta", 16m, true, 350, null },
                    { 4, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3603), "/ProjeResimler/Icetea.png", "Ice Tea", 14m, true, 270, null },
                    { 5, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3604), "/ProjeResimler/MeyveSuyu.png", "Meyve Suyu", 10m, true, 400, null },
                    { 6, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3606), "/ProjeResimler/Sprite.png", "Sprite", 14m, true, 130, null }
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "ID", "CreatedTime", "Image", "Name", "Price", "Status", "Stock", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3555), "/ProjeResimler/Patates.jpg", "Patates Kızartması", 12m, true, 350, null },
                    { 2, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3557), "/ProjeResimler/Tender.png", "Tavuk Tender", 20m, true, 350, null },
                    { 3, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3563), "/ProjeResimler/sogan.jpg", "Soğan Halkası", 17m, true, 350, null },
                    { 4, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3565), "/ProjeResimler/Nugget.png", "Nugget", 16m, true, 350, null },
                    { 5, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3566), "/ProjeResimler/Citir.png", "Çıtır Tavuk", 22m, true, 350, null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "ID", "CreatedTime", "Description", "Image", "Name", "Price", "Status", "Stock", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3442), "Burger(Balık+Domates+Peynir+Turşu)+Patates(200 gr)+İçecek(Kola)", "/ProjeResimler/BalikBurger.jpg", "Balık Burger Menu", 100m, true, 250, null },
                    { 2, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3445), "Burger(2 Köfte+Marul+Peynir+Mayonez)+Patates(200gr)+İçecek(Ice Tea)", "/ProjeResimler/DoubleBurger.jpg", "Double Burger Menu", 95m, true, 250, null },
                    { 3, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3446), "Burger(Tavuk+Marul+Domates+Çıtır Soğan)+Patates(200gr)+İçecek(Ayran)", "/ProjeResimler/TavukBurger.jpg", "Tavuk Burger Menu", 55m, true, 250, null },
                    { 4, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3447), "Burger(Siyah Ekmek+240gr Köfte+Turşu+Karamelize Soğan)+Patates(200gr)+İçecek(Fanta)", "/ProjeResimler/BlackBurger.jpg", "Black Burger Menu", 120m, true, 250, null }
                });

            migrationBuilder.InsertData(
                table: "Sauce",
                columns: new[] { "ID", "CreatedTime", "Image", "Name", "Price", "Status", "Stock", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3532), "/ProjeResimler/Ketcap.png", "Ketçap", 3m, true, 250, null },
                    { 2, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3533), "/ProjeResimler/Acisos.png", "Acı Sos", 3m, true, 350, null },
                    { 3, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3535), "/ProjeResimler/Barbakü.png", "Barbekü Sosu", 3m, true, 350, null },
                    { 4, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3536), "/ProjeResimler/Buffalo.png", "Buffalo Sosu", 3m, true, 400, null },
                    { 5, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3537), "/ProjeResimler/Hardal.png", "Hardal Sosu", 3m, true, 150, null },
                    { 6, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3538), "/ProjeResimler/Ranch.png", "Ranch Sosu", 3m, true, 650, null },
                    { 7, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3539), "/ProjeResimler/Mayonez.png", "Mayonez", 3m, true, 220, null },
                    { 8, new DateTime(2023, 4, 9, 19, 1, 30, 802, DateTimeKind.Local).AddTicks(3541), "/ProjeResimler/Sarımsaklı.png", "Sarımsaklı Mayonez", 3m, true, 345, null }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AppUserId",
                table: "Comments",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DessertId",
                table: "Comments",
                column: "DessertId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DrinkId",
                table: "Comments",
                column: "DrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ExtraId",
                table: "Comments",
                column: "ExtraId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MenuId",
                table: "Comments",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_SauceId",
                table: "Comments",
                column: "SauceId");

            migrationBuilder.CreateIndex(
                name: "IX_DessertOrder_OrdersOrderID",
                table: "DessertOrder",
                column: "OrdersOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_DrinkOrder_OrdersOrderID",
                table: "DrinkOrder",
                column: "OrdersOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraOrder_OrdersOrderID",
                table: "ExtraOrder",
                column: "OrdersOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuOrder_OrdersOrderID",
                table: "MenuOrder",
                column: "OrdersOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSauce_SaucesID",
                table: "OrderSauce",
                column: "SaucesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Comments");

            migrationBuilder.DropTable(
                name: "DessertOrder");

            migrationBuilder.DropTable(
                name: "DrinkOrder");

            migrationBuilder.DropTable(
                name: "ExtraOrder");

            migrationBuilder.DropTable(
                name: "MenuOrder");

            migrationBuilder.DropTable(
                name: "OrderSauce");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Desserts");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Sauce");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
