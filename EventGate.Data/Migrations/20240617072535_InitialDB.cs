using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventGate.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    EventTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
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
                    PresidentID = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    ReceiverID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.ChatID);
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_ReceiverID",
                        column: x => x.ReceiverID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "EventRules",
                schema: "dbo",
                columns: table => new
                {
                    RuleID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RuleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventTypeID = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    EventTypeID = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatHistories", x => x.ChatHistoryID);
                    table.ForeignKey(
                        name: "FK_ChatHistories_AspNetUsers_ReceiverID",
                        column: x => x.ReceiverID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_ChatHistories_Chats_ChatID",
                        column: x => x.ChatID,
                        principalSchema: "dbo",
                        principalTable: "Chats",
                        principalColumn: "ChatID");
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
                    AuthorID = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClubID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventClubID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventClubs", x => new { x.EventID, x.ClubID });
                    table.ForeignKey(
                        name: "FK_EventClubs_Clubs_ClubID",
                        column: x => x.ClubID,
                        principalSchema: "dbo",
                        principalTable: "Clubs",
                        principalColumn: "ClubID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventClubs_Events_EventID",
                        column: x => x.EventID,
                        principalSchema: "dbo",
                        principalTable: "Events",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Cascade);
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
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    EventTypeID = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserEventID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEvents", x => new { x.UserID, x.EventID });
                    table.ForeignKey(
                        name: "FK_UserEvents_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEvents_Events_EventID",
                        column: x => x.EventID,
                        principalSchema: "dbo",
                        principalTable: "Events",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Cascade);
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
                    EventID1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Vouchers_Events_EventID1",
                        column: x => x.EventID1,
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
                    UserHistoryID = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    TicketID1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_OrderDetails_Tickets_TicketID1",
                        column: x => x.TicketID1,
                        principalSchema: "dbo",
                        principalTable: "Tickets",
                        principalColumn: "TicketID");
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
                name: "IX_ChatHistories_UserId",
                schema: "dbo",
                table: "ChatHistories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ChatRoomID",
                schema: "dbo",
                table: "Chats",
                column: "ChatRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ReceiverID",
                schema: "dbo",
                table: "Chats",
                column: "ReceiverID");

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
                name: "IX_OrderDetails_TicketID1",
                schema: "dbo",
                table: "OrderDetails",
                column: "TicketID1");

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
                name: "IX_Vouchers_EventID1",
                schema: "dbo",
                table: "Vouchers",
                column: "EventID1");

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
