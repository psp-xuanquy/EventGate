using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventGate.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchema : Migration
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
                    TicketDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QRCode = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PosterImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    SenderID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ReceiverID = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                        name: "FK_ChatHistories_AspNetUsers_ReceiverID",
                        column: x => x.ReceiverID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChatHistories_AspNetUsers_SenderID",
                        column: x => x.SenderID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QRCode = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    TicketQuantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PosterImage = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    QRCode = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
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
                    { "03287f27-2ad8-4f73-80b7-64d2812e0e48", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8292), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8294), 2, "A" },
                    { "04b2ede0-f4e9-44e8-90c2-f43a84bc16e3", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8452), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8455), 2, "C" },
                    { "0628d1a4-cbf5-4977-aa07-e6deac60488b", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8514), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8516), 2, "A" },
                    { "0ed693c5-9258-4360-b9ef-d14c4a4a3190", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8401), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8402), 6, "E" },
                    { "0f86b350-96ee-422c-bf66-d93524e1dde6", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8263), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8287), 1, "A" },
                    { "11ed7718-767c-4cdd-9c13-e9fec6c69367", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8552), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8553), 3, "C" },
                    { "1279b1ad-9c81-489d-83ed-c4c4bd6ddfd0", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8547), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8548), 1, "C" },
                    { "164100eb-45c7-47f1-9953-71bb8f1f70fa", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8349), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8350), 1, "C" },
                    { "179a407e-bf23-47d3-b32b-0e23019c63d9", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8479), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8480), 5, "D" },
                    { "19c0d2d9-011d-443e-8466-33c47778b9e5", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8495), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8496), 5, "E" },
                    { "1a4c57f4-1a24-40a4-a0b7-2a8f693a017f", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8587), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8588), 1, "E" },
                    { "1be9987f-5728-4f11-9d6c-2419505f28cc", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8374), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8376), 3, "D" },
                    { "1c1ec68a-d785-4141-bdc6-522f76d6968a", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8467), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8469), 1, "D" },
                    { "1fd6da40-161b-46ea-8456-1b7ce523c5ae", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8403), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8405), 1, "A" },
                    { "2348dab0-5b69-4db1-8547-2e12fb79604d", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8329), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8331), 3, "B" },
                    { "27594f0f-1fb2-40fe-aa60-73171bc7c36a", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8530), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8531), 1, "B" },
                    { "2973eca7-62e5-4c44-87ac-2a5b7af3ecbf", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8392), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8393), 3, "E" },
                    { "2acedb4d-1d47-4f30-9ac7-28a2b898af59", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8502), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8503), 1, "A" },
                    { "2bad08c8-7f25-4cc3-956c-d65bc5785b22", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8428), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8432), 6, "A" },
                    { "35cdbff0-54a2-480a-8c23-7308c09faab3", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8484), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8485), 1, "E" },
                    { "3e16b752-8f2c-430e-bc62-679b4c4e3f83", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8554), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8557), 4, "C" },
                    { "3ec81c30-6fca-4fba-ac6b-798875d22615", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8362), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8363), 5, "C" },
                    { "3ff41964-c40c-41b7-8319-f66975d593c5", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8541), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8542), 5, "B" },
                    { "46d515a3-a16b-4d70-92f4-f543904e47fe", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8377), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8378), 4, "D" },
                    { "478c7ed4-66d8-483c-bb74-5ac2da210951", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8461), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8462), 5, "C" },
                    { "4813c3e3-3d37-4791-a3f7-4e5b36eb7c6c", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8536), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8537), 3, "B" },
                    { "4e755093-94e7-42a6-839b-8fb23705ef3a", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8497), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8500), 6, "E" },
                    { "4f3b5593-daf4-4125-a363-f972b1d8a893", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8354), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8356), 3, "C" },
                    { "5d3fa2f0-a65b-444f-acc8-bb8441d86150", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8473), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8474), 3, "D" },
                    { "621d57fd-fb4b-4701-857a-4bfb9669cec7", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8295), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8297), 3, "A" },
                    { "630d5562-2111-48b7-b841-292351f5b177", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8519), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8522), 4, "A" },
                    { "683b0b22-1ef4-4d6d-8e06-8fe309ee8bd3", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8322), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8323), 1, "B" },
                    { "69d71b6a-faba-471b-822b-450511d9cb54", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8549), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8551), 2, "C" },
                    { "6c50e080-e590-4ba4-aae5-de040c4fb860", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8440), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8443), 4, "B" },
                    { "6dd2077e-6851-443b-a0cf-4a43eb8a9c14", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8564), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8565), 1, "D" },
                    { "6eab9c69-51a0-44fd-863d-416453825f07", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8600), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8601), 6, "E" },
                    { "6fb54c8c-1fcd-4668-8a3a-870f03b531ff", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8594), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8597), 4, "E" },
                    { "77d0798c-5435-4a0b-90ba-ce0cdd180e6b", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8414), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8415), 4, "A" },
                    { "7819a534-0d17-46d6-99dc-f4c443f06aa9", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8382), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8385), 6, "D" },
                    { "7bd22f90-2ef9-493d-b574-8ef2ba46cd38", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8572), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8574), 4, "D" },
                    { "7ecf704f-3db2-44e1-abe9-cffa2f1c46bd", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8492), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8494), 4, "E" },
                    { "80250c54-558f-43a9-922e-5d28bc29ae70", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8523), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8524), 5, "A" },
                    { "80bd34d3-695e-4792-b901-c589ff940ebb", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8335), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8336), 5, "B" },
                    { "8242b0e6-f490-40c4-806a-403589a868bc", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8368), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8369), 1, "D" },
                    { "82ea438f-0a3f-4356-bb75-339607c572e6", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8433), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8434), 1, "B" },
                    { "836c27aa-96e0-47c3-8e8a-f709a5fec9a1", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8456), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8457), 3, "C" },
                    { "8492fcce-8f11-4782-884b-4059c48643a9", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8570), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8571), 3, "D" },
                    { "87fd747a-78fb-4e09-86ca-adf264a50a08", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8379), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8381), 5, "D" },
                    { "8937b742-752f-4139-9832-10e2e7ebeb5b", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8589), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8590), 2, "E" },
                    { "8d6786a6-a0ca-44fe-94a4-048943aa4ce9", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8598), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8599), 5, "E" },
                    { "9247a79c-a28c-4d7d-b75b-a1fd16336801", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8538), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8539), 4, "B" },
                    { "93b6276b-899f-4d8a-aad8-7523a2ec8da8", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8315), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8316), 5, "A" },
                    { "9466d65c-fede-472d-b118-e5110f2693a3", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8517), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8518), 3, "A" },
                    { "959b7a97-5c6c-48c8-9379-e4262c7ce049", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8410), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8412), 3, "A" },
                    { "96c6c83f-617c-4755-ba2f-ceacf057e3fa", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8591), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8593), 3, "E" },
                    { "98650eab-ad18-4ca1-a8e2-f8591f5a33fd", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8406), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8409), 2, "A" },
                    { "9c1ee3a5-25dc-492f-9f2c-224bcc1e2976", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8470), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8471), 2, "D" },
                    { "a6a97c87-fff7-494f-9f3d-32b7bde4b621", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8463), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8466), 6, "C" },
                    { "a980eec3-4e95-49e4-b226-80a3de7edf1c", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8561), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8562), 6, "C" },
                    { "aae0aec7-6d93-451e-8c38-1edb65df2161", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8438), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8439), 3, "B" },
                    { "b208ad10-64bd-4435-b0ce-224bf30562e5", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8532), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8535), 2, "B" },
                    { "b3dcda7a-415c-4534-bacb-4eb870dcc0bc", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8365), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8366), 6, "C" },
                    { "b6337e20-e9f4-4c34-95a5-2c949bb7483f", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8481), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8482), 6, "D" },
                    { "bc0cae71-aece-4484-9098-238b60a04a17", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8486), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8489), 2, "E" },
                    { "be2137e8-f258-45d2-9aa7-0c4276eba605", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8527), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8528), 6, "A" },
                    { "bff87dfa-2b3a-4ed2-b831-34493bc95f40", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8490), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8491), 3, "E" },
                    { "bffbc21d-1ba0-48fa-a7a8-e3f0702a9936", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8398), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8399), 5, "E" },
                    { "c11d467e-0bbe-47d7-8aae-c4fc01251a22", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8458), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8459), 4, "C" },
                    { "c1388655-2bea-458a-8c9d-783eed406cfa", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8447), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8448), 6, "B" },
                    { "c18f9b7e-8691-4743-9265-059b2475ddbc", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8577), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8580), 6, "D" },
                    { "c576b31c-e1a8-4d86-99ad-2638045bfcaa", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8352), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8353), 2, "C" },
                    { "c867e90a-9ed8-41df-98c2-9cc2164bb373", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8298), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8313), 4, "A" },
                    { "cd219308-1370-4e3e-93c0-6cd63e70e463", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8566), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8569), 2, "D" },
                    { "cf0d1a4e-c586-464a-be36-e1b7cf973ebf", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8333), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8334), 4, "B" },
                    { "d18db6c4-2d9c-4257-b374-dcc1de9de31c", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8449), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8451), 1, "C" },
                    { "d3c0bdd7-802b-4756-81b1-3706446acc96", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8388), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8390), 2, "E" },
                    { "d6b8fe73-b00a-4ce6-b12d-3d972d2ae012", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8416), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8417), 5, "A" },
                    { "d787bc9f-300c-47d5-866e-f8fd5415740e", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8358), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8361), 4, "C" },
                    { "e060ad10-3fee-4a21-b362-e739bfa5fb54", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8435), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8436), 2, "B" },
                    { "e067e934-b06a-4829-9f0d-5b7f86aa1e40", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8394), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8397), 4, "E" },
                    { "e36ee5c6-30c2-45b0-8752-5287c717a1fd", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8543), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8546), 6, "B" },
                    { "e584c119-9f53-4c41-82b0-c065283fead8", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8386), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8387), 1, "E" },
                    { "e61dea7b-0acd-43fb-a27d-fb5e7dfeb5ae", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8444), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8446), 5, "B" },
                    { "e8c45f15-9ba6-4630-a67c-dba580c64307", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8344), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8347), 6, "B" },
                    { "eb99bb45-be3c-425e-82bb-817f59dd6225", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8324), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8328), 2, "B" },
                    { "edc6fa6d-b43a-447d-b230-bb0b8f49e69f", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8558), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8560), 5, "C" },
                    { "f0c74ee5-ac8f-4b4d-b176-f13c2beccc80", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8319), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8320), 6, "A" },
                    { "fa256b96-c123-4cda-a626-a148441ce1cd", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8370), null, null, "Alpha", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8373), 2, "D" },
                    { "fc841fc3-46d4-4a13-b3b3-dadd008f9ee8", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8575), null, null, "Ceasar", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8576), 5, "D" },
                    { "fdfc216b-589e-4002-9319-c234a1e2c640", "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8475), null, null, "Beta", true, "System", new DateTime(2024, 6, 28, 16, 16, 40, 932, DateTimeKind.Local).AddTicks(8478), 4, "D" }
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
                name: "IX_ChatHistories_ReceiverID",
                schema: "dbo",
                table: "ChatHistories",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatHistories_SenderID",
                schema: "dbo",
                table: "ChatHistories",
                column: "SenderID");

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
