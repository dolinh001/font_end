using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eProjectClient.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_account_account_id",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_comment_dimmst_style_code_dim_mst",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_comment_item_product_style_code_itemproduct",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_comment_stone_mst_style_code_stone_mst",
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
                name: "FK_image_product_dimmst_style_code_dim_mst",
                table: "image_product");

            migrationBuilder.DropForeignKey(
                name: "FK_image_product_item_product_style_code_itemproduct",
                table: "image_product");

            migrationBuilder.DropForeignKey(
                name: "FK_image_product_stone_mst_style_code_stone_mst",
                table: "image_product");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_stone_mst",
                table: "stone_mst");

            migrationBuilder.DropPrimaryKey(
                name: "PK_item_product",
                table: "item_product");

            migrationBuilder.DropIndex(
                name: "IX_image_product_style_code_dim_mst",
                table: "image_product");

            migrationBuilder.DropIndex(
                name: "IX_image_product_style_code_itemproduct",
                table: "image_product");

            migrationBuilder.DropIndex(
                name: "IX_image_product_style_code_stone_mst",
                table: "image_product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dimmst",
                table: "dimmst");

            migrationBuilder.DropIndex(
                name: "IX_comment_style_code_dim_mst",
                table: "comment");

            migrationBuilder.DropIndex(
                name: "IX_comment_style_code_itemproduct",
                table: "comment");

            migrationBuilder.DropIndex(
                name: "IX_comment_style_code_stone_mst",
                table: "comment");

            migrationBuilder.DropColumn(
                name: "style_code_dim_mst",
                table: "image_product");

            migrationBuilder.DropColumn(
                name: "style_code_itemproduct",
                table: "image_product");

            migrationBuilder.DropColumn(
                name: "style_code_stone_mst",
                table: "image_product");

            migrationBuilder.DropColumn(
                name: "style_code_dim_mst",
                table: "comment");

            migrationBuilder.DropColumn(
                name: "style_code_itemproduct",
                table: "comment");

            migrationBuilder.DropColumn(
                name: "style_code_stone_mst",
                table: "comment");

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

            migrationBuilder.AlterColumn<string>(
                name: "style_code",
                table: "stone_mst",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<Guid>(
                name: "stoneId",
                table: "stone_mst",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.AlterColumn<string>(
                name: "style_code",
                table: "item_product",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<Guid>(
                name: "productId",
                table: "item_product",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "dimId",
                table: "image_product",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "productId",
                table: "image_product",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "stoneId",
                table: "image_product",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.AlterColumn<string>(
                name: "style_code",
                table: "dimmst",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<Guid>(
                name: "dimId",
                table: "dimmst",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.AddColumn<Guid>(
                name: "dimId",
                table: "comment",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "productId",
                table: "comment",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "stoneId",
                table: "comment",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_stone_mst",
                table: "stone_mst",
                column: "stoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_item_product",
                table: "item_product",
                column: "productId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dimmst",
                table: "dimmst",
                column: "dimId");

            migrationBuilder.CreateIndex(
                name: "IX_image_product_dimId",
                table: "image_product",
                column: "dimId");

            migrationBuilder.CreateIndex(
                name: "IX_image_product_productId",
                table: "image_product",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_image_product_stoneId",
                table: "image_product",
                column: "stoneId");

            migrationBuilder.CreateIndex(
                name: "IX_comment_dimId",
                table: "comment",
                column: "dimId");

            migrationBuilder.CreateIndex(
                name: "IX_comment_productId",
                table: "comment",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_comment_stoneId",
                table: "comment",
                column: "stoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_comment_account_account_id",
                table: "comment",
                column: "account_id",
                principalTable: "account",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comment_dimmst_dimId",
                table: "comment",
                column: "dimId",
                principalTable: "dimmst",
                principalColumn: "dimId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comment_item_product_productId",
                table: "comment",
                column: "productId",
                principalTable: "item_product",
                principalColumn: "productId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comment_stone_mst_stoneId",
                table: "comment",
                column: "stoneId",
                principalTable: "stone_mst",
                principalColumn: "stoneId",
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
                name: "FK_image_product_dimmst_dimId",
                table: "image_product",
                column: "dimId",
                principalTable: "dimmst",
                principalColumn: "dimId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_image_product_item_product_productId",
                table: "image_product",
                column: "productId",
                principalTable: "item_product",
                principalColumn: "productId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_image_product_stone_mst_stoneId",
                table: "image_product",
                column: "stoneId",
                principalTable: "stone_mst",
                principalColumn: "stoneId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_account_account_id",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_comment_dimmst_dimId",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_comment_item_product_productId",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_comment_stone_mst_stoneId",
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
                name: "FK_image_product_dimmst_dimId",
                table: "image_product");

            migrationBuilder.DropForeignKey(
                name: "FK_image_product_item_product_productId",
                table: "image_product");

            migrationBuilder.DropForeignKey(
                name: "FK_image_product_stone_mst_stoneId",
                table: "image_product");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_stone_mst",
                table: "stone_mst");

            migrationBuilder.DropPrimaryKey(
                name: "PK_item_product",
                table: "item_product");

            migrationBuilder.DropIndex(
                name: "IX_image_product_dimId",
                table: "image_product");

            migrationBuilder.DropIndex(
                name: "IX_image_product_productId",
                table: "image_product");

            migrationBuilder.DropIndex(
                name: "IX_image_product_stoneId",
                table: "image_product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dimmst",
                table: "dimmst");

            migrationBuilder.DropIndex(
                name: "IX_comment_dimId",
                table: "comment");

            migrationBuilder.DropIndex(
                name: "IX_comment_productId",
                table: "comment");

            migrationBuilder.DropIndex(
                name: "IX_comment_stoneId",
                table: "comment");

            migrationBuilder.DropColumn(
                name: "stoneId",
                table: "stone_mst");

            migrationBuilder.DropColumn(
                name: "productId",
                table: "item_product");

            migrationBuilder.DropColumn(
                name: "dimId",
                table: "image_product");

            migrationBuilder.DropColumn(
                name: "productId",
                table: "image_product");

            migrationBuilder.DropColumn(
                name: "stoneId",
                table: "image_product");

            migrationBuilder.DropColumn(
                name: "dimId",
                table: "dimmst");

            migrationBuilder.DropColumn(
                name: "dimId",
                table: "comment");

            migrationBuilder.DropColumn(
                name: "productId",
                table: "comment");

            migrationBuilder.DropColumn(
                name: "stoneId",
                table: "comment");

            migrationBuilder.AlterColumn<string>(
                name: "style_code",
                table: "stone_mst",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
                name: "style_code",
                table: "item_product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
                name: "style_code_dim_mst",
                table: "image_product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "style_code_itemproduct",
                table: "image_product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "style_code_stone_mst",
                table: "image_product",
                nullable: true);

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
                name: "style_code",
                table: "dimmst",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "style_code_dim_mst",
                table: "comment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "style_code_itemproduct",
                table: "comment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "style_code_stone_mst",
                table: "comment",
                nullable: true);

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_stone_mst",
                table: "stone_mst",
                column: "style_code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_item_product",
                table: "item_product",
                column: "style_code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dimmst",
                table: "dimmst",
                column: "style_code");

            migrationBuilder.CreateIndex(
                name: "IX_image_product_style_code_dim_mst",
                table: "image_product",
                column: "style_code_dim_mst");

            migrationBuilder.CreateIndex(
                name: "IX_image_product_style_code_itemproduct",
                table: "image_product",
                column: "style_code_itemproduct");

            migrationBuilder.CreateIndex(
                name: "IX_image_product_style_code_stone_mst",
                table: "image_product",
                column: "style_code_stone_mst");

            migrationBuilder.CreateIndex(
                name: "IX_comment_style_code_dim_mst",
                table: "comment",
                column: "style_code_dim_mst");

            migrationBuilder.CreateIndex(
                name: "IX_comment_style_code_itemproduct",
                table: "comment",
                column: "style_code_itemproduct");

            migrationBuilder.CreateIndex(
                name: "IX_comment_style_code_stone_mst",
                table: "comment",
                column: "style_code_stone_mst");

            migrationBuilder.AddForeignKey(
                name: "FK_comment_account_account_id",
                table: "comment",
                column: "account_id",
                principalTable: "account",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_comment_dimmst_style_code_dim_mst",
                table: "comment",
                column: "style_code_dim_mst",
                principalTable: "dimmst",
                principalColumn: "style_code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_comment_item_product_style_code_itemproduct",
                table: "comment",
                column: "style_code_itemproduct",
                principalTable: "item_product",
                principalColumn: "style_code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_comment_stone_mst_style_code_stone_mst",
                table: "comment",
                column: "style_code_stone_mst",
                principalTable: "stone_mst",
                principalColumn: "style_code",
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
                name: "FK_image_product_dimmst_style_code_dim_mst",
                table: "image_product",
                column: "style_code_dim_mst",
                principalTable: "dimmst",
                principalColumn: "style_code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_image_product_item_product_style_code_itemproduct",
                table: "image_product",
                column: "style_code_itemproduct",
                principalTable: "item_product",
                principalColumn: "style_code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_image_product_stone_mst_style_code_stone_mst",
                table: "image_product",
                column: "style_code_stone_mst",
                principalTable: "stone_mst",
                principalColumn: "style_code",
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
    }
}
