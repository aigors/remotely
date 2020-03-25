﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Remotely.Server.Migrations
{
    public partial class Alerts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alerts",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<string>(nullable: false),
                    DeviceID = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    OrganizationID = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    UserIDId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alerts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Alerts_Devices_DeviceID",
                        column: x => x.DeviceID,
                        principalTable: "Devices",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alerts_Organizations_OrganizationID",
                        column: x => x.OrganizationID,
                        principalTable: "Organizations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alerts_RemotelyUsers_UserIDId",
                        column: x => x.UserIDId,
                        principalTable: "RemotelyUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alerts_RemotelyUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "RemotelyUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alerts_DeviceID",
                table: "Alerts",
                column: "DeviceID");

            migrationBuilder.CreateIndex(
                name: "IX_Alerts_OrganizationID",
                table: "Alerts",
                column: "OrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_Alerts_UserIDId",
                table: "Alerts",
                column: "UserIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Alerts_UserId",
                table: "Alerts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alerts");
        }
    }
}
