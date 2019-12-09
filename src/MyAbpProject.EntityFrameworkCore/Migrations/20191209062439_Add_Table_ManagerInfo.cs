using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAbpProject.Migrations
{
    public partial class Add_Table_ManagerInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManagerInfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    role_id = table.Column<int>(nullable: false),
                    role_type = table.Column<int>(nullable: false),
                    user_name = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    salt = table.Column<string>(nullable: true),
                    avatar = table.Column<string>(nullable: true),
                    real_name = table.Column<string>(nullable: true),
                    telephone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    is_audit = table.Column<int>(nullable: false),
                    is_lock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerInfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManagerInfo");
        }
    }
}
