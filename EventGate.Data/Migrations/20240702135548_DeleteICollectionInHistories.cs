using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventGate.Data.Migrations
{
    /// <inheritdoc />
    public partial class DeleteICollectionInHistories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatHistories_AspNetUsers_UserId",
                schema: "dbo",
                table: "ChatHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatHistories_Chats_ChatID",
                schema: "dbo",
                table: "ChatHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_EventHistories_Events_EventID",
                schema: "dbo",
                table: "EventHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHistories_AspNetUsers_UserID",
                schema: "dbo",
                table: "UserHistories");

            migrationBuilder.DropIndex(
                name: "IX_UserHistories_UserID",
                schema: "dbo",
                table: "UserHistories");

            migrationBuilder.DropIndex(
                name: "IX_EventHistories_EventID",
                schema: "dbo",
                table: "EventHistories");

            migrationBuilder.DropIndex(
                name: "IX_ChatHistories_ChatID",
                schema: "dbo",
                table: "ChatHistories");

            migrationBuilder.DropIndex(
                name: "IX_ChatHistories_UserId",
                schema: "dbo",
                table: "ChatHistories");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "02ac27e3-ae4f-412e-bec6-0a9f4c4724ee");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "11787294-b209-4557-ab6b-b402e3528e06");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1989e0a4-0bd2-4392-8bea-5e128757e664");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "235d9ed9-cd6f-45d3-a9eb-f2b03f5457ac");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "23aba1ff-3035-4268-b28e-bab963e41cf6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "245893d1-50c6-4c01-937a-12ce28a26188");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "252851b1-a43b-454c-a233-864f1b9fdb71");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "292d1cc8-113a-4a1a-bfe4-3a86cdd30340");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2c7c17b0-07a4-4cbc-a9ea-64ec6ce2b7d7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2d3242b3-fa7c-4b66-81b1-620582106d39");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2e107d86-6532-424c-8f05-b8a97ed257d9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "32522bc3-8199-488a-b963-3b5a67c4ee10");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "33337670-19a5-4c47-9097-08fed3d1b6a9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "33564315-86d5-4558-8e32-9b9a5c82738d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "35376ae6-59b3-45b5-b315-66b32f9dafb6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "385f648c-24a7-41cf-9b87-179d0e67e03e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "38e46d6a-f943-42d6-ba94-df481e2ca4ab");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3b269a76-5a98-4258-aebe-46ed585da65f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3c399ece-a869-4f7b-af68-44951e7bac39");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3d3b6e44-2faf-45a8-aaf2-8ddff5d3392e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3e911df5-d3a1-4e5f-ac6f-84cca33a6143");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "43129838-cc52-467d-a111-9387fb89b96f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "43912389-4150-41e4-b483-4191a6b9f21b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "44e1ff1b-e0d7-41c0-8142-a7bdd0a2c3fa");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4795d3a4-b59e-46c2-a297-6f282b3cb23b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "492ff2b7-3c3b-4116-8cac-c89bfd701eee");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4d8f504d-ec15-41ae-b646-f557943f8446");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5117fe2c-322e-45cc-b070-d320fa43f48e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5195b724-b7bf-4ca2-85e9-05d6db77a8a7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "52e8a698-8adc-47be-8138-9cae5982fc54");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5543e62e-5a53-4621-b256-7d29bfe7f519");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "56d86296-227b-40d2-970e-b98aecf83850");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5d68076a-7f06-48ef-a04f-7b333ca8d77f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5e3652a9-99de-45f0-a822-7a994146b8c3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5fa6ec5c-48ba-45c6-bbe3-98a995f1b5cb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "658135c3-b1f0-4387-81a6-2c3455291f18");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "697ddf72-5b63-4672-87aa-858ddbc239c7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6a443884-57a1-48de-99bd-e1b0f7c3fa22");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "706bf600-1e66-425e-adf0-f5bc18f9d259");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "70fdecc5-9a52-4399-a18f-0257f10d2dc7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7299553d-79bf-469f-b6e7-04df30ffc5b1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "72d7e823-5453-40b0-824d-783d0c942440");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "775fda64-28f9-4770-8e0e-5f05ac3396ff");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "77f5ee7d-319e-4fdc-9696-90994e3a2ab8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "80256020-2059-494b-a998-37f66a1d3669");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "855e43a4-0b7a-475f-a695-7628a24d68dc");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "897308ee-3ce6-4584-b104-dae2dd574e44");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "899d659e-2018-45f0-89a7-4befa488dde3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8bdfa791-c848-4fb2-a6aa-2be7afb4559c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8ce33dac-aade-40c8-b810-1440acdac11a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8e84ded3-6f27-49a3-9ec4-495b4e4eee95");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8fff47bd-3561-4657-96ab-24a3feb33c43");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "92a672f1-0f66-4c04-bda3-c0f515c1af67");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "95ba8ebb-c097-41b2-9da3-1e5007769b45");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9868a4a5-d7e5-414d-9dee-f89e3ace1fe2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9893bf6f-a712-4009-b279-271ff8ca8891");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "99fe54c8-b181-4049-8e79-6205ff86cec8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9a107bcc-803a-4921-b7b2-9a69226ae40a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9c01a5d1-fbd0-473f-9877-3156570849aa");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a2567bba-8828-47f4-8638-21eec1a6a938");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a6023649-5e20-47a4-895d-8603d2ddd473");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a6206b8a-eb8f-40cf-b2f6-63d2c10d9905");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a621271c-12e5-458d-817d-1888d06138f2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a9c3fe4e-f280-487d-ba6b-f36024def37d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "aad3c3ca-a6f9-48b5-a634-849762e6fe00");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b00382a4-35cf-4c8c-984c-a2a19d84ae3f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "babe38c6-a167-4e6e-b44c-d1dfd7d95ea3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c16e6479-3e09-4f6d-b23a-1874256c10db");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c1b82288-8db0-49be-90f4-7a7982660990");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c61f48cb-d086-46f3-a531-977abe297c04");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c911dc7c-52eb-40ab-9c57-5769f6e647d7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c96ba4e5-d3ad-42b5-a75a-a93c80142643");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ca0bd3b4-22ba-4877-ada9-cf9730a180b4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ca5ea23a-ee0a-4f1f-9db5-27d6650209d3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cc2920b0-cccb-4e60-8834-d54a8e14bfa9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d001eeb7-a9ea-403e-8ae6-16d067eebe0a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d6c62ac0-4477-4025-9df8-816cf7a001b9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "db948809-adc9-4dcf-b15f-4e9ce957bc57");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e3194977-6215-4054-9f53-446f5fad3217");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e462f9cb-744d-4240-96e4-83cee643f2f0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e7aea8f6-37e5-4e6a-b9eb-13af1a9c4b1b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e9f49e97-a71f-4ce6-9c09-9d9fcd7aa582");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "eb5ada3a-9c14-4682-9279-3316f811c4d8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f09f216d-7790-49ea-af40-6aff889462f5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f3bf480c-cd9f-4b39-aaa6-c3c884ca0259");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f4549727-4a4d-4656-94ab-2ed18f78fa63");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fa92a2ec-621f-45cd-82cf-742296bc923f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fba9eb11-400c-4afa-9082-894250c7c97e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fc78adfc-9103-4256-b4e8-4f5295d51f6d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fdddf26f-f943-4b49-85c0-4210ff47d45f");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "dbo",
                table: "ChatHistories");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                schema: "dbo",
                table: "UserHistories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EventID",
                schema: "dbo",
                table: "EventHistories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ChatID",
                schema: "dbo",
                table: "ChatHistories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Seats",
                columns: new[] { "SeatID", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Hall", "IsAvailable", "LastUpdatedBy", "LastUpdatedTime", "Number", "Row" },
                values: new object[,]
                {
                    { "0275f2df-d290-427a-9690-2aa8bf85389b", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1735), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1737), 6, "A" },
                    { "02931151-9247-45f3-8a12-453d03e5d4ff", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1552), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1553), 1, "C" },
                    { "03c555ec-1cc3-421f-a2b9-973cb7117d62", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1547), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1550), 6, "B" },
                    { "058ef2e1-7354-44a3-abde-eaffabbdaf43", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1526), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1527), 6, "A" },
                    { "06772198-a7fb-4263-80b1-36003b7fbfeb", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1751), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1752), 5, "B" },
                    { "08df2cbb-26b7-4962-ab0e-2b474b4df380", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1804), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1805), 2, "E" },
                    { "0aacf986-fa06-4e73-9cfa-72f751e7ce41", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1544), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1546), 5, "B" },
                    { "0bb35081-4d30-4e75-a78c-b8ca274bd3b4", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1706), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1708), 3, "E" },
                    { "0f1320e5-083d-4316-95e9-528187044a58", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1594), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1595), 2, "E" },
                    { "11b703e9-5dd7-40ae-b693-bb9637e34f18", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1579), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1580), 3, "D" },
                    { "147e0b2d-5c23-4422-81ba-a461b26a61bb", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1664), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1666), 4, "C" },
                    { "1582a39c-4fa4-4aa2-9c8d-f40e56736f5a", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1599), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1602), 4, "E" },
                    { "184768e1-901c-4774-8721-a832401c83af", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1644), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1647), 4, "B" },
                    { "1e7bde05-16fe-49d5-b465-11999cfdb0a3", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1727), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1730), 4, "A" },
                    { "2049d974-9b92-403c-bce8-34709e903fdb", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1722), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1723), 2, "A" },
                    { "23f6684e-01ba-40f9-83e3-41a33ebd01fa", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1648), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1650), 5, "B" },
                    { "29bdc547-f157-47fe-ba09-04cd0dfbc613", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1557), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1558), 3, "C" },
                    { "2d758b46-d8dd-43e2-9cf2-10d4de5dbf2c", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1626), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1627), 4, "A" },
                    { "2f90821d-10c3-4ad7-97e1-10695fe96fd7", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1631), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1635), 6, "A" },
                    { "322c5822-6a0d-4726-b445-5171a394b7fd", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1764), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1765), 3, "C" },
                    { "3253ae07-a18c-4196-be3e-cd6d5601b489", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1591), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1593), 1, "E" },
                    { "36e13b0a-7d3d-4ce3-97d0-66a1ce85091f", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1689), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1696), 6, "D" },
                    { "3b163cfc-b429-4515-a812-19d0df8bbc53", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1741), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1744), 2, "B" },
                    { "3b2a7367-cb5f-40f6-86a3-9b277f020f03", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1568), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1570), 6, "C" },
                    { "447b15fd-b822-4b9d-8a23-602c36c7faa2", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1587), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1590), 6, "D" },
                    { "48e35db9-2dfb-4cc7-aa69-31cccc68db30", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1789), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1790), 3, "D" },
                    { "4b6b68ac-8997-43eb-b347-4461671c1283", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1807), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1808), 3, "E" },
                    { "4dbe91dc-f608-47eb-8742-636a98793c63", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1651), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1653), 6, "B" },
                    { "51cb1566-b164-4649-bd92-680c8cafdd6d", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1639), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1640), 2, "B" },
                    { "53f8734a-0d68-4278-b83c-88d2bf37fc7f", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1701), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1705), 2, "E" },
                    { "59fb5cd8-167e-4c17-aecd-4fd388855730", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1680), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1681), 3, "D" },
                    { "5c5899ec-c69f-43e5-ae49-463693761a4c", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1809), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1813), 4, "E" },
                    { "5d54a3e0-bd55-418f-beb8-42d52f284c55", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1623), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1624), 3, "A" },
                    { "5d615d65-2b21-4097-a2cf-d62ce297a71e", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1636), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1637), 1, "B" },
                    { "64159dbd-24d9-402f-bccb-209c9af3e445", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1618), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1621), 2, "A" },
                    { "64ec255e-a77f-4715-a2c3-563317635044", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1514), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1523), 5, "A" },
                    { "683d67f6-1651-4984-8049-07d330c92bd9", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1667), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1669), 5, "C" },
                    { "68ca4cf4-fe8b-4ae2-8f2d-751f55971d84", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1714), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1717), 6, "E" },
                    { "6d147a60-3564-424f-93e2-a15ec80ad488", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1797), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1800), 6, "D" },
                    { "6ea6f8b8-6a3e-450c-a225-f82ca4c7f8e8", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1771), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1778), 5, "C" },
                    { "6fdc82f9-4cef-414a-8bc2-8271e315a953", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1709), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1710), 4, "E" },
                    { "712a42be-da83-42c9-ab00-e0175f6df09b", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1629), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1630), 5, "A" },
                    { "732fcd28-ecf8-4619-a559-84d39bc5f6d3", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1724), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1725), 3, "A" },
                    { "77aa5f5a-3aa0-4890-8dc0-910b4303297f", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1731), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1733), 5, "A" },
                    { "782431a0-d756-42d0-a515-6eba4ddc9f68", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1502), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1513), 4, "A" },
                    { "7d0ca39f-09f6-443c-b2b2-eb33ee09ec4c", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1754), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1757), 6, "B" },
                    { "82f13d98-5014-4d9b-b291-d588ecc46642", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1612), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1613), 6, "E" },
                    { "84654c69-9c18-466a-bded-c73135409d62", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1816), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1818), 6, "E" },
                    { "85ac56a1-ff15-49eb-adce-c06d16da29d3", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1759), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1760), 1, "C" },
                    { "864eb547-ec5e-4b72-8713-ce0d9126ae69", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1554), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1556), 2, "C" },
                    { "870ee244-e5f5-4f4b-8bb7-b53b2a1d250f", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1782), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1783), 1, "D" },
                    { "8827023a-7dfe-4872-8b14-84db88b6f395", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1532), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1536), 2, "B" },
                    { "9289fcd2-476f-4401-b8f5-2a3e03378d60", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1584), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1585), 5, "D" },
                    { "95335a50-4112-4c5d-be87-8006bd9c1ff7", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1794), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1796), 5, "D" },
                    { "954f4cee-52ba-40e4-a2c5-0d8d33511e2a", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1674), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1676), 1, "D" },
                    { "969813f6-bcb7-4683-bbda-2b99f7642d2a", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1784), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1788), 2, "D" },
                    { "9e2a1942-8759-46ac-b3c8-b8464cb95d37", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1662), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1663), 3, "C" },
                    { "9f2094e5-8c45-4fc6-8fbb-53569303baef", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1779), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1780), 6, "C" },
                    { "9fdd0ca8-d271-4296-87a9-477041b86c97", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1657), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1660), 2, "C" },
                    { "a2f93ff8-cb59-4ba6-9831-b270cedabe11", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1495), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1497), 2, "A" },
                    { "a79eaab5-a7bd-4990-a98a-a32f4736ee3d", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1537), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1539), 3, "B" },
                    { "a968b0ff-af12-48af-a3b9-df240a6910ca", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1738), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1740), 1, "B" },
                    { "aaf910e3-51a5-408e-9ff2-f3458739c7d9", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1574), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1577), 2, "D" },
                    { "adb887a5-91a8-422b-a633-73e4bd6ba16a", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1719), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1720), 1, "A" },
                    { "b07bdfcb-c222-4208-b874-720d1019adb4", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1564), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1565), 5, "C" },
                    { "b46bd294-ad7e-4619-ab86-e9081f1bc35d", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1748), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1749), 4, "B" },
                    { "b8c1d3bb-64df-495e-b3fd-7aa52f57af8a", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1687), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1688), 5, "D" },
                    { "ba17e7ce-71f8-410f-8416-09d2bd15c33a", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1792), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1793), 4, "D" },
                    { "ba5cfbc1-5533-42a5-936d-937311170086", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1802), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1803), 1, "E" },
                    { "be061363-12b1-4097-aba2-f232007afd72", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1641), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1643), 3, "B" },
                    { "bef3a3dc-15a2-4565-93f2-5159f2b6a757", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1572), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1573), 1, "D" },
                    { "c0ee9ea8-0798-46ad-98c3-b2516fc073a7", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1529), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1530), 1, "B" },
                    { "c7bbe68e-c8b8-48d4-926e-3d4d9b823b15", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1581), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1583), 4, "D" },
                    { "cc8867e2-3839-40af-a860-cbd39dcc707d", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1542), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1543), 4, "B" },
                    { "d0093d62-0b52-4504-80dd-bbec3cbaeb93", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1463), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1491), 1, "A" },
                    { "d3ae904c-f2d5-4ac5-b0a8-291778259fbf", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1698), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1699), 1, "E" },
                    { "d6a3a9d2-64ed-4843-bc63-e9bd872f31e9", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1654), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1656), 1, "C" },
                    { "d8d60bc7-befb-49a5-a702-1bf6f0f25700", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1711), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1713), 5, "E" },
                    { "dce81917-26f3-4c12-ab0f-f6aba1d43877", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1499), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1500), 3, "A" },
                    { "dd23a3b9-6307-4778-8ed7-561c1e94bb2d", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1670), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1673), 6, "C" },
                    { "dd928a8d-f29a-4ace-8c33-4e2da8f3b5fd", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1767), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1770), 4, "C" },
                    { "e10ea757-1a09-404d-bca5-65095e4d5aa0", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1677), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1678), 2, "D" },
                    { "e1de4dfa-4a27-4084-89f8-9b12532a7197", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1814), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1815), 5, "E" },
                    { "e6e4a897-d649-4f58-a911-0997dc675131", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1761), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1763), 2, "C" },
                    { "e8af5f40-19da-461a-8f27-3c41caad6a57", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1682), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1686), 4, "D" },
                    { "efcd4064-8fb6-4b04-9530-0ec467ce32f2", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1745), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1747), 3, "B" },
                    { "f2235e23-f2c5-4107-8e4f-233083fc6e0e", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1596), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1598), 3, "E" },
                    { "f2f4f578-b39f-4db3-b07d-490c5bd7db84", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1559), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1563), 4, "C" },
                    { "fef7ce75-8d7e-48d0-80f4-1fe892d53e04", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1603), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1605), 5, "E" },
                    { "ffd3a3cf-8744-4453-a634-e3325e20427b", "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1615), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 20, 55, 45, 772, DateTimeKind.Local).AddTicks(1617), 1, "A" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0275f2df-d290-427a-9690-2aa8bf85389b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "02931151-9247-45f3-8a12-453d03e5d4ff");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "03c555ec-1cc3-421f-a2b9-973cb7117d62");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "058ef2e1-7354-44a3-abde-eaffabbdaf43");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "06772198-a7fb-4263-80b1-36003b7fbfeb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "08df2cbb-26b7-4962-ab0e-2b474b4df380");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0aacf986-fa06-4e73-9cfa-72f751e7ce41");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0bb35081-4d30-4e75-a78c-b8ca274bd3b4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0f1320e5-083d-4316-95e9-528187044a58");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "11b703e9-5dd7-40ae-b693-bb9637e34f18");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "147e0b2d-5c23-4422-81ba-a461b26a61bb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1582a39c-4fa4-4aa2-9c8d-f40e56736f5a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "184768e1-901c-4774-8721-a832401c83af");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1e7bde05-16fe-49d5-b465-11999cfdb0a3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2049d974-9b92-403c-bce8-34709e903fdb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "23f6684e-01ba-40f9-83e3-41a33ebd01fa");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "29bdc547-f157-47fe-ba09-04cd0dfbc613");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2d758b46-d8dd-43e2-9cf2-10d4de5dbf2c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2f90821d-10c3-4ad7-97e1-10695fe96fd7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "322c5822-6a0d-4726-b445-5171a394b7fd");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3253ae07-a18c-4196-be3e-cd6d5601b489");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "36e13b0a-7d3d-4ce3-97d0-66a1ce85091f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3b163cfc-b429-4515-a812-19d0df8bbc53");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3b2a7367-cb5f-40f6-86a3-9b277f020f03");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "447b15fd-b822-4b9d-8a23-602c36c7faa2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "48e35db9-2dfb-4cc7-aa69-31cccc68db30");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4b6b68ac-8997-43eb-b347-4461671c1283");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4dbe91dc-f608-47eb-8742-636a98793c63");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "51cb1566-b164-4649-bd92-680c8cafdd6d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "53f8734a-0d68-4278-b83c-88d2bf37fc7f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "59fb5cd8-167e-4c17-aecd-4fd388855730");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5c5899ec-c69f-43e5-ae49-463693761a4c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5d54a3e0-bd55-418f-beb8-42d52f284c55");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5d615d65-2b21-4097-a2cf-d62ce297a71e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "64159dbd-24d9-402f-bccb-209c9af3e445");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "64ec255e-a77f-4715-a2c3-563317635044");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "683d67f6-1651-4984-8049-07d330c92bd9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "68ca4cf4-fe8b-4ae2-8f2d-751f55971d84");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6d147a60-3564-424f-93e2-a15ec80ad488");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6ea6f8b8-6a3e-450c-a225-f82ca4c7f8e8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6fdc82f9-4cef-414a-8bc2-8271e315a953");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "712a42be-da83-42c9-ab00-e0175f6df09b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "732fcd28-ecf8-4619-a559-84d39bc5f6d3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "77aa5f5a-3aa0-4890-8dc0-910b4303297f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "782431a0-d756-42d0-a515-6eba4ddc9f68");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7d0ca39f-09f6-443c-b2b2-eb33ee09ec4c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "82f13d98-5014-4d9b-b291-d588ecc46642");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "84654c69-9c18-466a-bded-c73135409d62");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "85ac56a1-ff15-49eb-adce-c06d16da29d3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "864eb547-ec5e-4b72-8713-ce0d9126ae69");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "870ee244-e5f5-4f4b-8bb7-b53b2a1d250f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8827023a-7dfe-4872-8b14-84db88b6f395");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9289fcd2-476f-4401-b8f5-2a3e03378d60");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "95335a50-4112-4c5d-be87-8006bd9c1ff7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "954f4cee-52ba-40e4-a2c5-0d8d33511e2a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "969813f6-bcb7-4683-bbda-2b99f7642d2a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9e2a1942-8759-46ac-b3c8-b8464cb95d37");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9f2094e5-8c45-4fc6-8fbb-53569303baef");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9fdd0ca8-d271-4296-87a9-477041b86c97");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a2f93ff8-cb59-4ba6-9831-b270cedabe11");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a79eaab5-a7bd-4990-a98a-a32f4736ee3d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a968b0ff-af12-48af-a3b9-df240a6910ca");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "aaf910e3-51a5-408e-9ff2-f3458739c7d9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "adb887a5-91a8-422b-a633-73e4bd6ba16a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b07bdfcb-c222-4208-b874-720d1019adb4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b46bd294-ad7e-4619-ab86-e9081f1bc35d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b8c1d3bb-64df-495e-b3fd-7aa52f57af8a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ba17e7ce-71f8-410f-8416-09d2bd15c33a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ba5cfbc1-5533-42a5-936d-937311170086");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "be061363-12b1-4097-aba2-f232007afd72");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "bef3a3dc-15a2-4565-93f2-5159f2b6a757");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c0ee9ea8-0798-46ad-98c3-b2516fc073a7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c7bbe68e-c8b8-48d4-926e-3d4d9b823b15");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cc8867e2-3839-40af-a860-cbd39dcc707d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d0093d62-0b52-4504-80dd-bbec3cbaeb93");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d3ae904c-f2d5-4ac5-b0a8-291778259fbf");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d6a3a9d2-64ed-4843-bc63-e9bd872f31e9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d8d60bc7-befb-49a5-a702-1bf6f0f25700");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "dce81917-26f3-4c12-ab0f-f6aba1d43877");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "dd23a3b9-6307-4778-8ed7-561c1e94bb2d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "dd928a8d-f29a-4ace-8c33-4e2da8f3b5fd");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e10ea757-1a09-404d-bca5-65095e4d5aa0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e1de4dfa-4a27-4084-89f8-9b12532a7197");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e6e4a897-d649-4f58-a911-0997dc675131");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e8af5f40-19da-461a-8f27-3c41caad6a57");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "efcd4064-8fb6-4b04-9530-0ec467ce32f2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f2235e23-f2c5-4107-8e4f-233083fc6e0e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f2f4f578-b39f-4db3-b07d-490c5bd7db84");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fef7ce75-8d7e-48d0-80f4-1fe892d53e04");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ffd3a3cf-8744-4453-a634-e3325e20427b");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                schema: "dbo",
                table: "UserHistories",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EventID",
                schema: "dbo",
                table: "EventHistories",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ChatID",
                schema: "dbo",
                table: "ChatHistories",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                schema: "dbo",
                table: "ChatHistories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Seats",
                columns: new[] { "SeatID", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Hall", "IsAvailable", "LastUpdatedBy", "LastUpdatedTime", "Number", "Row" },
                values: new object[,]
                {
                    { "02ac27e3-ae4f-412e-bec6-0a9f4c4724ee", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(254), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(256), 3, "B" },
                    { "11787294-b209-4557-ab6b-b402e3528e06", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(465), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(466), 3, "E" },
                    { "1989e0a4-0bd2-4392-8bea-5e128757e664", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(483), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(485), 2, "A" },
                    { "235d9ed9-cd6f-45d3-a9eb-f2b03f5457ac", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(214), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(216), 2, "A" },
                    { "23aba1ff-3035-4268-b28e-bab963e41cf6", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(348), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(349), 5, "E" },
                    { "245893d1-50c6-4c01-937a-12ce28a26188", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(372), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(373), 5, "A" },
                    { "252851b1-a43b-454c-a233-864f1b9fdb71", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(251), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(253), 2, "B" },
                    { "292d1cc8-113a-4a1a-bfe4-3a86cdd30340", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(486), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(488), 3, "A" },
                    { "2c7c17b0-07a4-4cbc-a9ea-64ec6ce2b7d7", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(446), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(447), 4, "D" },
                    { "2d3242b3-fa7c-4b66-81b1-620582106d39", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(569), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(570), 5, "D" },
                    { "2e107d86-6532-424c-8f05-b8a97ed257d9", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(452), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(454), 6, "D" },
                    { "32522bc3-8199-488a-b963-3b5a67c4ee10", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(332), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(334), 1, "E" },
                    { "33337670-19a5-4c47-9097-08fed3d1b6a9", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(388), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(396), 3, "B" },
                    { "33564315-86d5-4558-8e32-9b9a5c82738d", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(477), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(478), 6, "E" },
                    { "35376ae6-59b3-45b5-b315-66b32f9dafb6", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(259), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(262), 4, "B" },
                    { "385f648c-24a7-41cf-9b87-179d0e67e03e", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(368), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(370), 4, "A" },
                    { "38e46d6a-f943-42d6-ba94-df481e2ca4ab", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(299), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(300), 5, "C" },
                    { "3b269a76-5a98-4258-aebe-46ed585da65f", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(577), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(579), 1, "E" },
                    { "3c399ece-a869-4f7b-af68-44951e7bac39", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(364), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(365), 3, "A" },
                    { "3d3b6e44-2faf-45a8-aaf2-8ddff5d3392e", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(355), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(357), 1, "A" },
                    { "3e911df5-d3a1-4e5f-ac6f-84cca33a6143", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(304), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(306), 6, "C" },
                    { "43129838-cc52-467d-a111-9387fb89b96f", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(173), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(206), 1, "A" },
                    { "43912389-4150-41e4-b483-4191a6b9f21b", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(384), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(386), 2, "B" },
                    { "44e1ff1b-e0d7-41c0-8142-a7bdd0a2c3fa", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(344), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(346), 4, "E" },
                    { "4795d3a4-b59e-46c2-a297-6f282b3cb23b", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(323), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(325), 5, "D" },
                    { "492ff2b7-3c3b-4116-8cac-c89bfd701eee", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(234), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(236), 5, "A" },
                    { "4d8f504d-ec15-41ae-b646-f557943f8446", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(574), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(576), 6, "D" },
                    { "5117fe2c-322e-45cc-b070-d320fa43f48e", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(449), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(451), 5, "D" },
                    { "5195b724-b7bf-4ca2-85e9-05d6db77a8a7", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(598), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(600), 5, "E" },
                    { "52e8a698-8adc-47be-8138-9cae5982fc54", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(529), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(530), 6, "B" },
                    { "5543e62e-5a53-4621-b256-7d29bfe7f519", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(580), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(582), 2, "E" },
                    { "56d86296-227b-40d2-970e-b98aecf83850", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(589), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(591), 4, "E" },
                    { "5d68076a-7f06-48ef-a04f-7b333ca8d77f", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(508), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(510), 1, "B" },
                    { "5e3652a9-99de-45f0-a822-7a994146b8c3", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(269), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(271), 6, "B" },
                    { "5fa6ec5c-48ba-45c6-bbe3-98a995f1b5cb", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(550), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(552), 6, "C" },
                    { "658135c3-b1f0-4387-81a6-2c3455291f18", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(456), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(457), 1, "E" },
                    { "697ddf72-5b63-4672-87aa-858ddbc239c7", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(422), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(424), 4, "C" },
                    { "6a443884-57a1-48de-99bd-e1b0f7c3fa22", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(273), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(274), 1, "C" },
                    { "706bf600-1e66-425e-adf0-f5bc18f9d259", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(400), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(402), 4, "B" },
                    { "70fdecc5-9a52-4399-a18f-0257f10d2dc7", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(559), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(561), 2, "D" },
                    { "7299553d-79bf-469f-b6e7-04df30ffc5b1", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(584), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(585), 3, "E" },
                    { "72d7e823-5453-40b0-824d-783d0c942440", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(295), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(297), 4, "C" },
                    { "775fda64-28f9-4770-8e0e-5f05ac3396ff", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(471), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(473), 5, "E" },
                    { "77f5ee7d-319e-4fdc-9696-90994e3a2ab8", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(360), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(362), 2, "A" },
                    { "80256020-2059-494b-a998-37f66a1d3669", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(505), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(506), 6, "A" },
                    { "855e43a4-0b7a-475f-a695-7628a24d68dc", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(562), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(564), 3, "D" },
                    { "897308ee-3ce6-4584-b104-dae2dd574e44", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(319), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(321), 4, "D" },
                    { "899d659e-2018-45f0-89a7-4befa488dde3", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(532), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(534), 1, "C" },
                    { "8bdfa791-c848-4fb2-a6aa-2be7afb4559c", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(276), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(277), 2, "C" },
                    { "8ce33dac-aade-40c8-b810-1440acdac11a", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(468), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(470), 4, "E" },
                    { "8e84ded3-6f27-49a3-9ec4-495b4e4eee95", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(461), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(463), 2, "E" },
                    { "8fff47bd-3561-4657-96ab-24a3feb33c43", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(377), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(379), 6, "A" },
                    { "92a672f1-0f66-4c04-bda3-c0f515c1af67", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(514), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(516), 2, "B" },
                    { "95ba8ebb-c097-41b2-9da3-1e5007769b45", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(520), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(522), 4, "B" },
                    { "9868a4a5-d7e5-414d-9dee-f89e3ace1fe2", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(524), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(525), 5, "B" },
                    { "9893bf6f-a712-4009-b279-271ff8ca8891", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(240), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(242), 6, "A" },
                    { "99fe54c8-b181-4049-8e79-6205ff86cec8", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(544), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(545), 4, "C" },
                    { "9a107bcc-803a-4921-b7b2-9a69226ae40a", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(316), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(318), 3, "D" },
                    { "9c01a5d1-fbd0-473f-9877-3156570849aa", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(403), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(405), 5, "B" },
                    { "a2567bba-8828-47f4-8638-21eec1a6a938", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(419), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(421), 3, "C" },
                    { "a6023649-5e20-47a4-895d-8603d2ddd473", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(431), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(432), 6, "C" },
                    { "a6206b8a-eb8f-40cf-b2f6-63d2c10d9905", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(244), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(246), 1, "B" },
                    { "a621271c-12e5-458d-817d-1888d06138f2", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(566), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(567), 4, "D" },
                    { "a9c3fe4e-f280-487d-ba6b-f36024def37d", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(441), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(442), 3, "D" },
                    { "aad3c3ca-a6f9-48b5-a634-849762e6fe00", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(410), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(412), 1, "C" },
                    { "b00382a4-35cf-4c8c-984c-a2a19d84ae3f", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(335), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(337), 2, "E" },
                    { "babe38c6-a167-4e6e-b44c-d1dfd7d95ea3", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(279), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(281), 3, "C" },
                    { "c16e6479-3e09-4f6d-b23a-1874256c10db", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(307), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(309), 1, "D" },
                    { "c1b82288-8db0-49be-90f4-7a7982660990", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(231), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(233), 4, "A" },
                    { "c61f48cb-d086-46f3-a531-977abe297c04", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(495), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(496), 5, "A" },
                    { "c911dc7c-52eb-40ab-9c57-5769f6e647d7", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(351), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(353), 6, "E" },
                    { "c96ba4e5-d3ad-42b5-a75a-a93c80142643", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(407), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(408), 6, "B" },
                    { "ca0bd3b4-22ba-4877-ada9-cf9730a180b4", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(416), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(417), 2, "C" },
                    { "ca5ea23a-ee0a-4f1f-9db5-27d6650209d3", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(535), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(537), 2, "C" },
                    { "cc2920b0-cccb-4e60-8834-d54a8e14bfa9", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(547), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(549), 5, "C" },
                    { "d001eeb7-a9ea-403e-8ae6-16d067eebe0a", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(329), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(330), 6, "D" },
                    { "d6c62ac0-4477-4025-9df8-816cf7a001b9", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(437), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(439), 2, "D" },
                    { "db948809-adc9-4dcf-b15f-4e9ce957bc57", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(434), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(436), 1, "D" },
                    { "e3194977-6215-4054-9f53-446f5fad3217", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(263), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(265), 5, "B" },
                    { "e462f9cb-744d-4240-96e4-83cee643f2f0", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(339), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(340), 3, "E" },
                    { "e7aea8f6-37e5-4e6a-b9eb-13af1a9c4b1b", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(554), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(555), 1, "D" },
                    { "e9f49e97-a71f-4ce6-9c09-9d9fcd7aa582", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(218), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(220), 3, "A" },
                    { "eb5ada3a-9c14-4682-9279-3316f811c4d8", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(492), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(493), 4, "A" },
                    { "f09f216d-7790-49ea-af40-6aff889462f5", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(538), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(540), 3, "C" },
                    { "f3bf480c-cd9f-4b39-aaa6-c3c884ca0259", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(602), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(604), 6, "E" },
                    { "f4549727-4a4d-4656-94ab-2ed18f78fa63", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(381), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(383), 1, "B" },
                    { "fa92a2ec-621f-45cd-82cf-742296bc923f", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(480), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(482), 1, "A" },
                    { "fba9eb11-400c-4afa-9082-894250c7c97e", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(425), null, null, "Beta", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(427), 5, "C" },
                    { "fc78adfc-9103-4256-b4e8-4f5295d51f6d", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(517), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(519), 3, "B" },
                    { "fdddf26f-f943-4b49-85c0-4210ff47d45f", "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(313), null, null, "Alpha", true, "System", new DateTime(2024, 7, 2, 17, 59, 8, 319, DateTimeKind.Local).AddTicks(315), 2, "D" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserHistories_UserID",
                schema: "dbo",
                table: "UserHistories",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_EventHistories_EventID",
                schema: "dbo",
                table: "EventHistories",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatHistories_ChatID",
                schema: "dbo",
                table: "ChatHistories",
                column: "ChatID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatHistories_UserId",
                schema: "dbo",
                table: "ChatHistories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatHistories_AspNetUsers_UserId",
                schema: "dbo",
                table: "ChatHistories",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatHistories_Chats_ChatID",
                schema: "dbo",
                table: "ChatHistories",
                column: "ChatID",
                principalSchema: "dbo",
                principalTable: "Chats",
                principalColumn: "ChatID");

            migrationBuilder.AddForeignKey(
                name: "FK_EventHistories_Events_EventID",
                schema: "dbo",
                table: "EventHistories",
                column: "EventID",
                principalSchema: "dbo",
                principalTable: "Events",
                principalColumn: "EventID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserHistories_AspNetUsers_UserID",
                schema: "dbo",
                table: "UserHistories",
                column: "UserID",
                principalSchema: "dbo",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
