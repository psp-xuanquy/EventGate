using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventGate.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAbstractEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "Vouchers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "Vouchers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "Vouchers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "Vouchers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Vouchers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Vouchers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "UserHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "UserHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "UserHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "UserHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "UserHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "UserHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "UserEvents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "UserEvents",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "UserEvents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "UserEvents",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "UserEvents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "UserEvents",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "UserEventHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "UserEventHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "UserEventHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "UserEventHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "UserEventHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "UserEventHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "Seats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "Seats",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "Seats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "Seats",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Seats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Seats",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "Points",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "Points",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "Points",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "Points",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Points",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Points",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "PaymentsInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "PaymentsInfos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "PaymentsInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "PaymentsInfos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "PaymentsInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "PaymentsInfos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "OrderDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "OrderDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "OrderDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "EventTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "EventTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "EventTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "EventTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "EventTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "EventTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "Events",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "Events",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Events",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "EventRules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "EventRules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "EventRules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "EventRules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "EventRules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "EventRules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "EventHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "EventHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "EventHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "EventHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "EventHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "EventHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "EventFeedbacks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "EventFeedbacks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "EventFeedbacks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "EventFeedbacks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "EventFeedbacks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "EventFeedbacks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "EventClubs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "EventClubs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "EventClubs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "EventClubs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "EventClubs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "EventClubs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "Clubs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "Clubs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "Clubs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "Clubs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Clubs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Clubs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "Chats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "Chats",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "Chats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "Chats",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Chats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Chats",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "ChatRooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "ChatRooms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "ChatRooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "ChatRooms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "ChatRooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "ChatRooms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "ChatHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "ChatHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "ChatHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "ChatHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "ChatHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "ChatHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "dbo",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                schema: "dbo",
                table: "Blogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "dbo",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                schema: "dbo",
                table: "Blogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Blogs",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "Vouchers");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "Vouchers");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "Vouchers");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "Vouchers");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Vouchers");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Vouchers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "UserHistories");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "UserHistories");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "UserHistories");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "UserHistories");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "UserHistories");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "UserHistories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "UserEvents");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "UserEvents");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "UserEvents");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "UserEvents");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "UserEvents");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "UserEvents");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "UserEventHistories");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "UserEventHistories");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "UserEventHistories");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "UserEventHistories");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "UserEventHistories");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "UserEventHistories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "PaymentsInfos");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "PaymentsInfos");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "PaymentsInfos");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "PaymentsInfos");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "PaymentsInfos");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "PaymentsInfos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "EventTypes");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "EventTypes");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "EventTypes");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "EventTypes");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "EventTypes");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "EventTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "EventRules");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "EventRules");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "EventRules");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "EventRules");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "EventRules");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "EventRules");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "EventHistories");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "EventHistories");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "EventHistories");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "EventHistories");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "EventHistories");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "EventHistories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "EventFeedbacks");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "EventFeedbacks");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "EventFeedbacks");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "EventFeedbacks");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "EventFeedbacks");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "EventFeedbacks");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "EventClubs");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "EventClubs");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "EventClubs");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "EventClubs");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "EventClubs");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "EventClubs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "ChatRooms");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "ChatRooms");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "ChatRooms");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "ChatRooms");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "ChatRooms");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "ChatRooms");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "ChatHistories");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "ChatHistories");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "ChatHistories");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "ChatHistories");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "ChatHistories");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "ChatHistories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "dbo",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                schema: "dbo",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "dbo",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                schema: "dbo",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                schema: "dbo",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "LastUpdatedTime",
                schema: "dbo",
                table: "Blogs");
        }
    }
}
