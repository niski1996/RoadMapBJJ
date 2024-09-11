using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadMapBJJ.Database.Migrations
{
    /// <inheritdoc />
    public partial class Techniques : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PositionRow",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PositionType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionRow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FightActionRow",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    StartingPositionId = table.Column<Guid>(type: "uuid", nullable: false),
                    ActionType = table.Column<int>(type: "integer", nullable: false),
                    FightActionRowId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FightActionRow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FightActionRow_FightActionRow_FightActionRowId",
                        column: x => x.FightActionRowId,
                        principalSchema: "main",
                        principalTable: "FightActionRow",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FightActionRow_PositionRow_StartingPositionId",
                        column: x => x.StartingPositionId,
                        principalSchema: "main",
                        principalTable: "PositionRow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransitionRow",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    InitialPositionId = table.Column<Guid>(type: "uuid", nullable: false),
                    FinalPositionId = table.Column<Guid>(type: "uuid", nullable: false),
                    TransitionType = table.Column<int>(type: "integer", nullable: false),
                    PositionRowId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransitionRow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransitionRow_PositionRow_FinalPositionId",
                        column: x => x.FinalPositionId,
                        principalSchema: "main",
                        principalTable: "PositionRow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransitionRow_PositionRow_InitialPositionId",
                        column: x => x.InitialPositionId,
                        principalSchema: "main",
                        principalTable: "PositionRow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransitionRow_PositionRow_PositionRowId",
                        column: x => x.PositionRowId,
                        principalSchema: "main",
                        principalTable: "PositionRow",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VideoRow",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FightActionRowId = table.Column<Guid>(type: "uuid", nullable: true),
                    PositionRowId = table.Column<Guid>(type: "uuid", nullable: true),
                    TransitionRowId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoRow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoRow_FightActionRow_FightActionRowId",
                        column: x => x.FightActionRowId,
                        principalSchema: "main",
                        principalTable: "FightActionRow",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VideoRow_PositionRow_PositionRowId",
                        column: x => x.PositionRowId,
                        principalSchema: "main",
                        principalTable: "PositionRow",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VideoRow_TransitionRow_TransitionRowId",
                        column: x => x.TransitionRowId,
                        principalSchema: "main",
                        principalTable: "TransitionRow",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FightActionRow_FightActionRowId",
                schema: "main",
                table: "FightActionRow",
                column: "FightActionRowId");

            migrationBuilder.CreateIndex(
                name: "IX_FightActionRow_StartingPositionId",
                schema: "main",
                table: "FightActionRow",
                column: "StartingPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_TransitionRow_FinalPositionId",
                schema: "main",
                table: "TransitionRow",
                column: "FinalPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_TransitionRow_InitialPositionId",
                schema: "main",
                table: "TransitionRow",
                column: "InitialPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_TransitionRow_PositionRowId",
                schema: "main",
                table: "TransitionRow",
                column: "PositionRowId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoRow_FightActionRowId",
                schema: "main",
                table: "VideoRow",
                column: "FightActionRowId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoRow_PositionRowId",
                schema: "main",
                table: "VideoRow",
                column: "PositionRowId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoRow_TransitionRowId",
                schema: "main",
                table: "VideoRow",
                column: "TransitionRowId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoRow",
                schema: "main");

            migrationBuilder.DropTable(
                name: "FightActionRow",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TransitionRow",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PositionRow",
                schema: "main");
        }
    }
}
