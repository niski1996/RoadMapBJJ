using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrillRoad.Database.Migrations
{
    /// <inheritdoc />
    public partial class addRealRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdditionalUserInfoId",
                schema: "main",
                table: "AspNetUsers",
                newName: "AdditionalUserInfoIdId");

            migrationBuilder.AddColumn<Guid>(
                name: "AdditionalUserInfoRowId",
                schema: "main",
                table: "TransitionRow",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AdditionalUserInfoRowId",
                schema: "main",
                table: "PositionRow",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AdditionalUserInfoRowId",
                schema: "main",
                table: "FightActionRow",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransitionRow_AdditionalUserInfoRowId",
                schema: "main",
                table: "TransitionRow",
                column: "AdditionalUserInfoRowId");

            migrationBuilder.CreateIndex(
                name: "IX_PositionRow_AdditionalUserInfoRowId",
                schema: "main",
                table: "PositionRow",
                column: "AdditionalUserInfoRowId");

            migrationBuilder.CreateIndex(
                name: "IX_FightActionRow_AdditionalUserInfoRowId",
                schema: "main",
                table: "FightActionRow",
                column: "AdditionalUserInfoRowId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AdditionalUserInfoIdId",
                schema: "main",
                table: "AspNetUsers",
                column: "AdditionalUserInfoIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AdditionalUserInfoRow_AdditionalUserInfoIdId",
                schema: "main",
                table: "AspNetUsers",
                column: "AdditionalUserInfoIdId",
                principalSchema: "main",
                principalTable: "AdditionalUserInfoRow",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FightActionRow_AdditionalUserInfoRow_AdditionalUserInfoRowId",
                schema: "main",
                table: "FightActionRow",
                column: "AdditionalUserInfoRowId",
                principalSchema: "main",
                principalTable: "AdditionalUserInfoRow",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PositionRow_AdditionalUserInfoRow_AdditionalUserInfoRowId",
                schema: "main",
                table: "PositionRow",
                column: "AdditionalUserInfoRowId",
                principalSchema: "main",
                principalTable: "AdditionalUserInfoRow",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TransitionRow_AdditionalUserInfoRow_AdditionalUserInfoRowId",
                schema: "main",
                table: "TransitionRow",
                column: "AdditionalUserInfoRowId",
                principalSchema: "main",
                principalTable: "AdditionalUserInfoRow",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AdditionalUserInfoRow_AdditionalUserInfoIdId",
                schema: "main",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_FightActionRow_AdditionalUserInfoRow_AdditionalUserInfoRowId",
                schema: "main",
                table: "FightActionRow");

            migrationBuilder.DropForeignKey(
                name: "FK_PositionRow_AdditionalUserInfoRow_AdditionalUserInfoRowId",
                schema: "main",
                table: "PositionRow");

            migrationBuilder.DropForeignKey(
                name: "FK_TransitionRow_AdditionalUserInfoRow_AdditionalUserInfoRowId",
                schema: "main",
                table: "TransitionRow");

            migrationBuilder.DropIndex(
                name: "IX_TransitionRow_AdditionalUserInfoRowId",
                schema: "main",
                table: "TransitionRow");

            migrationBuilder.DropIndex(
                name: "IX_PositionRow_AdditionalUserInfoRowId",
                schema: "main",
                table: "PositionRow");

            migrationBuilder.DropIndex(
                name: "IX_FightActionRow_AdditionalUserInfoRowId",
                schema: "main",
                table: "FightActionRow");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AdditionalUserInfoIdId",
                schema: "main",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AdditionalUserInfoRowId",
                schema: "main",
                table: "TransitionRow");

            migrationBuilder.DropColumn(
                name: "AdditionalUserInfoRowId",
                schema: "main",
                table: "PositionRow");

            migrationBuilder.DropColumn(
                name: "AdditionalUserInfoRowId",
                schema: "main",
                table: "FightActionRow");

            migrationBuilder.RenameColumn(
                name: "AdditionalUserInfoIdId",
                schema: "main",
                table: "AspNetUsers",
                newName: "AdditionalUserInfoId");
        }
    }
}
