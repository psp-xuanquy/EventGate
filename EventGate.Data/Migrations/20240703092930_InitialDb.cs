using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventGate.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResetToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResetTokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VerificationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerificationTokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChatHistories",
                schema: "dbo",
                columns: table => new
                {
                    ChatHistoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchivedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChatID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChatRoomID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatHistories", x => x.ChatHistoryID);
                });

            migrationBuilder.CreateTable(
                name: "ChatRooms",
                schema: "dbo",
                columns: table => new
                {
                    ChatRoomID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatRooms", x => x.ChatRoomID);
                });

            migrationBuilder.CreateTable(
                name: "EventTypes",
                schema: "dbo",
                columns: table => new
                {
                    EventTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.EventTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                schema: "dbo",
                columns: table => new
                {
                    SeatID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Hall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Row = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.SeatID);
                });

            migrationBuilder.CreateTable(
                name: "UserEventHistories",
                schema: "dbo",
                columns: table => new
                {
                    UserEventHistoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserEventID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEventHistories", x => x.UserEventHistoryID);
                });

            migrationBuilder.CreateTable(
                name: "UserHistories",
                schema: "dbo",
                columns: table => new
                {
                    UserHistoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHistories", x => x.UserHistoryID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dbo",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "dbo",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dbo",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                schema: "dbo",
                columns: table => new
                {
                    ClubID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberQuantity = table.Column<int>(type: "int", nullable: true),
                    LogoClub = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresidentID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.ClubID);
                    table.ForeignKey(
                        name: "FK_Clubs_AspNetUsers_PresidentID",
                        column: x => x.PresidentID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "dbo",
                columns: table => new
                {
                    OrderID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Points",
                schema: "dbo",
                columns: table => new
                {
                    PointID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Points", x => x.PointID);
                    table.ForeignKey(
                        name: "FK_Points_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                schema: "dbo",
                columns: table => new
                {
                    ChatID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ChatRoomID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SenderID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.ChatID);
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_SenderID",
                        column: x => x.SenderID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chats_ChatRooms_ChatRoomID",
                        column: x => x.ChatRoomID,
                        principalSchema: "dbo",
                        principalTable: "ChatRooms",
                        principalColumn: "ChatRoomID");
                });

            migrationBuilder.CreateTable(
                name: "UserChatRooms",
                schema: "dbo",
                columns: table => new
                {
                    UserChatRoomID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChatRoomID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChatRooms", x => x.UserChatRoomID);
                    table.ForeignKey(
                        name: "FK_UserChatRooms_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserChatRooms_ChatRooms_ChatRoomID",
                        column: x => x.ChatRoomID,
                        principalSchema: "dbo",
                        principalTable: "ChatRooms",
                        principalColumn: "ChatRoomID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventHistories",
                schema: "dbo",
                columns: table => new
                {
                    EventHistoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    PosterImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    TicketQuantity = table.Column<int>(type: "int", nullable: false),
                    QRCode = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventTypeID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventHistories", x => x.EventHistoryID);
                    table.ForeignKey(
                        name: "FK_EventHistories_EventTypes_EventTypeID",
                        column: x => x.EventTypeID,
                        principalSchema: "dbo",
                        principalTable: "EventTypes",
                        principalColumn: "EventTypeID");
                });

            migrationBuilder.CreateTable(
                name: "EventRules",
                schema: "dbo",
                columns: table => new
                {
                    RuleID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RuleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventTypeID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRules", x => x.RuleID);
                    table.ForeignKey(
                        name: "FK_EventRules_EventTypes_EventTypeID",
                        column: x => x.EventTypeID,
                        principalSchema: "dbo",
                        principalTable: "EventTypes",
                        principalColumn: "EventTypeID");
                });

            migrationBuilder.CreateTable(
                name: "Events",
                schema: "dbo",
                columns: table => new
                {
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkStream = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    TicketQuantity = table.Column<int>(type: "int", nullable: false),
                    PosterImage = table.Column<byte[]>(type: "nvarchar(max)", nullable: true),
                    QRCode = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    EventTypeID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventID);
                    table.ForeignKey(
                        name: "FK_Events_EventTypes_EventTypeID",
                        column: x => x.EventTypeID,
                        principalSchema: "dbo",
                        principalTable: "EventTypes",
                        principalColumn: "EventTypeID");
                });

            migrationBuilder.CreateTable(
                name: "ChatReceivers",
                schema: "dbo",
                columns: table => new
                {
                    ChatReceiverID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChatID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReceiverID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatReceivers", x => x.ChatReceiverID);
                    table.ForeignKey(
                        name: "FK_ChatReceivers_AspNetUsers_ReceiverID",
                        column: x => x.ReceiverID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChatReceivers_Chats_ChatID",
                        column: x => x.ChatID,
                        principalSchema: "dbo",
                        principalTable: "Chats",
                        principalColumn: "ChatID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                schema: "dbo",
                columns: table => new
                {
                    BlogID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AuthorID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogID);
                    table.ForeignKey(
                        name: "FK_Blogs_AspNetUsers_AuthorID",
                        column: x => x.AuthorID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Blogs_Events_EventID",
                        column: x => x.EventID,
                        principalSchema: "dbo",
                        principalTable: "Events",
                        principalColumn: "EventID");
                });

            migrationBuilder.CreateTable(
                name: "EventClubs",
                schema: "dbo",
                columns: table => new
                {
                    EventClubID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ClubID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventClubs", x => x.EventClubID);
                    table.ForeignKey(
                        name: "FK_EventClubs_Clubs_ClubID",
                        column: x => x.ClubID,
                        principalSchema: "dbo",
                        principalTable: "Clubs",
                        principalColumn: "ClubID");
                    table.ForeignKey(
                        name: "FK_EventClubs_Events_EventID",
                        column: x => x.EventID,
                        principalSchema: "dbo",
                        principalTable: "Events",
                        principalColumn: "EventID");
                });

            migrationBuilder.CreateTable(
                name: "EventFeedbacks",
                schema: "dbo",
                columns: table => new
                {
                    FeedbackID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    SubmittedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventFeedbacks", x => x.FeedbackID);
                    table.ForeignKey(
                        name: "FK_EventFeedbacks_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EventFeedbacks_Events_EventID",
                        column: x => x.EventID,
                        principalSchema: "dbo",
                        principalTable: "Events",
                        principalColumn: "EventID");
                });

            migrationBuilder.CreateTable(
                name: "PaymentsInfos",
                schema: "dbo",
                columns: table => new
                {
                    PaymentsInfoID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccountHolderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPayments = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentsInfos", x => x.PaymentsInfoID);
                    table.ForeignKey(
                        name: "FK_PaymentsInfos_Events_EventID",
                        column: x => x.EventID,
                        principalSchema: "dbo",
                        principalTable: "Events",
                        principalColumn: "EventID");
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                schema: "dbo",
                columns: table => new
                {
                    TicketID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Gate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    QRCode = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SeatID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketID);
                    table.ForeignKey(
                        name: "FK_Tickets_Events_EventID",
                        column: x => x.EventID,
                        principalSchema: "dbo",
                        principalTable: "Events",
                        principalColumn: "EventID");
                    table.ForeignKey(
                        name: "FK_Tickets_Seats_SeatID",
                        column: x => x.SeatID,
                        principalSchema: "dbo",
                        principalTable: "Seats",
                        principalColumn: "SeatID");
                });

            migrationBuilder.CreateTable(
                name: "UserEvents",
                schema: "dbo",
                columns: table => new
                {
                    UserEventID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEvents", x => x.UserEventID);
                    table.ForeignKey(
                        name: "FK_UserEvents_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserEvents_Events_EventID",
                        column: x => x.EventID,
                        principalSchema: "dbo",
                        principalTable: "Events",
                        principalColumn: "EventID");
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                schema: "dbo",
                columns: table => new
                {
                    VoucherID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.VoucherID);
                    table.ForeignKey(
                        name: "FK_Vouchers_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vouchers_Events_EventID",
                        column: x => x.EventID,
                        principalSchema: "dbo",
                        principalTable: "Events",
                        principalColumn: "EventID");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                schema: "dbo",
                columns: table => new
                {
                    OrderDetailID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TicketID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalSchema: "dbo",
                        principalTable: "Orders",
                        principalColumn: "OrderID");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Tickets_TicketID",
                        column: x => x.TicketID,
                        principalSchema: "dbo",
                        principalTable: "Tickets",
                        principalColumn: "TicketID");
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Seats",
                columns: new[] { "SeatID", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Hall", "IsAvailable", "LastUpdatedBy", "LastUpdatedTime", "Number", "Row" },
                values: new object[,]
                {
                    { "01a139a8-dbb3-4eed-b57d-1b6c7833a370", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2847), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2848), 2, "B" },
                    { "01ccace4-5c2e-45d1-86b2-6dce77323de9", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2835), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2837), 5, "A" },
                    { "034c701d-75a1-46ce-850c-6c69b8c77be2", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2822), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2826), 2, "A" },
                    { "0814e3c4-41fe-4908-a65b-e338211536aa", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2844), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2845), 1, "B" },
                    { "08728612-24d9-4e8d-8c6d-d398221f7385", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2944), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2945), 3, "A" },
                    { "0c77e5e5-8c0e-4f27-b485-dcc7ad64f53a", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2808), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2811), 4, "E" },
                    { "12e7eef4-6820-4ba6-b568-05b69b24dd2a", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2898), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2899), 2, "D" },
                    { "1597b3e4-32c2-4608-9c46-80490aea53ed", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3017), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3020), 2, "D" },
                    { "16827578-3161-4f20-ab84-70eff39121d0", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2777), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2779), 1, "D" },
                    { "1c2f56ca-ad1d-457a-b4cc-dbf3f736e2cc", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2989), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2992), 6, "B" },
                    { "1c84565a-bbcb-48e6-8452-40edafd23f17", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2923), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2925), 3, "E" },
                    { "227e19c1-87f8-4b9d-9458-2b0c752ebe23", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2672), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2675), 2, "A" },
                    { "2547ee2d-2389-4f48-92d8-3c729e8cf249", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2869), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2871), 6, "B" },
                    { "25557cea-b631-4424-9c64-d23a7cb5393d", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2912), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2914), 6, "D" },
                    { "27d8d9e6-e37e-4e7d-ad01-ab35db7f8aa6", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2716), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2718), 6, "A" },
                    { "28149626-01e7-4b23-b42e-67ab2c52925c", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2677), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2679), 3, "A" },
                    { "2992647a-42e3-4218-898a-b9689c4a59f3", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2915), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2917), 1, "E" },
                    { "30df72f7-2bac-4ff5-bff5-88e499eb303c", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2895), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2896), 1, "D" },
                    { "31aa69dc-6ebf-4d1c-b155-668a59e9bcbb", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2828), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2829), 3, "A" },
                    { "32d412cf-feda-4422-ae4c-cfd4aaa67f57", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3042), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3043), 3, "E" },
                    { "358edcba-2897-46ba-bc4c-267631d816e9", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2929), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2931), 5, "E" },
                    { "37b3832b-1962-4476-831d-d6ab24f0b650", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2734), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2736), 4, "B" },
                    { "3b95456b-a10d-4d68-a55f-179edb08e76b", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2963), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2965), 5, "A" },
                    { "4163bb12-8287-4eec-af87-18e476896841", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2986), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2987), 5, "B" },
                    { "44914335-682b-49f8-9239-c684dc8809a3", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2866), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2868), 5, "B" },
                    { "4870a59d-f5bf-4345-a78a-db6a8bab4bfb", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2816), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2817), 6, "E" },
                    { "4b0f070d-c34c-4122-844d-27fa40029f39", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2974), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2978), 2, "B" },
                    { "4de15274-f556-460e-b77e-45fab3c7fdbd", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2890), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2893), 6, "C" },
                    { "4e46cbd7-1bb0-4dde-a51b-55b6acabeb69", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2932), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2936), 6, "E" },
                    { "5286e8be-b735-4458-a9bf-15f07db04cdb", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2723), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2728), 2, "B" },
                    { "54f030eb-4a3e-4b2f-b5fb-80deeda7b63d", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2720), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2721), 1, "B" },
                    { "578760e9-8d5a-4187-92e9-7b38086f6128", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2918), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2922), 2, "E" },
                    { "578dbfb9-7807-4099-8ae7-30c776e895b8", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3008), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3009), 5, "C" },
                    { "57ae6545-03af-440a-b293-3ca917ec6abf", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2785), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2787), 3, "D" },
                    { "5fbce7b5-9fc7-4fa3-94c7-c2335d29c6e5", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2880), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2882), 3, "C" },
                    { "5ffcdfd0-723b-450e-ba19-9743eabf4e46", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2765), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2768), 4, "C" },
                    { "61aed567-23c7-4358-a2b8-1182c2ad6606", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2729), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2731), 3, "B" },
                    { "61b105a8-f66f-4c6b-9294-984a6d2111e0", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2983), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2984), 4, "B" },
                    { "675ae974-4d96-4d62-80ef-951558665323", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2746), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2747), 1, "C" },
                    { "6ce4edc6-fdea-425e-bd57-ac5242fbe554", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3039), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3040), 2, "E" },
                    { "6d044b2e-6d51-4043-bf6e-1d2d3ed7bc04", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2904), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2907), 4, "D" },
                    { "6dc13f0d-3f10-4c84-9f74-c61e077488cc", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2749), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2751), 2, "C" },
                    { "6f11bd84-6b25-47ad-9c1f-0e8ebb44794f", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2788), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2790), 4, "D" },
                    { "75e7220c-ec9e-4f01-b69c-1292490f3cb3", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2887), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2888), 5, "C" },
                    { "78846fb5-25fa-4b26-8b40-40fb38117464", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2770), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2771), 5, "C" },
                    { "7c427c25-172d-4d5b-99dc-c4dd83fec920", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2968), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2969), 6, "A" },
                    { "7fe5f986-8a3a-4fe6-961d-2444d4de0317", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2805), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2807), 3, "E" },
                    { "802320d2-355b-4521-8421-9a632d34ce61", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2780), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2784), 2, "D" },
                    { "83aca24d-58c3-4c6e-ba73-01b93f3dcd6b", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2979), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2981), 3, "B" },
                    { "84312b5a-282f-40e8-8f5e-e96e225b414c", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2971), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2972), 1, "B" },
                    { "8458a961-86cc-4229-89b4-dfa5db48b51a", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3000), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3001), 3, "C" },
                    { "86fbff31-7713-490f-b248-dee1f7f9ab3c", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3058), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3060), 5, "E" },
                    { "893ee0ef-1cfa-4fb7-bbbc-2239454c716f", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3025), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3026), 4, "D" },
                    { "89aab939-c8db-4627-a8d0-98abae31c1e8", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2774), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2776), 6, "C" },
                    { "8b027fb7-466c-45c1-8f94-d5932962af28", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2737), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2739), 5, "B" },
                    { "8fb1779c-b90a-474e-92cf-1adfce4fccb1", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3003), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3006), 4, "C" },
                    { "9041c777-adb7-4e26-9060-4d44e9bac0e3", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2820), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2821), 1, "A" },
                    { "951dcd74-2ee0-41f5-92b3-3e4dc681f7c1", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2624), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2667), 1, "A" },
                    { "95a97aba-e2bb-4dd8-9bc0-a90d2523a98a", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2997), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2998), 2, "C" },
                    { "9d31c16a-7a97-4fab-9e87-b0136b8103e3", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2947), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2950), 4, "A" },
                    { "9d9f0a50-5d09-4c39-a43a-9b7bb0dfad9f", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2926), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2928), 4, "E" },
                    { "a49198d2-838a-4c83-bece-43452c8f0bb2", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3014), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3015), 1, "D" },
                    { "a4bddb63-186a-4a73-951a-0251cbd4f682", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2680), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2709), 4, "A" },
                    { "a75950cb-d2ef-47b4-8593-eacd6b6ff413", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3061), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3063), 6, "E" },
                    { "a88aa4c4-3bb3-4232-9a41-f4b4b0af23b6", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2861), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2865), 4, "B" },
                    { "a8cc8510-e15c-4ccb-bce3-d0d8c7d7f4f1", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2909), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2911), 5, "D" },
                    { "acb25c11-3758-4391-88b3-85a9284094c8", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2872), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2874), 1, "C" },
                    { "ad7b779d-54f1-4e77-9273-acf28cbf1f90", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2740), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2744), 6, "B" },
                    { "b1364073-8c4a-4e51-b91e-ae605cd68bc4", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2838), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2842), 6, "A" },
                    { "b3830564-bc2b-4105-b6da-ec55ddb9d258", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2799), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2801), 1, "E" },
                    { "b829614f-489e-4f58-9915-cc4389d771b3", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2791), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2793), 5, "D" },
                    { "ba89ac30-a588-4eb5-a0f2-3cbf11b88d84", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2875), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2879), 2, "C" },
                    { "c34ceca2-cd97-461f-9ecb-2ae37de4e27d", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3027), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3029), 5, "D" },
                    { "cc51dcf1-1b84-4617-9372-abc85add6013", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2813), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2814), 5, "E" },
                    { "cd649123-8e18-462b-b406-e603ee99453c", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3030), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3034), 6, "D" },
                    { "ce936687-9e89-49e3-8a8c-56457948d869", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3036), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3037), 1, "E" },
                    { "cf18398e-cbce-4cf9-aa89-3ebd3322707a", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2858), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2860), 3, "B" },
                    { "cf7e2580-484b-442f-a095-8c9b81941eb9", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2711), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2712), 5, "A" },
                    { "d0181013-d4d8-4c38-8585-10658e2794d0", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2794), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2798), 6, "D" },
                    { "d1c2bfeb-8a54-4e19-9bbb-6df06b22d87b", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3053), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3057), 4, "E" },
                    { "d7279cba-3c60-4d8a-bca7-5e67ec288cc0", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3022), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3023), 3, "D" },
                    { "d86722d0-4bfe-4b9f-96e1-4e2ceccaebb8", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2802), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2804), 2, "E" },
                    { "dc8f7078-44bd-460a-a045-1ea7115948b8", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2901), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2902), 3, "D" },
                    { "ddbf3111-8774-44f0-8aaa-309e1233e312", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2752), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2763), 3, "C" },
                    { "de4596c3-6bcf-461e-bf10-16c6e6a16e94", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2941), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2942), 2, "A" },
                    { "e00f18a3-4a71-45c2-b1c8-9bbb8b068974", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3011), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(3012), 6, "C" },
                    { "e4a13d6a-1893-458b-a496-6ae2a7052422", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2832), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2834), 4, "A" },
                    { "e50fb015-7682-4a0c-8a21-9fb5b93c99c8", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2938), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2939), 1, "A" },
                    { "fdb78e0b-5b9a-45f9-9c4a-fc6e972be3f3", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2884), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2885), 4, "C" },
                    { "fe2dbd42-d139-4571-b608-e5ce515cbfaa", "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2994), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 29, 30, 68, DateTimeKind.Local).AddTicks(2995), 1, "C" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "dbo",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "dbo",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "dbo",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "dbo",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "dbo",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "dbo",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "dbo",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuthorID",
                schema: "dbo",
                table: "Blogs",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_EventID",
                schema: "dbo",
                table: "Blogs",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatReceivers_ChatID",
                schema: "dbo",
                table: "ChatReceivers",
                column: "ChatID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatReceivers_ReceiverID",
                schema: "dbo",
                table: "ChatReceivers",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ChatRoomID",
                schema: "dbo",
                table: "Chats",
                column: "ChatRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_SenderID",
                schema: "dbo",
                table: "Chats",
                column: "SenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_PresidentID",
                schema: "dbo",
                table: "Clubs",
                column: "PresidentID");

            migrationBuilder.CreateIndex(
                name: "IX_EventClubs_ClubID",
                schema: "dbo",
                table: "EventClubs",
                column: "ClubID");

            migrationBuilder.CreateIndex(
                name: "IX_EventClubs_EventID",
                schema: "dbo",
                table: "EventClubs",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_EventFeedbacks_EventID",
                schema: "dbo",
                table: "EventFeedbacks",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_EventFeedbacks_UserID",
                schema: "dbo",
                table: "EventFeedbacks",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_EventHistories_EventTypeID",
                schema: "dbo",
                table: "EventHistories",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EventRules_EventTypeID",
                schema: "dbo",
                table: "EventRules",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTypeID",
                schema: "dbo",
                table: "Events",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                schema: "dbo",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_TicketID",
                schema: "dbo",
                table: "OrderDetails",
                column: "TicketID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                schema: "dbo",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentsInfos_EventID",
                schema: "dbo",
                table: "PaymentsInfos",
                column: "EventID",
                unique: true,
                filter: "[EventID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Points_UserID",
                schema: "dbo",
                table: "Points",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EventID",
                schema: "dbo",
                table: "Tickets",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SeatID",
                schema: "dbo",
                table: "Tickets",
                column: "SeatID");

            migrationBuilder.CreateIndex(
                name: "IX_UserChatRooms_ChatRoomID",
                schema: "dbo",
                table: "UserChatRooms",
                column: "ChatRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_UserChatRooms_UserID",
                schema: "dbo",
                table: "UserChatRooms",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_EventID",
                schema: "dbo",
                table: "UserEvents",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_UserID",
                schema: "dbo",
                table: "UserEvents",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Vouchers_EventID",
                schema: "dbo",
                table: "Vouchers",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_Vouchers_UserID",
                schema: "dbo",
                table: "Vouchers",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Blogs",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ChatHistories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ChatReceivers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "EventClubs",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "EventFeedbacks",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "EventHistories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "EventRules",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OrderDetails",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PaymentsInfos",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Points",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserChatRooms",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserEventHistories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserEvents",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserHistories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Vouchers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Chats",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Clubs",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Tickets",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ChatRooms",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Events",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Seats",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "EventTypes",
                schema: "dbo");
        }
    }
}
