using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAbpProject.Migrations
{
    public partial class Update_Table_BaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "ManagerInfo");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "dt_user_group_price");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "dt_article_goods_spec");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "dt_article_goods");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "dt_article_attach");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "dt_article_albums");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "dt_article");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "ManagerInfo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "ManagerInfo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "ManagerInfo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "dt_user_group_price",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "dt_user_group_price",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "dt_user_group_price",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "dt_article_goods_spec",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "dt_article_goods_spec",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "dt_article_goods_spec",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "dt_article_goods",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "dt_article_goods",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "dt_article_goods",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "dt_article_attach",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "dt_article_attach",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "dt_article_attach",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "dt_article_albums",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "dt_article_albums",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "dt_article_albums",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "dt_article",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "dt_article",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "dt_article",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "ManagerInfo");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "ManagerInfo");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "ManagerInfo");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "dt_user_group_price");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "dt_user_group_price");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "dt_user_group_price");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "dt_article_goods_spec");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "dt_article_goods_spec");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "dt_article_goods_spec");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "dt_article_goods");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "dt_article_goods");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "dt_article_goods");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "dt_article_attach");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "dt_article_attach");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "dt_article_attach");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "dt_article_albums");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "dt_article_albums");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "dt_article_albums");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "dt_article");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "dt_article");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "dt_article");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "ManagerInfo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "dt_user_group_price",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "dt_article_goods_spec",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "dt_article_goods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "dt_article_attach",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "dt_article_albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "dt_article",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
