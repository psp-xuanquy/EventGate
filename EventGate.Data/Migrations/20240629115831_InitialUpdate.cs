using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventGate.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialUpdate : Migration
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
                    table.PrimaryKey("PK_UserHistories", x => x.UserHistoryID);
                    table.ForeignKey(
                        name: "FK_UserHistories_AspNetUsers_UserID",
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
                    PosterImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
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
                name: "ChatHistories",
                schema: "dbo",
                columns: table => new
                {
                    ChatHistoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchivedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChatID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ChatRoomID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SenderID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_ChatHistories_AspNetUsers_SenderID",
                        column: x => x.SenderID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChatHistories_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChatHistories_ChatRooms_ChatRoomID",
                        column: x => x.ChatRoomID,
                        principalSchema: "dbo",
                        principalTable: "ChatRooms",
                        principalColumn: "ChatRoomID");
                    table.ForeignKey(
                        name: "FK_ChatHistories_Chats_ChatID",
                        column: x => x.ChatID,
                        principalSchema: "dbo",
                        principalTable: "Chats",
                        principalColumn: "ChatID");
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
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_EventHistories_Events_EventID",
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
                name: "UserEventHistories",
                schema: "dbo",
                columns: table => new
                {
                    UserEventHistoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventHistoryID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserHistoryID = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_UserEventHistories_EventHistories_EventHistoryID",
                        column: x => x.EventHistoryID,
                        principalSchema: "dbo",
                        principalTable: "EventHistories",
                        principalColumn: "EventHistoryID");
                    table.ForeignKey(
                        name: "FK_UserEventHistories_UserHistories_UserHistoryID",
                        column: x => x.UserHistoryID,
                        principalSchema: "dbo",
                        principalTable: "UserHistories",
                        principalColumn: "UserHistoryID");
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
                    { "07c2a7c3-167d-43ce-ae4f-04084148019d", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7369), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7370), 4, "A" },
                    { "0b512794-4e98-4bf2-b7ac-22d5aa4c856a", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7291), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7293), 1, "C" },
                    { "0bab52a5-3490-4d32-952f-f71e511ef5e4", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7547), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7550), 5, "D" },
                    { "0c47a725-9ad2-4596-82f1-b6e4e1694637", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7259), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7260), 5, "A" },
                    { "0cd0ee6c-855d-4c6a-a2a1-64fa32a33f76", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7358), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7361), 1, "A" },
                    { "0d542d66-608f-4d5c-a5d9-87b3569c8130", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7272), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7274), 2, "B" },
                    { "11b796b7-d7fd-4307-bff4-faccb41fa00a", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7527), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7528), 4, "C" },
                    { "15e9c2a9-1236-45bc-8d7a-b14274b61c01", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7440), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7441), 4, "D" },
                    { "18265294-4990-4645-8db4-f10ae207e8ad", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7484), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7486), 6, "A" },
                    { "198783df-c6f6-4036-b049-66cf9bb88cd4", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7435), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7438), 3, "D" },
                    { "1c51ad9b-43ba-4b62-bf33-83861ed888ad", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7339), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7340), 1, "E" },
                    { "1c5ba7b3-bc02-404b-b7e4-8f8e7f96cb94", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7517), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7518), 1, "C" },
                    { "1ca32687-09bf-4266-a347-d40069585180", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7312), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7315), 1, "D" },
                    { "1dc50203-742a-46a6-add9-7c4ad5db4675", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7514), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7515), 6, "B" },
                    { "1e329ea4-87e8-46fa-9f7f-d7850bc6553d", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7564), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7565), 4, "E" },
                    { "1efe51a5-27bc-4430-bb49-d2a1d0904a2b", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7477), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7479), 4, "A" },
                    { "209dbd61-32ec-43ed-a229-e846592a334b", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7432), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7434), 2, "D" },
                    { "259720de-cae9-430c-9dd0-99b08d32de6e", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7332), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7335), 5, "D" },
                    { "2a532458-ed20-4aea-837a-4eb7d6642f10", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7283), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7286), 5, "B" },
                    { "30f3cac2-360a-43bf-b995-97ef031edfbd", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7448), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7451), 1, "E" },
                    { "33936567-3c28-4859-b22b-9d5abe331331", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7305), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7307), 5, "C" },
                    { "373806de-9cd8-43c9-82c9-37a399426af0", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7402), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7403), 2, "C" },
                    { "38c378c1-9ada-4fd4-8161-e50151d5d7bc", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7380), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7381), 1, "B" },
                    { "3c369a13-4993-4e59-b90c-6484f37f82c6", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7389), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7391), 4, "B" },
                    { "41f999d7-73f0-424d-8d49-a7f914be47e2", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7522), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7525), 3, "C" },
                    { "42765655-85a7-43d6-82ec-cbbfc2588bc1", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7355), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7356), 6, "E" },
                    { "44353e77-e9da-46e6-a41b-5a0cd2c4386c", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7377), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7378), 6, "A" },
                    { "4572613d-7b57-43a6-8270-71b1fba947f8", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7316), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7318), 2, "D" },
                    { "46b94b13-3885-44c7-a62e-eb6c3909a25f", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7263), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7265), 6, "A" },
                    { "4901508d-0037-4853-9d83-2cb8721e003c", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7342), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7343), 2, "E" },
                    { "4d53209e-2745-4bf8-8ad7-af0fcb5a621e", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7554), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7555), 1, "E" },
                    { "4de1b650-0181-416a-8bf2-52ef2178f8bb", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7427), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7428), 6, "C" },
                    { "548c20b8-358e-4f8a-9f3c-720b397caa2e", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7534), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7538), 1, "D" },
                    { "5899c31f-10ca-4805-9b67-0b70acd34082", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7302), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7303), 4, "C" },
                    { "5d8f5e25-e04f-4ca9-94fc-9cea6bd06b7c", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7473), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7476), 3, "A" },
                    { "5f461ea8-f118-4407-ba05-034ade09d09c", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7569), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7570), 6, "E" },
                    { "5f6671ff-1bf3-4fa5-ac23-c46cd775eb72", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7422), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7425), 5, "C" },
                    { "5f69ea70-f395-449c-b302-416c117ff9c6", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7404), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7406), 3, "C" },
                    { "6147b8cf-3b5a-4a98-8726-0e46238b667f", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7557), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7558), 2, "E" },
                    { "62a23999-c728-4b5c-86a7-cb838d96f0af", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7559), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7562), 3, "E" },
                    { "6521f633-f1be-40bb-bf0d-3ad3a2cd2eca", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7255), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7257), 4, "A" },
                    { "6b343dc2-124b-4fe8-9485-4d8a1cf0312b", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7539), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7540), 2, "D" },
                    { "6ba12bac-b081-40e6-a1cf-93db6bc80a96", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7275), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7277), 3, "B" },
                    { "6c55ecf8-5f25-4069-acff-41a477fd54d4", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7394), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7396), 6, "B" },
                    { "75615485-1c6e-42ad-b15a-e10608895c02", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7504), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7506), 3, "B" },
                    { "76a2475d-f8e5-4db7-88ea-5bcfbdbfe28c", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7430), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7431), 1, "D" },
                    { "7c64dc88-5e78-4ec4-b802-8cb1b2788c71", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7352), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7353), 5, "E" },
                    { "8782c7b5-a980-44d5-a824-7cec6461d9d1", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7542), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7543), 3, "D" },
                    { "90b909f3-6850-4ff3-8c57-521ecb672de6", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7365), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7366), 3, "A" },
                    { "93161c0e-f633-4416-8b7c-8acb980e22b1", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7442), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7444), 5, "D" },
                    { "96a78324-427f-4923-8975-c5560d4bffaa", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7452), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7453), 2, "E" },
                    { "9bc5b737-28b5-45ca-926c-52ecaec18b01", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7385), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7388), 3, "B" },
                    { "9e748c79-5375-4ad5-ae44-4302e38f1979", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7445), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7446), 6, "D" },
                    { "9f434373-8bbf-46e7-982e-65068b5b4e52", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7362), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7363), 2, "A" },
                    { "a48c324a-9cf2-4a5a-8801-d08656f5575c", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7507), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7508), 4, "B" },
                    { "a59d73dc-edfc-42ca-958f-5339ae1182b1", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7267), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7271), 1, "B" },
                    { "a97fa834-a878-4e7f-b66a-01f46e2ceb21", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7551), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7553), 6, "D" },
                    { "adebc06e-b408-4966-9748-7b15159f835f", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7242), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7253), 3, "A" },
                    { "af8f400f-ccfb-4b8b-89d4-77ceb64391e6", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7288), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7290), 6, "B" },
                    { "b18ed097-42a7-430a-9495-04a83da0e1d7", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7544), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7546), 4, "D" },
                    { "b1b821be-0048-454b-9b4b-2aeffad4b688", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7345), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7348), 3, "E" },
                    { "b49fba07-f362-4c9f-b09a-94cccc99c7a3", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7465), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7466), 6, "E" },
                    { "b8da574d-6a03-4b57-8c94-87af4f1f2611", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7467), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7469), 1, "A" },
                    { "bb72ebeb-99fe-4109-8bec-1285d4d52314", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7470), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7471), 2, "A" },
                    { "bb81ff69-cc2f-47b6-8034-0ff7f5f83266", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7454), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7456), 3, "E" },
                    { "bd234dab-4f6e-4de1-ac59-10cf595d110e", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7519), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7521), 2, "C" },
                    { "c1881a4b-d90b-4339-ab01-f62d7f576b6f", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7319), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7328), 3, "D" },
                    { "c9e24e58-d666-4741-89b8-b650543402e2", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7297), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7301), 3, "C" },
                    { "ca01c6df-ad46-4500-b278-2f52d44a93ac", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7492), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7493), 2, "B" },
                    { "cbd1558a-48a0-4208-8efd-db2892bdf4c7", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7457), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7459), 4, "E" },
                    { "cde2edee-2a6f-4082-85db-4c10cd7d36cf", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7566), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7568), 5, "E" },
                    { "cf2d3a0c-ca50-4fe8-9541-b123613ba856", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7382), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7384), 2, "B" },
                    { "d2825613-15ef-461f-97ed-b3d676f17cbe", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7329), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7331), 4, "D" },
                    { "d4246a03-face-4f45-acf8-b3c5c9c0b24e", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7480), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7482), 5, "A" },
                    { "d5bc59a1-9449-4e99-9e92-a6ec0719053c", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7294), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7296), 2, "C" },
                    { "d70af112-5d2d-40b5-84f4-365c1a60a6a6", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7420), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7421), 4, "C" },
                    { "d8a9fcb3-960e-4759-ac01-9e925f7d0def", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7336), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7338), 6, "D" },
                    { "daa1ca9a-6cca-4268-8503-c2812ab4848a", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7510), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7513), 5, "B" },
                    { "dc862e62-14a2-4ef7-ab8e-c5ee0e1e1262", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7280), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7282), 4, "B" },
                    { "df1698c9-13b6-4270-852c-241b82c106ba", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7349), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7350), 4, "E" },
                    { "e3199cdf-d34b-4e35-9ac8-f2b51902cba6", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7532), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7533), 6, "C" },
                    { "eafde119-0717-4f6c-8e41-f1bb06381b1c", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7204), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7233), 1, "A" },
                    { "ed406954-a466-4ac4-9a74-c7702e62028d", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7372), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7375), 5, "A" },
                    { "ed9d51fa-395e-4c55-b7ce-b2703811f28f", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7309), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7311), 6, "C" },
                    { "efc0a10d-ac53-497f-a20b-2a8470fa9906", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7487), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7490), 1, "B" },
                    { "f1d43f28-b422-4db5-86b7-e393a15a240a", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7529), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7531), 5, "C" },
                    { "f924ffa7-28ac-4817-9201-fb3f18ddf2a4", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7238), null, null, "Alpha", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7239), 2, "A" },
                    { "f9693f5e-dc4a-4b8c-801c-09d24081e0a0", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7397), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7400), 1, "C" },
                    { "fb6d8904-85fe-4914-a3c8-646de5817894", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7460), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7463), 5, "E" },
                    { "fc49c9ca-1877-454d-9853-234e87fd11f0", "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7392), null, null, "Beta", true, "System", new DateTime(2024, 6, 29, 18, 58, 30, 776, DateTimeKind.Local).AddTicks(7393), 5, "B" }
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
                name: "IX_ChatHistories_ChatID",
                schema: "dbo",
                table: "ChatHistories",
                column: "ChatID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatHistories_ChatRoomID",
                schema: "dbo",
                table: "ChatHistories",
                column: "ChatRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatHistories_SenderID",
                schema: "dbo",
                table: "ChatHistories",
                column: "SenderID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatHistories_UserId",
                schema: "dbo",
                table: "ChatHistories",
                column: "UserId");

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
                name: "IX_EventHistories_EventID",
                schema: "dbo",
                table: "EventHistories",
                column: "EventID");

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
                name: "IX_UserEventHistories_EventHistoryID",
                schema: "dbo",
                table: "UserEventHistories",
                column: "EventHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventHistories_UserHistoryID",
                schema: "dbo",
                table: "UserEventHistories",
                column: "UserHistoryID");

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
                name: "IX_UserHistories_UserID",
                schema: "dbo",
                table: "UserHistories",
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
                name: "EventHistories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserHistories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ChatRooms",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Seats",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Events",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "EventTypes",
                schema: "dbo");
        }
    }
}
