using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DrillRoad.Database.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "main");

            migrationBuilder.CreateTable(
                name: "AddressRow",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Apartment = table.Column<string>(type: "text", nullable: true),
                    Building = table.Column<string>(type: "text", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: false),
                    PostalCode = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressRow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    AdditionalUserInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PositionRow",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PositionType = table.Column<int>(type: "integer", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionRow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactRow",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactRow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactRow_AddressRow_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "main",
                        principalTable: "AddressRow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "main",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "main",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "main",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "main",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "main",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "main",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FightActionRow",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ActionType = table.Column<int>(type: "integer", nullable: false),
                    StartingPositionId = table.Column<Guid>(type: "uuid", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
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
                    InsertTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
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
                name: "AdditionalUserInfoRow",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PictureRepoPatch = table.Column<string>(type: "text", nullable: false),
                    ContactRowId = table.Column<Guid>(type: "uuid", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalUserInfoRow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalUserInfoRow_ContactRow_ContactRowId",
                        column: x => x.ContactRowId,
                        principalSchema: "main",
                        principalTable: "ContactRow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideoRow",
                schema: "main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    VideoRepoPatch = table.Column<string>(type: "text", nullable: false),
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
                name: "IX_AdditionalUserInfoRow_ContactRowId",
                schema: "main",
                table: "AdditionalUserInfoRow",
                column: "ContactRowId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "main",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "main",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "main",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "main",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "main",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "main",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "main",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactRow_AddressId",
                schema: "main",
                table: "ContactRow",
                column: "AddressId");

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
                name: "AdditionalUserInfoRow",
                schema: "main");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "main");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "main");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "main");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "main");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "main");

            migrationBuilder.DropTable(
                name: "VideoRow",
                schema: "main");

            migrationBuilder.DropTable(
                name: "ContactRow",
                schema: "main");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "main");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "main");

            migrationBuilder.DropTable(
                name: "FightActionRow",
                schema: "main");

            migrationBuilder.DropTable(
                name: "TransitionRow",
                schema: "main");

            migrationBuilder.DropTable(
                name: "AddressRow",
                schema: "main");

            migrationBuilder.DropTable(
                name: "PositionRow",
                schema: "main");
        }
    }
}
