using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAbpProject.Migrations
{
    public partial class Add_Table_NavigationInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NavigationInfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    ChannelId = table.Column<int>(nullable: false),
                    NavType = table.Column<string>(nullable: true),
                    NavName = table.Column<string>(nullable: true),
                    NavTitle = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    IconUrl = table.Column<string>(nullable: true),
                    LinkUrl = table.Column<string>(nullable: true),
                    SortId = table.Column<int>(nullable: false),
                    IsLock = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    ActionType = table.Column<string>(nullable: true),
                    IsSys = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavigationInfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NavigationInfo");
        }
    }
}
