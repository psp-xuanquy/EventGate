using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventGate.Migrations
{
    /// <inheritdoc />
    public partial class SecondUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gate",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "QRCode",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SponsorshipTypes");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdentityCard",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Seat",
                table: "Tickets",
                newName: "TicketName");

            migrationBuilder.RenameColumn(
                name: "ExpirationDate",
                table: "Tickets",
                newName: "TicketDate");

            migrationBuilder.RenameColumn(
                name: "AmountSponsored",
                table: "SponsorshipContributions",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "Website",
                table: "Sponsors",
                newName: "SponsorWebsite");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Sponsors",
                newName: "SponsorPhone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Sponsors",
                newName: "SponsorName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Sponsors",
                newName: "SponsorEmail");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Sponsors",
                newName: "SponsorAddress");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "OrderDetails",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "TypeEventName",
                table: "EventTypes",
                newName: "EventTypeName");

            migrationBuilder.RenameColumn(
                name: "RuleContent",
                table: "EventRules",
                newName: "RuleDescription");

            migrationBuilder.RenameColumn(
                name: "EventRuleID",
                table: "EventRules",
                newName: "RuleID");

            migrationBuilder.RenameColumn(
                name: "EventFeedbackID",
                table: "EventFeedbacks",
                newName: "FeedbackID");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "AspNetUsers",
                newName: "FullName");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPayments",
                table: "PaymentsInfos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "EventFeedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPayments",
                table: "PaymentsInfos");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "EventFeedbacks");

            migrationBuilder.RenameColumn(
                name: "TicketName",
                table: "Tickets",
                newName: "Seat");

            migrationBuilder.RenameColumn(
                name: "TicketDate",
                table: "Tickets",
                newName: "ExpirationDate");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "SponsorshipContributions",
                newName: "AmountSponsored");

            migrationBuilder.RenameColumn(
                name: "SponsorWebsite",
                table: "Sponsors",
                newName: "Website");

            migrationBuilder.RenameColumn(
                name: "SponsorPhone",
                table: "Sponsors",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "SponsorName",
                table: "Sponsors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SponsorEmail",
                table: "Sponsors",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "SponsorAddress",
                table: "Sponsors",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "OrderDetails",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "EventTypeName",
                table: "EventTypes",
                newName: "TypeEventName");

            migrationBuilder.RenameColumn(
                name: "RuleDescription",
                table: "EventRules",
                newName: "RuleContent");

            migrationBuilder.RenameColumn(
                name: "RuleID",
                table: "EventRules",
                newName: "EventRuleID");

            migrationBuilder.RenameColumn(
                name: "FeedbackID",
                table: "EventFeedbacks",
                newName: "EventFeedbackID");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "AspNetUsers",
                newName: "Phone");

            migrationBuilder.AddColumn<string>(
                name: "Gate",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QRCode",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SponsorshipTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityCard",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
