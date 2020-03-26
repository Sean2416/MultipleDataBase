﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MultipleDataBase.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flow",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DevID = table.Column<string>(nullable: true),
                    Dhost = table.Column<string>(nullable: true),
                    Act = table.Column<string>(nullable: true),
                    Proto = table.Column<int>(nullable: true),
                    Stime = table.Column<DateTime>(nullable: true),
                    Sip = table.Column<string>(nullable: true),
                    Dip = table.Column<string>(nullable: true),
                    Sport = table.Column<int>(nullable: true),
                    DPort = table.Column<int>(nullable: true),
                    Up = table.Column<int>(nullable: true),
                    Down = table.Column<int>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flow", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flow");
        }
    }
}
