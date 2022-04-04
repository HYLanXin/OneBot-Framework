using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XinBotDBEntity.Migrations
{
    public partial class Init001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BotServer_FunList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FunName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FunType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IntervalTime = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BotServer_FunList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BotServer_GroupInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<long>(type: "bigint", maxLength: 20, nullable: false),
                    ServerName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BotId = table.Column<long>(type: "bigint", maxLength: 20, nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Creater = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modifier = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BotServer_GroupInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BotServer_GroupFunLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Funid = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    IsOpen = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BotServer_GroupFunLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BotServer_GroupFunLists_BotServer_FunList_Id",
                        column: x => x.Id,
                        principalTable: "BotServer_FunList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BotServer_GroupFunLists_BotServer_GroupInfo_Id",
                        column: x => x.Id,
                        principalTable: "BotServer_GroupInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BotServer_GroupFunLists");

            migrationBuilder.DropTable(
                name: "BotServer_FunList");

            migrationBuilder.DropTable(
                name: "BotServer_GroupInfo");
        }
    }
}
