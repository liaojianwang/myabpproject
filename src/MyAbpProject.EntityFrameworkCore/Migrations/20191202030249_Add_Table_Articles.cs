using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAbpProject.Migrations
{
    public partial class Add_Table_Articles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dt_article",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    site_id = table.Column<int>(nullable: false),
                    channel_id = table.Column<int>(nullable: false),
                    category_id = table.Column<int>(nullable: false),
                    brand_id = table.Column<int>(nullable: false),
                    call_index = table.Column<string>(maxLength: 256, nullable: true),
                    title = table.Column<string>(maxLength: 256, nullable: true),
                    link_url = table.Column<string>(maxLength: 256, nullable: true),
                    img_url = table.Column<string>(maxLength: 512, nullable: true),
                    seo_title = table.Column<string>(nullable: true),
                    seo_keywords = table.Column<string>(maxLength: 512, nullable: true),
                    seo_description = table.Column<string>(maxLength: 512, nullable: true),
                    tags = table.Column<string>(maxLength: 512, nullable: true),
                    zhaiyao = table.Column<string>(maxLength: 512, nullable: true),
                    content = table.Column<string>(nullable: true),
                    sort_id = table.Column<int>(nullable: false),
                    click = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    is_msg = table.Column<int>(nullable: false),
                    is_top = table.Column<int>(nullable: false),
                    is_red = table.Column<int>(nullable: false),
                    is_hot = table.Column<int>(nullable: false),
                    is_slide = table.Column<int>(nullable: false),
                    is_sys = table.Column<int>(nullable: false),
                    like_count = table.Column<int>(nullable: false),
                    user_name = table.Column<string>(maxLength: 256, nullable: true),
                    update_time = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dt_article", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dt_article_albums",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    channel_id = table.Column<int>(nullable: false),
                    article_id = table.Column<int>(nullable: false),
                    thumb_path = table.Column<string>(maxLength: 512, nullable: true),
                    original_path = table.Column<string>(maxLength: 512, nullable: true),
                    remark = table.Column<string>(maxLength: 512, nullable: true),
                    ArticleInfoId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dt_article_albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dt_article_albums_dt_article_ArticleInfoId",
                        column: x => x.ArticleInfoId,
                        principalTable: "dt_article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "dt_article_attach",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    channel_id = table.Column<int>(nullable: false),
                    article_id = table.Column<int>(nullable: false),
                    file_name = table.Column<string>(maxLength: 256, nullable: true),
                    file_path = table.Column<string>(maxLength: 512, nullable: true),
                    file_size = table.Column<int>(nullable: false),
                    file_ext = table.Column<string>(maxLength: 256, nullable: true),
                    down_num = table.Column<int>(nullable: false),
                    point = table.Column<int>(nullable: false),
                    ArticleInfoId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dt_article_attach", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dt_article_attach_dt_article_ArticleInfoId",
                        column: x => x.ArticleInfoId,
                        principalTable: "dt_article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "dt_article_goods",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    channel_id = table.Column<int>(nullable: false),
                    article_id = table.Column<int>(nullable: false),
                    goods_no = table.Column<string>(maxLength: 512, nullable: true),
                    spec_ids = table.Column<string>(maxLength: 512, nullable: true),
                    spec_text = table.Column<string>(maxLength: 512, nullable: true),
                    stock_quantity = table.Column<int>(nullable: false),
                    market_price = table.Column<decimal>(nullable: false),
                    sell_price = table.Column<decimal>(nullable: false),
                    ArticleInfoId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dt_article_goods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dt_article_goods_dt_article_ArticleInfoId",
                        column: x => x.ArticleInfoId,
                        principalTable: "dt_article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "dt_article_goods_spec",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    channel_id = table.Column<int>(nullable: false),
                    article_id = table.Column<int>(nullable: false),
                    spec_id = table.Column<int>(nullable: false),
                    parent_id = table.Column<int>(nullable: false),
                    title = table.Column<string>(maxLength: 256, nullable: true),
                    img_url = table.Column<string>(maxLength: 512, nullable: true),
                    ArticleInfoId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dt_article_goods_spec", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dt_article_goods_spec_dt_article_ArticleInfoId",
                        column: x => x.ArticleInfoId,
                        principalTable: "dt_article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "dt_user_group_price",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    channel_id = table.Column<int>(nullable: false),
                    article_id = table.Column<int>(nullable: false),
                    goods_id = table.Column<int>(nullable: false),
                    group_id = table.Column<int>(nullable: false),
                    price = table.Column<decimal>(nullable: false),
                    ArticleGoodsInfoId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dt_user_group_price", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dt_user_group_price_dt_article_goods_ArticleGoodsInfoId",
                        column: x => x.ArticleGoodsInfoId,
                        principalTable: "dt_article_goods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dt_article_albums_ArticleInfoId",
                table: "dt_article_albums",
                column: "ArticleInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_dt_article_attach_ArticleInfoId",
                table: "dt_article_attach",
                column: "ArticleInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_dt_article_goods_ArticleInfoId",
                table: "dt_article_goods",
                column: "ArticleInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_dt_article_goods_spec_ArticleInfoId",
                table: "dt_article_goods_spec",
                column: "ArticleInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_dt_user_group_price_ArticleGoodsInfoId",
                table: "dt_user_group_price",
                column: "ArticleGoodsInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dt_article_albums");

            migrationBuilder.DropTable(
                name: "dt_article_attach");

            migrationBuilder.DropTable(
                name: "dt_article_goods_spec");

            migrationBuilder.DropTable(
                name: "dt_user_group_price");

            migrationBuilder.DropTable(
                name: "dt_article_goods");

            migrationBuilder.DropTable(
                name: "dt_article");
        }
    }
}
