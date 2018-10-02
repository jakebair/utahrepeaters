using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UtahRepeaters.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RepeaterAttributes",
                columns: table => new
                {
                    RepeaterAttributesId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sponsor = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    GeographicalArea = table.Column<string>(nullable: true),
                    Coordinated = table.Column<bool>(nullable: false),
                    Open = table.Column<bool>(nullable: false),
                    Closed = table.Column<bool>(nullable: false),
                    Bilingual = table.Column<bool>(nullable: false),
                    Experimental = table.Column<bool>(nullable: false),
                    LITZ = table.Column<bool>(nullable: false),
                    Tone = table.Column<bool>(nullable: false),
                    CTCSS_IN = table.Column<int>(nullable: false),
                    CTCSS_OUT = table.Column<int>(nullable: false),
                    DCS = table.Column<bool>(nullable: false),
                    DCS_CODE = table.Column<string>(nullable: true),
                    DTMF = table.Column<bool>(nullable: false),
                    Remote_Base = table.Column<bool>(nullable: false),
                    SNP = table.Column<bool>(nullable: false),
                    Autopatch = table.Column<bool>(nullable: false),
                    Patch_Seq = table.Column<string>(nullable: true),
                    CLOSED_PATCH = table.Column<string>(nullable: true),
                    EMERG_POWER = table.Column<string>(nullable: true),
                    EMERG_SUN = table.Column<string>(nullable: true),
                    EMERG_WIND = table.Column<string>(nullable: true),
                    LINKED = table.Column<string>(nullable: true),
                    LINKED_FREQ = table.Column<string>(nullable: true),
                    PORTABLE = table.Column<string>(nullable: true),
                    RACES = table.Column<string>(nullable: true),
                    ARES = table.Column<string>(nullable: true),
                    WIDE_AREA = table.Column<string>(nullable: true),
                    LAW = table.Column<string>(nullable: true),
                    LAW_DTMF = table.Column<string>(nullable: true),
                    WEATHER = table.Column<string>(nullable: true),
                    WEATHER_DTMF = table.Column<string>(nullable: true),
                    INTERNET = table.Column<bool>(nullable: false),
                    INTERNET_LINK = table.Column<string>(nullable: true),
                    NOTES = table.Column<string>(nullable: true),
                    UPDATE = table.Column<DateTime>(nullable: false),
                    COORD_DATE = table.Column<DateTime>(nullable: false),
                    USE = table.Column<string>(nullable: true),
                    LATITUDE_DDMMSS = table.Column<string>(nullable: true),
                    LONGITUDE_DDDMMSS = table.Column<string>(nullable: true),
                    AMSL_FEET = table.Column<int>(nullable: false),
                    TX_POWER = table.Column<int>(nullable: false),
                    ANT_INFO = table.Column<string>(nullable: true),
                    ERP = table.Column<string>(nullable: true),
                    PUB_CODE = table.Column<string>(nullable: true),
                    ACTIVE = table.Column<string>(nullable: true),
                    SITE_NAME = table.Column<string>(nullable: true),
                    COVERAGE_AREA = table.Column<string>(nullable: true),
                    FOOTNOTES = table.Column<string>(nullable: true),
                    CONTACT_EMAIL = table.Column<string>(nullable: true),
                    REPEATER_WEB_PAGE = table.Column<string>(nullable: true),
                    MAPSEL = table.Column<string>(nullable: true),
                    CONTACT_PHONE = table.Column<string>(nullable: true),
                    UPDATE_SOURCE = table.Column<string>(nullable: true),
                    COORD_NOTES = table.Column<string>(nullable: true),
                    CONTACT_MAIL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepeaterAttributes", x => x.RepeaterAttributesId);
                });

            migrationBuilder.CreateTable(
                name: "Repeaters",
                columns: table => new
                {
                    RepeaterId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Band = table.Column<int>(nullable: false),
                    Input = table.Column<int>(nullable: false),
                    Output = table.Column<int>(nullable: false),
                    Callsign = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AttributesRepeaterAttributesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repeaters", x => x.RepeaterId);
                    table.ForeignKey(
                        name: "FK_Repeaters_RepeaterAttributes_AttributesRepeaterAttributesId",
                        column: x => x.AttributesRepeaterAttributesId,
                        principalTable: "RepeaterAttributes",
                        principalColumn: "RepeaterAttributesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Coordinates",
                columns: table => new
                {
                    CoordinatesId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    Elevation = table.Column<int>(nullable: false),
                    StateCode = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    RepeaterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinates", x => x.CoordinatesId);
                    table.ForeignKey(
                        name: "FK_Coordinates_Repeaters_RepeaterId",
                        column: x => x.RepeaterId,
                        principalTable: "Repeaters",
                        principalColumn: "RepeaterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coordinates_RepeaterId",
                table: "Coordinates",
                column: "RepeaterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Repeaters_AttributesRepeaterAttributesId",
                table: "Repeaters",
                column: "AttributesRepeaterAttributesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coordinates");

            migrationBuilder.DropTable(
                name: "Repeaters");

            migrationBuilder.DropTable(
                name: "RepeaterAttributes");
        }
    }
}
