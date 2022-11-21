using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eProjectClient.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_account_account_id",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_dimmst_Category_category_id",
                table: "dimmst");

            migrationBuilder.DropForeignKey(
                name: "FK_dimmst_certify_certify_id",
                table: "dimmst");

            migrationBuilder.DropForeignKey(
                name: "FK_dimmst_dimqlty_mst_dimqlty_id",
                table: "dimmst");

            migrationBuilder.DropForeignKey(
                name: "FK_dimmst_dimqlty_submst_dimsubtype_id",
                table: "dimmst");

            migrationBuilder.DropForeignKey(
                name: "FK_item_product_brand_brand_id",
                table: "item_product");

            migrationBuilder.DropForeignKey(
                name: "FK_item_product_Category_category_id",
                table: "item_product");

            migrationBuilder.DropForeignKey(
                name: "FK_item_product_certify_certify_id",
                table: "item_product");

            migrationBuilder.DropForeignKey(
                name: "FK_item_product_goldk_goldtype_id",
                table: "item_product");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_account_account_id",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_order_id",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_stone_mst_Category_category_id",
                table: "stone_mst");

            migrationBuilder.DropForeignKey(
                name: "FK_stone_mst_certify_certify_id",
                table: "stone_mst");

            migrationBuilder.DropForeignKey(
                name: "FK_stone_mst_stone_stoneqlty_id",
                table: "stone_mst");

            migrationBuilder.DropIndex(
                name: "IX_item_product_goldtype_id",
                table: "item_product");

            migrationBuilder.AlterColumn<string>(
                name: "stoneqlty_id",
                table: "stone_mst",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "certify_id",
                table: "stone_mst",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "category_id",
                table: "stone_mst",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "stoneqlty_id",
                table: "stone",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "order_id",
                table: "OrderDetail",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "account_id",
                table: "Order",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "id_order",
                table: "Order",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "goldtype_id",
                table: "item_product",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "certify_id",
                table: "item_product",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "category_id",
                table: "item_product",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "brand_id",
                table: "item_product",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<string>(
                name: "Goldk",
                table: "item_product",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "image_product",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "goldtype_id",
                table: "goldk",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "dimsub_type_id",
                table: "dimqlty_submst",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "dimqlty_id",
                table: "dimqlty_mst",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "dimsubtype_id",
                table: "dimmst",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "dimqlty_id",
                table: "dimmst",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "certify_id",
                table: "dimmst",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "category_id",
                table: "dimmst",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "account_id",
                table: "comment",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "comment",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "id_certify",
                table: "certify",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "category_id",
                table: "Category",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "id_brand",
                table: "brand",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "account",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_comment_account_account_id",
                table: "comment",
                column: "account_id",
                principalTable: "account",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dimmst_Category_category_id",
                table: "dimmst",
                column: "category_id",
                principalTable: "Category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dimmst_certify_certify_id",
                table: "dimmst",
                column: "certify_id",
                principalTable: "certify",
                principalColumn: "id_certify",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dimmst_dimqlty_mst_dimqlty_id",
                table: "dimmst",
                column: "dimqlty_id",
                principalTable: "dimqlty_mst",
                principalColumn: "dimqlty_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dimmst_dimqlty_submst_dimsubtype_id",
                table: "dimmst",
                column: "dimsubtype_id",
                principalTable: "dimqlty_submst",
                principalColumn: "dimsub_type_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_item_product_brand_brand_id",
                table: "item_product",
                column: "brand_id",
                principalTable: "brand",
                principalColumn: "id_brand",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_item_product_Category_category_id",
                table: "item_product",
                column: "category_id",
                principalTable: "Category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_item_product_certify_certify_id",
                table: "item_product",
                column: "certify_id",
                principalTable: "certify",
                principalColumn: "id_certify",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_account_account_id",
                table: "Order",
                column: "account_id",
                principalTable: "account",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_order_id",
                table: "OrderDetail",
                column: "order_id",
                principalTable: "Order",
                principalColumn: "id_order",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_stone_mst_Category_category_id",
                table: "stone_mst",
                column: "category_id",
                principalTable: "Category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_stone_mst_certify_certify_id",
                table: "stone_mst",
                column: "certify_id",
                principalTable: "certify",
                principalColumn: "id_certify",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_stone_mst_stone_stoneqlty_id",
                table: "stone_mst",
                column: "stoneqlty_id",
                principalTable: "stone",
                principalColumn: "stoneqlty_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_account_account_id",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_dimmst_Category_category_id",
                table: "dimmst");

            migrationBuilder.DropForeignKey(
                name: "FK_dimmst_certify_certify_id",
                table: "dimmst");

            migrationBuilder.DropForeignKey(
                name: "FK_dimmst_dimqlty_mst_dimqlty_id",
                table: "dimmst");

            migrationBuilder.DropForeignKey(
                name: "FK_dimmst_dimqlty_submst_dimsubtype_id",
                table: "dimmst");

            migrationBuilder.DropForeignKey(
                name: "FK_item_product_brand_brand_id",
                table: "item_product");

            migrationBuilder.DropForeignKey(
                name: "FK_item_product_Category_category_id",
                table: "item_product");

            migrationBuilder.DropForeignKey(
                name: "FK_item_product_certify_certify_id",
                table: "item_product");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_account_account_id",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_order_id",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_stone_mst_Category_category_id",
                table: "stone_mst");

            migrationBuilder.DropForeignKey(
                name: "FK_stone_mst_certify_certify_id",
                table: "stone_mst");

            migrationBuilder.DropForeignKey(
                name: "FK_stone_mst_stone_stoneqlty_id",
                table: "stone_mst");

            migrationBuilder.DropColumn(
                name: "Goldk",
                table: "item_product");

            migrationBuilder.AlterColumn<Guid>(
                name: "stoneqlty_id",
                table: "stone_mst",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "certify_id",
                table: "stone_mst",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "category_id",
                table: "stone_mst",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "stoneqlty_id",
                table: "stone",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "order_id",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "account_id",
                table: "Order",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "id_order",
                table: "Order",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "goldtype_id",
                table: "item_product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "certify_id",
                table: "item_product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "category_id",
                table: "item_product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "brand_id",
                table: "item_product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                table: "image_product",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "goldtype_id",
                table: "goldk",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "dimsub_type_id",
                table: "dimqlty_submst",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "dimqlty_id",
                table: "dimqlty_mst",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "dimsubtype_id",
                table: "dimmst",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "dimqlty_id",
                table: "dimmst",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "certify_id",
                table: "dimmst",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "category_id",
                table: "dimmst",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "account_id",
                table: "comment",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "id",
                table: "comment",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "id_certify",
                table: "certify",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "category_id",
                table: "Category",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "id_brand",
                table: "brand",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "userId",
                table: "account",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_item_product_goldtype_id",
                table: "item_product",
                column: "goldtype_id");

            migrationBuilder.AddForeignKey(
                name: "FK_comment_account_account_id",
                table: "comment",
                column: "account_id",
                principalTable: "account",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dimmst_Category_category_id",
                table: "dimmst",
                column: "category_id",
                principalTable: "Category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dimmst_certify_certify_id",
                table: "dimmst",
                column: "certify_id",
                principalTable: "certify",
                principalColumn: "id_certify",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dimmst_dimqlty_mst_dimqlty_id",
                table: "dimmst",
                column: "dimqlty_id",
                principalTable: "dimqlty_mst",
                principalColumn: "dimqlty_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dimmst_dimqlty_submst_dimsubtype_id",
                table: "dimmst",
                column: "dimsubtype_id",
                principalTable: "dimqlty_submst",
                principalColumn: "dimsub_type_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_item_product_brand_brand_id",
                table: "item_product",
                column: "brand_id",
                principalTable: "brand",
                principalColumn: "id_brand",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_item_product_Category_category_id",
                table: "item_product",
                column: "category_id",
                principalTable: "Category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_item_product_certify_certify_id",
                table: "item_product",
                column: "certify_id",
                principalTable: "certify",
                principalColumn: "id_certify",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_item_product_goldk_goldtype_id",
                table: "item_product",
                column: "goldtype_id",
                principalTable: "goldk",
                principalColumn: "goldtype_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_account_account_id",
                table: "Order",
                column: "account_id",
                principalTable: "account",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_order_id",
                table: "OrderDetail",
                column: "order_id",
                principalTable: "Order",
                principalColumn: "id_order",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stone_mst_Category_category_id",
                table: "stone_mst",
                column: "category_id",
                principalTable: "Category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stone_mst_certify_certify_id",
                table: "stone_mst",
                column: "certify_id",
                principalTable: "certify",
                principalColumn: "id_certify",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stone_mst_stone_stoneqlty_id",
                table: "stone_mst",
                column: "stoneqlty_id",
                principalTable: "stone",
                principalColumn: "stoneqlty_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
