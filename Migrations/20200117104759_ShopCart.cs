﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace amti_bookShop.Migrations
{
    public partial class ShopCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopCartItem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookid = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    ShopCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCartItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_ShopCartItem_Book_bookid",
                        column: x => x.bookid,
                        principalTable: "Book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItem_bookid",
                table: "ShopCartItem",
                column: "bookid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopCartItem");
        }
    }
}
