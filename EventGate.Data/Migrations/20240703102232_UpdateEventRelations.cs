using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventGate.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEventRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventFeedbacks_Events_EventID",
                schema: "dbo",
                table: "EventFeedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_EventHistories_EventTypes_EventTypeID",
                schema: "dbo",
                table: "EventHistories");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "03488453-5cec-4bb0-8ccb-399db9dd5c9e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "04cbf73d-d2ab-43b6-ab8b-37617b927bfc");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "11795758-cc9a-4d70-9e59-b97c1d32092b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "140c01d3-ac18-4284-9300-4a56e949ccb7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "14188d05-eb0a-4aa4-a44f-e04baf2ccc55");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "171b7656-ecd3-4cdb-8de6-00d80484974f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1ac24897-ba99-4194-bae0-0e42793ef924");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1fb06d2e-2403-42b8-8af0-1d6728627b5c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "25605a38-d76e-4340-86fb-b99a56e1ca81");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2596dccf-2ded-4a3e-94e5-bf401ff7cc00");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "26567080-0d10-4fda-828d-e79344011dc9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2a12f394-b6b4-40fe-8577-4c2eb5c95f81");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2c416164-d452-4537-85b1-30b52de39e9f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3019fb6d-760f-4384-a455-a986e4b12b00");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3843df19-7152-4d67-9b78-f2ebb6423208");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "38854655-fc9b-4340-973a-414b20c3fe30");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "38b9e3f9-96fb-412f-8b68-514aa4747f35");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "396eeb87-5952-4a5e-94d9-639111c3198a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3a32307f-69bd-429b-811f-8611ab798dc9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "430d770a-2e84-42ff-bb33-3c4427adeb6a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "481c03d8-164e-4a06-b3fb-822eb82a312d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "53c17fdf-3e65-475a-ae95-942d03f08e3d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "54732b79-ab1f-4a24-9dc3-aacff646221f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5511463f-fa5e-4ff0-b4dc-3c8a4f64dc63");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5595db1a-cbf5-472f-b83a-e2bcb4fc5d1b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5a9ba7f6-60b2-465c-b897-f60aa7db5cfc");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5fbda2f9-c471-4b90-a531-3f80d27e0a4f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "68aae8e2-1f75-4ced-8fd0-785ed2456ad6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "694f39f9-c18e-4ed6-88b4-d4c7cb9b6d44");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6bb876c0-a25a-4687-b6e8-e4168b2462ed");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6fcfd620-bfd8-4fa3-af16-d3574ae75b93");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7165a76b-68ef-43a8-af08-f77a151adc1f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "728ba882-76bd-42ab-99df-95df2944955f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "73e3caef-3914-40f4-be9f-536807df0c32");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "758391d5-77bc-4605-b2d7-31d0f7bdc3bd");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "75c5a1d0-2f90-45df-9a8a-b2c0e7d2ef8d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "78c33b37-58f1-4a2e-a59b-c8d727681faa");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "78ef4dbe-8d7d-4004-9e9a-492c137de67a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "79dc4ad1-bf6f-469e-bf09-619cdee57434");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7bdafb31-0216-4c37-8911-46418dff94bd");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7c6b10a0-b7c7-4999-93e9-ec82f391eef2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7dfde11e-3f1f-4b8d-955f-71c9df789762");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "80366b24-eb9a-48cb-9996-c740f8a0a49c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "85742ca6-b38b-4cdf-9041-8b764d39f94b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "86255392-d934-4816-8df1-14dd58dd7a82");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "88b6e983-3ed9-4728-85fb-4d3eed07a304");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8952c69e-9c81-4319-bd43-e0ee53021c92");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8d094033-0cac-42b1-9f61-bb2e16257773");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8f408e58-4cd6-494a-b764-5f42afd8302d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "912bc12a-507d-4c54-a1f2-51c39b14b4f8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "92b10fac-25d3-43a6-b75e-4963e49ad552");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "95296ae6-a36e-44b8-bb7e-dfbb68e01fba");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "96de5220-0eb3-4387-9011-9aea23a2745e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a2db108e-8760-4e6a-b8d0-f2692938b2e4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a3445893-f3e9-4326-a2aa-caeb8a8304cc");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "aa88fca1-8d8e-4cd2-a077-299b5ba753dd");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "abfe241d-5583-4afe-8709-43abe8606e2e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ae3a0d08-17af-444e-9df6-bd75d7a43ace");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b32ddc94-edde-4fa2-88a0-0694e2834831");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b6314578-a5d3-4231-a5b3-5f2e0307be1a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "bb067a02-cfe5-44b8-acb6-5ff893ebaee1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "bb0ff0ac-e859-4c3c-927e-d5b4217c0762");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "bbb1a3ee-2b70-4e2a-892c-95195a12708d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "bdf52e12-5c15-481b-999c-c93d5d467880");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c3bb5f78-aba8-4131-82bb-a8f5fd2cf9be");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c53ebcd6-5a70-4ec8-97f2-09c23c1acd9b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c54921a3-2c92-4ace-b06c-648154324f58");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c60ed366-0822-4855-b243-767fdf6230fb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c8bba9af-9162-4955-80a9-425cef6fd9e0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c9cf1e6b-24f2-459d-bd30-503fe6527b43");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cab5ba44-32ab-41b8-887d-f0c204293a4a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cadf4389-987e-4433-a3ec-33983c766467");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d3a528b1-d688-4061-a7b0-922fdaf9f193");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d44e294b-5229-44b5-9cc7-5b278888e37d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d67d38b3-f631-4804-81c0-637f24f97de3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "dd4ccfbe-45b6-45fd-8100-25cbfd798b3a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e102cd10-ed8f-44c1-b918-1d7e18c5f00e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e10dc077-5621-43fd-abbd-f1120ef8fbf2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e28cad17-9963-4446-866b-574b99ba6816");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e45f858a-599e-4961-bdf3-f85b554d6acd");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e68c1d4b-66dd-4160-be7a-8c74c383523d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e90a91b7-b269-4800-9b21-c12d16bc27eb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e983042e-b79d-4d36-8494-eeab939e75af");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f3c8360c-c191-4750-918b-f582b20c582b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f5f1f638-d6a7-4b32-8836-cf74cc9999a0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f947772c-9634-4884-819d-b8fac3f7723b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fb729190-3e7d-42ba-8449-fc28ebb9a01a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fd7937f1-08ac-4633-a03a-6e5141782f14");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fe0eb9f7-0688-4348-88b1-106f2d435e8e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fe8f8c4c-7981-49b0-aaeb-d3eeec3af9f4");

            migrationBuilder.AddColumn<string>(
                name: "EventTypeID1",
                schema: "dbo",
                table: "EventHistories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Seats",
                columns: new[] { "SeatID", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Hall", "IsAvailable", "LastUpdatedBy", "LastUpdatedTime", "Number", "Row" },
                values: new object[,]
                {
                    { "049b363f-74d9-46c5-a86b-1bb3b0308f86", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8127), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8153), 1, "A" },
                    { "065cd5da-7b16-461f-a463-f7182daa88da", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8373), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8375), 2, "B" },
                    { "0b6f7d99-a7bd-4c0f-bd7b-de650fa17b55", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8562), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8563), 6, "C" },
                    { "0d855e20-fb6f-4e12-b0fd-a50e086b92db", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8496), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8497), 4, "A" },
                    { "0f0aea64-0ca8-459e-9fd0-8a3f9cbd6dc4", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8258), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8261), 3, "C" },
                    { "18ddf2eb-58fd-4cba-98ba-4e21327d6014", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8293), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8294), 6, "D" },
                    { "1b410768-27aa-48cc-98c3-1cf0f166e6fa", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8282), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8283), 3, "D" },
                    { "30010f01-13b1-4f3b-be75-28fde33928e9", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8515), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8516), 3, "B" },
                    { "350bd1f2-87f8-4ec4-a7a8-1f022fd91e97", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8405), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8408), 5, "C" },
                    { "363ec671-bce6-4200-aa90-a6f5a74b3aff", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8158), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8160), 2, "A" },
                    { "36ea1196-114b-44c1-a21f-0b8279283cbc", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8263), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8264), 4, "C" },
                    { "36fd5271-4919-40ad-9d26-d6efc4997d7a", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8265), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8267), 5, "C" },
                    { "38ce4043-019e-490d-afc3-f1563277696b", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8236), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8237), 3, "B" },
                    { "38d6d0eb-0c92-43bd-8d7b-7f2ed213fc9a", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8532), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8533), 2, "C" },
                    { "38f9f062-d2fd-4772-8039-1c930a2e1757", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8570), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8572), 2, "D" },
                    { "44c428ce-d3d0-4265-9c8e-e21b8393379f", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8587), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8588), 1, "E" },
                    { "451b052f-1610-4dc3-a296-8706fb255c02", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8466), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8467), 2, "E" },
                    { "4791272c-24fe-4295-a89a-cd6c8163ab62", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8573), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8574), 3, "D" },
                    { "47b50fc3-705f-419d-bea4-4f0b0e0de85b", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8388), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8390), 6, "B" },
                    { "47ca13c8-e5b4-4c3d-babf-8da2cc171806", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8518), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8519), 4, "B" },
                    { "486c3ff0-21dc-4dd9-9c0c-e1033d1a8e93", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8273), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8277), 1, "D" },
                    { "4b3c533c-73ea-49be-9f0d-866f1700d77b", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8565), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8569), 1, "D" },
                    { "4cb57077-8e45-4571-8fb6-183e015a2728", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8413), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8415), 1, "D" },
                    { "4d911208-530e-4398-99aa-66d4533e7564", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8601), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8603), 5, "E" },
                    { "4efa0041-5160-4e71-b70a-810045edeaa9", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8457), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8458), 6, "D" },
                    { "51b4ebdc-7400-47e6-9b14-9d743e0af211", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8410), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8411), 6, "C" },
                    { "5224bd31-1e7d-42c2-b183-0b2457d13b09", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8296), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8297), 1, "E" },
                    { "5293f54a-6cfa-454b-8557-4c7c00f1a814", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8370), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8372), 1, "B" },
                    { "563fc88a-19cb-46bb-b257-22482bc5a9cf", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8499), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8500), 5, "A" },
                    { "59a658f4-5009-44ab-8ad7-3275b968db4b", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8402), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8403), 4, "C" },
                    { "5cda44da-8f04-4c8a-941b-bdc8c3a16e72", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8526), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8527), 6, "B" },
                    { "5e3a8a77-dd1f-45d3-b5a0-eb0c2151423b", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8487), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8489), 2, "A" },
                    { "5ec7c1d3-8f5f-478f-a27a-2c173ce55836", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8362), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8365), 5, "A" },
                    { "612c516f-80bb-4a67-86b0-abcee481da0d", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8385), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8387), 5, "B" },
                    { "69662f03-7497-4e6b-a9bd-275bc1a8b9ec", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8468), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8470), 3, "E" },
                    { "6c0fa4b7-db8d-47ae-9396-d12b2d648347", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8490), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8494), 3, "A" },
                    { "6db3f603-7f39-472f-9048-d8bb42849749", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8358), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8360), 4, "A" },
                    { "6ede4099-cc5d-49de-ac7a-63bb714fd5ce", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8302), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8305), 3, "E" },
                    { "6f1d2803-8d77-47ab-8086-5eda7b423f0e", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8521), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8524), 5, "B" },
                    { "6f23def7-9d42-460b-9b16-4452a87cfe3d", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8382), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8384), 4, "B" },
                    { "71cb587a-9ecc-44f0-8bb0-d6152d5406df", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8241), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8242), 4, "B" },
                    { "7226bcad-288c-4b8b-a374-e48cb0bdbd68", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8162), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8178), 3, "A" },
                    { "72a86538-cb91-411b-9e7c-5bf4b9312767", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8232), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8235), 2, "B" },
                    { "74713e76-132d-4df9-8f9e-ab7449b9ced9", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8180), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8181), 4, "A" },
                    { "74fce975-b879-4695-8f54-5ca9285fc587", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8377), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8381), 3, "B" },
                    { "754662ab-b675-4e3a-b3d8-322a18d6e7bd", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8288), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8291), 5, "D" },
                    { "76ea879e-50fb-4bfa-80fb-7cd5f47509b4", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8244), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8248), 5, "B" },
                    { "7749d0b7-ce2a-4371-bcb1-4c5d1a99e225", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8225), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8230), 1, "B" },
                    { "78319ddf-4507-44dc-8369-f6bf7a8539b2", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8285), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8286), 4, "D" },
                    { "7f87538e-72ee-405d-9b62-e8701cc4b2e6", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8354), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8355), 3, "A" },
                    { "885f3f1f-6316-4dba-bc5d-aedb390520c0", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8252), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8254), 1, "C" },
                    { "8afccdde-aba6-4ca2-8215-dd2dc66f96c1", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8391), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8395), 1, "C" },
                    { "905ec347-377f-498b-9624-5dfd3e74f117", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8423), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8425), 4, "D" },
                    { "9924f660-4d55-4ea6-8374-dd447825f1f9", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8512), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8513), 2, "B" },
                    { "9939d03a-0c0d-4a61-b078-a7b01beca7e7", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8583), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8585), 6, "D" },
                    { "9aab112e-9a84-43c6-a622-4ab4a39b23b7", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8427), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8428), 5, "D" },
                    { "9ee5b2e9-c146-4b0a-bca9-c06c74129c8a", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8346), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8349), 1, "A" },
                    { "a08f3ddf-7d68-4ef9-8017-30d9fca68cb5", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8590), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8591), 2, "E" },
                    { "a16ca628-5070-4b3d-9d37-17bbfe95b4c4", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8249), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8251), 6, "B" },
                    { "a392ca4a-3db0-42d8-a304-097a1aa37e02", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8351), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8352), 2, "A" },
                    { "a5623cfb-ce76-4cc3-b8e0-0506eb989534", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8299), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8300), 2, "E" },
                    { "ab4a5744-81e5-4dad-b04c-600fa251ab12", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8598), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8600), 4, "E" },
                    { "ac7fe157-c3c1-4a99-9871-ea084cadad90", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8279), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8280), 2, "D" },
                    { "ad6acb48-134e-4b29-ac5b-f2f4a9ad4d7a", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8507), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8510), 1, "B" },
                    { "b893fdad-7c8c-41c0-a240-e57d2a2ed0fe", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8593), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8597), 3, "E" },
                    { "bd0bb0ec-761a-4db1-b7aa-a54fdc164160", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8310), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8341), 5, "E" },
                    { "c5c1932c-3361-4b72-9140-581babf8229c", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8503), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8505), 6, "A" },
                    { "c75f856c-1f49-42dd-9992-1ae85f669bd9", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8416), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8417), 2, "D" },
                    { "c7de8af7-47f8-48eb-8c28-022b01135939", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8255), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8257), 2, "C" },
                    { "c935dcd9-3491-4fdb-820e-fbb6d81ea513", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8460), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8464), 1, "E" },
                    { "ca7759d8-a791-43c9-be48-dd80e30e0e7b", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8216), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8217), 5, "A" },
                    { "d07c1576-c174-45d6-b4a6-55d727894065", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8399), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8400), 3, "C" },
                    { "d1fdd0da-3926-4215-98e1-252f41b03216", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8534), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8538), 3, "C" },
                    { "d2d3eb9b-006a-4c25-a43a-0db4c0f33d6d", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8529), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8530), 1, "C" },
                    { "d3f08a62-0a25-4897-a9ec-40b45b7bcefb", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8471), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8473), 4, "E" },
                    { "d4eaa282-3ff3-434e-bac7-d3afcddd774a", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8475), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8479), 5, "E" },
                    { "d64cc5bf-bdd7-49fd-aecf-9ba20aa0e89d", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8270), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8271), 6, "C" },
                    { "dcba1f33-a8d9-4053-9521-c14015322a6c", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8539), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8541), 4, "C" },
                    { "e4ecefab-95e8-4287-a1eb-a99d06987d2d", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8222), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8223), 6, "A" },
                    { "e7973d97-78be-4fec-b390-5178010816f1", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8367), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8369), 6, "A" },
                    { "ebe59b0c-d925-4a8f-896c-770fd24c4efe", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8604), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8606), 6, "E" },
                    { "f1469b37-e8f2-48bd-b699-43f47025d8ba", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8396), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8397), 2, "C" },
                    { "f6a82984-ac33-4a95-8994-6d9da957d154", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8576), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8577), 4, "D" },
                    { "f6e139ba-bd29-48d1-8fb2-71534a81eb23", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8307), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8308), 4, "E" },
                    { "f72d20ac-5d26-4174-b9ea-57d34bbce5ef", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8481), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8482), 6, "E" },
                    { "f82fc6a0-3f31-49a5-8ca9-27c2ffc343ca", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8558), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8560), 5, "C" },
                    { "fb1d3e81-1139-48d0-8391-e3e3c4637ce1", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8579), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8582), 5, "D" },
                    { "fc0bf9c7-8643-4f71-9317-5b25dcc72153", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8342), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8344), 6, "E" },
                    { "fc81315b-e03e-4c59-a2f3-112705d5ff53", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8484), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8486), 1, "A" },
                    { "feebce24-34ad-4fc1-bde8-a31385a034f9", "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8419), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 17, 22, 32, 8, DateTimeKind.Local).AddTicks(8422), 3, "D" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventHistories_EventTypeID1",
                schema: "dbo",
                table: "EventHistories",
                column: "EventTypeID1");

            migrationBuilder.AddForeignKey(
                name: "FK_EventFeedbacks_Events_EventID",
                schema: "dbo",
                table: "EventFeedbacks",
                column: "EventID",
                principalSchema: "dbo",
                principalTable: "Events",
                principalColumn: "EventID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventHistories_EventTypes_EventTypeID",
                schema: "dbo",
                table: "EventHistories",
                column: "EventTypeID",
                principalSchema: "dbo",
                principalTable: "EventTypes",
                principalColumn: "EventTypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventHistories_EventTypes_EventTypeID1",
                schema: "dbo",
                table: "EventHistories",
                column: "EventTypeID1",
                principalSchema: "dbo",
                principalTable: "EventTypes",
                principalColumn: "EventTypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventFeedbacks_Events_EventID",
                schema: "dbo",
                table: "EventFeedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_EventHistories_EventTypes_EventTypeID",
                schema: "dbo",
                table: "EventHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_EventHistories_EventTypes_EventTypeID1",
                schema: "dbo",
                table: "EventHistories");

            migrationBuilder.DropIndex(
                name: "IX_EventHistories_EventTypeID1",
                schema: "dbo",
                table: "EventHistories");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "049b363f-74d9-46c5-a86b-1bb3b0308f86");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "065cd5da-7b16-461f-a463-f7182daa88da");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0b6f7d99-a7bd-4c0f-bd7b-de650fa17b55");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0d855e20-fb6f-4e12-b0fd-a50e086b92db");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0f0aea64-0ca8-459e-9fd0-8a3f9cbd6dc4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "18ddf2eb-58fd-4cba-98ba-4e21327d6014");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1b410768-27aa-48cc-98c3-1cf0f166e6fa");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "30010f01-13b1-4f3b-be75-28fde33928e9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "350bd1f2-87f8-4ec4-a7a8-1f022fd91e97");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "363ec671-bce6-4200-aa90-a6f5a74b3aff");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "36ea1196-114b-44c1-a21f-0b8279283cbc");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "36fd5271-4919-40ad-9d26-d6efc4997d7a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "38ce4043-019e-490d-afc3-f1563277696b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "38d6d0eb-0c92-43bd-8d7b-7f2ed213fc9a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "38f9f062-d2fd-4772-8039-1c930a2e1757");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "44c428ce-d3d0-4265-9c8e-e21b8393379f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "451b052f-1610-4dc3-a296-8706fb255c02");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4791272c-24fe-4295-a89a-cd6c8163ab62");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "47b50fc3-705f-419d-bea4-4f0b0e0de85b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "47ca13c8-e5b4-4c3d-babf-8da2cc171806");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "486c3ff0-21dc-4dd9-9c0c-e1033d1a8e93");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4b3c533c-73ea-49be-9f0d-866f1700d77b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4cb57077-8e45-4571-8fb6-183e015a2728");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4d911208-530e-4398-99aa-66d4533e7564");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4efa0041-5160-4e71-b70a-810045edeaa9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "51b4ebdc-7400-47e6-9b14-9d743e0af211");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5224bd31-1e7d-42c2-b183-0b2457d13b09");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5293f54a-6cfa-454b-8557-4c7c00f1a814");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "563fc88a-19cb-46bb-b257-22482bc5a9cf");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "59a658f4-5009-44ab-8ad7-3275b968db4b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5cda44da-8f04-4c8a-941b-bdc8c3a16e72");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5e3a8a77-dd1f-45d3-b5a0-eb0c2151423b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5ec7c1d3-8f5f-478f-a27a-2c173ce55836");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "612c516f-80bb-4a67-86b0-abcee481da0d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "69662f03-7497-4e6b-a9bd-275bc1a8b9ec");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6c0fa4b7-db8d-47ae-9396-d12b2d648347");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6db3f603-7f39-472f-9048-d8bb42849749");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6ede4099-cc5d-49de-ac7a-63bb714fd5ce");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6f1d2803-8d77-47ab-8086-5eda7b423f0e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6f23def7-9d42-460b-9b16-4452a87cfe3d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "71cb587a-9ecc-44f0-8bb0-d6152d5406df");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7226bcad-288c-4b8b-a374-e48cb0bdbd68");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "72a86538-cb91-411b-9e7c-5bf4b9312767");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "74713e76-132d-4df9-8f9e-ab7449b9ced9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "74fce975-b879-4695-8f54-5ca9285fc587");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "754662ab-b675-4e3a-b3d8-322a18d6e7bd");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "76ea879e-50fb-4bfa-80fb-7cd5f47509b4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7749d0b7-ce2a-4371-bcb1-4c5d1a99e225");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "78319ddf-4507-44dc-8369-f6bf7a8539b2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7f87538e-72ee-405d-9b62-e8701cc4b2e6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "885f3f1f-6316-4dba-bc5d-aedb390520c0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8afccdde-aba6-4ca2-8215-dd2dc66f96c1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "905ec347-377f-498b-9624-5dfd3e74f117");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9924f660-4d55-4ea6-8374-dd447825f1f9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9939d03a-0c0d-4a61-b078-a7b01beca7e7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9aab112e-9a84-43c6-a622-4ab4a39b23b7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9ee5b2e9-c146-4b0a-bca9-c06c74129c8a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a08f3ddf-7d68-4ef9-8017-30d9fca68cb5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a16ca628-5070-4b3d-9d37-17bbfe95b4c4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a392ca4a-3db0-42d8-a304-097a1aa37e02");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a5623cfb-ce76-4cc3-b8e0-0506eb989534");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ab4a5744-81e5-4dad-b04c-600fa251ab12");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ac7fe157-c3c1-4a99-9871-ea084cadad90");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ad6acb48-134e-4b29-ac5b-f2f4a9ad4d7a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b893fdad-7c8c-41c0-a240-e57d2a2ed0fe");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "bd0bb0ec-761a-4db1-b7aa-a54fdc164160");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c5c1932c-3361-4b72-9140-581babf8229c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c75f856c-1f49-42dd-9992-1ae85f669bd9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c7de8af7-47f8-48eb-8c28-022b01135939");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c935dcd9-3491-4fdb-820e-fbb6d81ea513");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ca7759d8-a791-43c9-be48-dd80e30e0e7b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d07c1576-c174-45d6-b4a6-55d727894065");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d1fdd0da-3926-4215-98e1-252f41b03216");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d2d3eb9b-006a-4c25-a43a-0db4c0f33d6d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d3f08a62-0a25-4897-a9ec-40b45b7bcefb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d4eaa282-3ff3-434e-bac7-d3afcddd774a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d64cc5bf-bdd7-49fd-aecf-9ba20aa0e89d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "dcba1f33-a8d9-4053-9521-c14015322a6c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e4ecefab-95e8-4287-a1eb-a99d06987d2d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e7973d97-78be-4fec-b390-5178010816f1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ebe59b0c-d925-4a8f-896c-770fd24c4efe");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f1469b37-e8f2-48bd-b699-43f47025d8ba");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f6a82984-ac33-4a95-8994-6d9da957d154");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f6e139ba-bd29-48d1-8fb2-71534a81eb23");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f72d20ac-5d26-4174-b9ea-57d34bbce5ef");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f82fc6a0-3f31-49a5-8ca9-27c2ffc343ca");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fb1d3e81-1139-48d0-8391-e3e3c4637ce1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fc0bf9c7-8643-4f71-9317-5b25dcc72153");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fc81315b-e03e-4c59-a2f3-112705d5ff53");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "feebce24-34ad-4fc1-bde8-a31385a034f9");

            migrationBuilder.DropColumn(
                name: "EventTypeID1",
                schema: "dbo",
                table: "EventHistories");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Seats",
                columns: new[] { "SeatID", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Hall", "IsAvailable", "LastUpdatedBy", "LastUpdatedTime", "Number", "Row" },
                values: new object[,]
                {
                    { "03488453-5cec-4bb0-8ccb-399db9dd5c9e", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4310), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4311), 6, "E" },
                    { "04cbf73d-d2ab-43b6-ab8b-37617b927bfc", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4495), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4496), 1, "E" },
                    { "11795758-cc9a-4d70-9e59-b97c1d32092b", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4234), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4235), 2, "B" },
                    { "140c01d3-ac18-4284-9300-4a56e949ccb7", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4240), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4241), 4, "B" },
                    { "14188d05-eb0a-4aa4-a44f-e04baf2ccc55", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4225), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4227), 6, "A" },
                    { "171b7656-ecd3-4cdb-8de6-00d80484974f", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4414), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4415), 2, "A" },
                    { "1ac24897-ba99-4194-bae0-0e42793ef924", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4365), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4366), 4, "C" },
                    { "1fb06d2e-2403-42b8-8af0-1d6728627b5c", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4317), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4318), 2, "A" },
                    { "25605a38-d76e-4340-86fb-b99a56e1ca81", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4436), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4437), 6, "A" },
                    { "2596dccf-2ded-4a3e-94e5-bf401ff7cc00", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4461), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4462), 2, "C" },
                    { "26567080-0d10-4fda-828d-e79344011dc9", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4247), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4248), 6, "B" },
                    { "2a12f394-b6b4-40fe-8577-4c2eb5c95f81", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4320), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4321), 3, "A" },
                    { "2c416164-d452-4537-85b1-30b52de39e9f", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4482), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4484), 3, "D" },
                    { "3019fb6d-760f-4384-a455-a986e4b12b00", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4363), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4364), 3, "C" },
                    { "3843df19-7152-4d67-9b78-f2ebb6423208", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4463), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4465), 3, "C" },
                    { "38854655-fc9b-4340-973a-414b20c3fe30", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4507), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4508), 5, "E" },
                    { "38b9e3f9-96fb-412f-8b68-514aa4747f35", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4396), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4398), 2, "E" },
                    { "396eeb87-5952-4a5e-94d9-639111c3198a", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4313), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4314), 1, "A" },
                    { "3a32307f-69bd-429b-811f-8611ab798dc9", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4375), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4376), 1, "D" },
                    { "430d770a-2e84-42ff-bb33-3c4427adeb6a", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4259), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4261), 4, "C" },
                    { "481c03d8-164e-4a06-b3fb-822eb82a312d", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4475), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4477), 1, "D" },
                    { "53c17fdf-3e65-475a-ae95-942d03f08e3d", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4243), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4244), 5, "B" },
                    { "54732b79-ab1f-4a24-9dc3-aacff646221f", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4285), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4286), 4, "D" },
                    { "5511463f-fa5e-4ff0-b4dc-3c8a4f64dc63", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4439), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4440), 1, "B" },
                    { "5595db1a-cbf5-472f-b83a-e2bcb4fc5d1b", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4446), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4447), 3, "B" },
                    { "5a9ba7f6-60b2-465c-b897-f60aa7db5cfc", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4488), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4489), 5, "D" },
                    { "5fbda2f9-c471-4b90-a531-3f80d27e0a4f", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4304), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4306), 4, "E" },
                    { "68aae8e2-1f75-4ced-8fd0-785ed2456ad6", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4387), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4388), 5, "D" },
                    { "694f39f9-c18e-4ed6-88b4-d4c7cb9b6d44", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4468), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4469), 4, "C" },
                    { "6bb876c0-a25a-4687-b6e8-e4168b2462ed", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4392), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4393), 1, "E" },
                    { "6fcfd620-bfd8-4fa3-af16-d3574ae75b93", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4272), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4274), 6, "C" },
                    { "7165a76b-68ef-43a8-af08-f77a151adc1f", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4252), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4253), 2, "C" },
                    { "728ba882-76bd-42ab-99df-95df2944955f", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4342), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4343), 4, "B" },
                    { "73e3caef-3914-40f4-be9f-536807df0c32", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4451), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4452), 5, "B" },
                    { "758391d5-77bc-4605-b2d7-31d0f7bdc3bd", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4249), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4251), 1, "C" },
                    { "75c5a1d0-2f90-45df-9a8a-b2c0e7d2ef8d", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4448), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4450), 4, "B" },
                    { "78c33b37-58f1-4a2e-a59b-c8d727681faa", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4424), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4425), 5, "A" },
                    { "78ef4dbe-8d7d-4004-9e9a-492c137de67a", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4338), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4339), 3, "B" },
                    { "79dc4ad1-bf6f-469e-bf09-619cdee57434", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4255), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4256), 3, "C" },
                    { "7bdafb31-0216-4c37-8911-46418dff94bd", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4228), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4230), 1, "B" },
                    { "7c6b10a0-b7c7-4999-93e9-ec82f391eef2", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4389), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4390), 6, "D" },
                    { "7dfde11e-3f1f-4b8d-955f-71c9df789762", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4282), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4284), 3, "D" },
                    { "80366b24-eb9a-48cb-9996-c740f8a0a49c", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4335), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4337), 2, "B" },
                    { "85742ca6-b38b-4cdf-9041-8b764d39f94b", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4279), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4281), 2, "D" },
                    { "86255392-d934-4816-8df1-14dd58dd7a82", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4201), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4203), 3, "A" },
                    { "88b6e983-3ed9-4728-85fb-4d3eed07a304", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4353), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4354), 6, "B" },
                    { "8952c69e-9c81-4319-bd43-e0ee53021c92", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4269), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4270), 5, "C" },
                    { "8d094033-0cac-42b1-9f61-bb2e16257773", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4411), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4412), 1, "A" },
                    { "8f408e58-4cd6-494a-b764-5f42afd8302d", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4473), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4474), 6, "C" },
                    { "912bc12a-507d-4c54-a1f2-51c39b14b4f8", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4421), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4422), 4, "A" },
                    { "92b10fac-25d3-43a6-b75e-4963e49ad552", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4497), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4499), 2, "E" },
                    { "95296ae6-a36e-44b8-bb7e-dfbb68e01fba", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4492), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4493), 6, "D" },
                    { "96de5220-0eb3-4387-9011-9aea23a2745e", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4297), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4299), 2, "E" },
                    { "a2db108e-8760-4e6a-b8d0-f2692938b2e4", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4485), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4486), 4, "D" },
                    { "a3445893-f3e9-4326-a2aa-caeb8a8304cc", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4275), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4276), 1, "D" },
                    { "aa88fca1-8d8e-4cd2-a077-299b5ba753dd", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4368), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4369), 5, "C" },
                    { "abfe241d-5583-4afe-8709-43abe8606e2e", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4443), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4444), 2, "B" },
                    { "ae3a0d08-17af-444e-9df6-bd75d7a43ace", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4300), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4301), 3, "E" },
                    { "b32ddc94-edde-4fa2-88a0-0694e2834831", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4351), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4352), 5, "B" },
                    { "b6314578-a5d3-4231-a5b3-5f2e0307be1a", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4408), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4409), 6, "E" },
                    { "bb067a02-cfe5-44b8-acb6-5ff893ebaee1", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4455), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4456), 6, "B" },
                    { "bb0ff0ac-e859-4c3c-927e-d5b4217c0762", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4384), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4385), 4, "D" },
                    { "bbb1a3ee-2b70-4e2a-892c-95195a12708d", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4377), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4378), 2, "D" },
                    { "bdf52e12-5c15-481b-999c-c93d5d467880", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4504), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4506), 4, "E" },
                    { "c3bb5f78-aba8-4131-82bb-a8f5fd2cf9be", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4372), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4373), 6, "C" },
                    { "c53ebcd6-5a70-4ec8-97f2-09c23c1acd9b", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4404), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4405), 5, "E" },
                    { "c54921a3-2c92-4ace-b06c-648154324f58", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4458), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4459), 1, "C" },
                    { "c60ed366-0822-4855-b243-767fdf6230fb", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4218), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4219), 4, "A" },
                    { "c8bba9af-9162-4955-80a9-425cef6fd9e0", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4399), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4400), 3, "E" },
                    { "c9cf1e6b-24f2-459d-bd30-503fe6527b43", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4292), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4293), 6, "D" },
                    { "cab5ba44-32ab-41b8-887d-f0c204293a4a", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4356), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4357), 1, "C" },
                    { "cadf4389-987e-4433-a3ec-33983c766467", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4500), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4501), 3, "E" },
                    { "d3a528b1-d688-4061-a7b0-922fdaf9f193", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4173), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4194), 1, "A" },
                    { "d44e294b-5229-44b5-9cc7-5b278888e37d", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4323), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4325), 4, "A" },
                    { "d67d38b3-f631-4804-81c0-637f24f97de3", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4198), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4199), 2, "A" },
                    { "dd4ccfbe-45b6-45fd-8100-25cbfd798b3a", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4330), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4331), 6, "A" },
                    { "e102cd10-ed8f-44c1-b918-1d7e18c5f00e", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4380), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4381), 3, "D" },
                    { "e10dc077-5621-43fd-abbd-f1120ef8fbf2", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4470), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4471), 5, "C" },
                    { "e28cad17-9963-4446-866b-574b99ba6816", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4295), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4296), 1, "E" },
                    { "e45f858a-599e-4961-bdf3-f85b554d6acd", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4401), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4403), 4, "E" },
                    { "e68c1d4b-66dd-4160-be7a-8c74c383523d", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4221), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4222), 5, "A" },
                    { "e90a91b7-b269-4800-9b21-c12d16bc27eb", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4288), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4289), 5, "D" },
                    { "e983042e-b79d-4d36-8494-eeab939e75af", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4416), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4418), 3, "A" },
                    { "f3c8360c-c191-4750-918b-f582b20c582b", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4307), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4308), 5, "E" },
                    { "f5f1f638-d6a7-4b32-8836-cf74cc9999a0", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4520), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4521), 6, "E" },
                    { "f947772c-9634-4884-819d-b8fac3f7723b", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4360), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4361), 2, "C" },
                    { "fb729190-3e7d-42ba-8449-fc28ebb9a01a", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4326), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4327), 5, "A" },
                    { "fd7937f1-08ac-4633-a03a-6e5141782f14", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4236), null, null, "Alpha", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4238), 3, "B" },
                    { "fe0eb9f7-0688-4348-88b1-106f2d435e8e", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4480), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4481), 2, "D" },
                    { "fe8f8c4c-7981-49b0-aaeb-d3eeec3af9f4", "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4333), null, null, "Beta", true, "System", new DateTime(2024, 7, 3, 16, 58, 20, 742, DateTimeKind.Local).AddTicks(4334), 1, "B" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_EventFeedbacks_Events_EventID",
                schema: "dbo",
                table: "EventFeedbacks",
                column: "EventID",
                principalSchema: "dbo",
                principalTable: "Events",
                principalColumn: "EventID");

            migrationBuilder.AddForeignKey(
                name: "FK_EventHistories_EventTypes_EventTypeID",
                schema: "dbo",
                table: "EventHistories",
                column: "EventTypeID",
                principalSchema: "dbo",
                principalTable: "EventTypes",
                principalColumn: "EventTypeID");
        }
    }
}
