using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventGate.Data.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_TicketID",
                schema: "dbo",
                table: "OrderDetails");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0210af6d-1bf1-4b02-b20e-15bc93047238");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "04b10bf3-3b6b-4093-9727-b9ab925a9603");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "08201bb5-3493-436b-9edb-97b61a58eaa5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "09116e3e-739f-499a-b7b0-6caba53071e2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0a7bd15e-2c3b-48f7-a417-5c46858f018f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0b7f747c-a968-4e73-bc27-93d87bee3e24");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0fb74ebf-e3b4-4d51-9056-caeb62f29ea1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1152c0df-0fee-4506-a91d-444ebd699622");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "12507532-0cb1-4c11-bdc9-93efcf4c56c7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "13770daf-bcbd-4367-b14f-3436014e079a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1962b7f2-bb90-42fa-bbd6-1ef42cbc20f2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1af8bfa8-1407-4310-befd-202f8c423856");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1eb30210-e350-496f-92fa-176e3773240a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "219fd8b6-01e4-46e0-b328-fd36d45f819c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "21a6cffd-dbf7-4df6-88d0-cdce2ded77d3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "226c45f6-b6d9-440d-afe5-748c5e91c765");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "23af1159-1c3b-4c27-917a-aa460cfc8728");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2479a391-128a-4e9b-bbf5-e07c5afbc6e7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2b729118-62ef-4a6e-8138-37a7d8546d2d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3554e5c6-913c-4606-9f75-6622cec7c6dc");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "364c94a4-fa3c-48a4-b721-19a3b9ce8b9e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "37bda974-ecdd-499d-bf30-932b9af2488a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3a0179f0-9cfc-4ced-a04d-6978beb98a68");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3be18e7e-f7d6-4c2d-9a4a-3fba3588b865");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3d04a182-a631-4462-a53d-524de5979c80");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3edbbe49-446d-4f06-8830-16f8c696cb12");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "408006df-ac42-482b-8b23-c982e5b8ecb9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4102afef-f941-4adb-9a2c-2650ba9c47b4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "42b08244-fdd8-4c5c-8838-7b4e3af2882a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "470b8eea-95d9-4f5f-ac60-7bd421397a5b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "48b2c635-fa2d-4a70-8432-b97dc169aec5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4c1a326e-29a9-4e33-a7d8-47ad3ba66249");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4eb4a5af-727f-4adc-9828-d05afcce6534");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4ec18e96-d848-4bb4-9c34-70266ba1dcdc");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4ffdd95e-e0d2-4770-ad3f-da82bd221974");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "518518d6-8eb0-4d39-84ef-53c8b7e21416");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "56d1603c-0a50-41d8-98b5-614fb8cf3e30");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5bcc8704-1e18-4e78-a17b-723b1e04ac40");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "63737557-a860-4adf-b444-9576f9a39708");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6585711b-b0b1-49dc-beeb-26a96228bd67");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "673c03f6-a2d3-4dc1-8a3e-0bfa0c30bf48");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6acfc822-9b0e-412e-af6b-17fed3169277");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6c1913b5-a782-4766-a4fa-b67ac1fd4fed");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6dc94229-5b30-440b-bebb-eb34a2a8e0ac");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7209ecb8-2e1c-4511-b79e-3fb83ee164e0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "72546212-a6ae-4fc0-8edb-37a82340efc0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "744bb2ba-0197-4be3-92fa-d11c67097855");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "74cb64ec-97ac-48cf-9443-bce22f9c8198");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "76935bd2-8779-4d07-b1e9-ff5003bd4aeb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7cdd5bc9-5edf-495b-bcd1-a5b32d0fbb70");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7e4859e3-0e0f-4aec-ad1a-fdce0fa536f1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7f03e123-8e2e-46a0-8ae8-64ccdcf5d193");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8083c4cc-a2d0-4c1f-b51f-e5fd4fb1dc98");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "854ba8e9-a54b-448c-b4c7-286770ea24be");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8a6226ac-3f0f-4816-889e-6435d169d083");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8a791849-de62-44b4-ba51-762af24c5d1d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8a9492aa-4b1e-4080-8fc7-1564bbf27266");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "90a3a2ba-f03d-43ea-98b4-a2d5c3da30c5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "91de2ccb-a0e3-4f8a-83de-015773c145c2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "95ac8456-9399-4d00-9681-af5f4c5ca601");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9c6a6621-6e45-4d0a-8ca7-ef7269f57aee");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9d7abc72-4f29-4c71-9f69-dc9ec37824a8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a48752d5-c5f0-44a2-bfe4-d429ae6324d7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a69f626b-35f7-4353-9f49-a5687eccd897");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a851f5dd-3816-4cba-9ef8-f7beb00c03c7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a8c412b8-ba1f-4776-844b-6a97e097ac8a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ac213600-ee7c-4eba-8102-0b2a235a9dd3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b76bd39a-a6cc-413d-9b64-e6a64e414eb9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "bb9d9a2f-d3c1-4eaa-a989-b7f171b6896a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "bdf98e84-418c-4903-9a5c-0b0f13bb0d5f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c4773719-da98-48eb-88df-b34747590745");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cb511b3b-1c80-4a22-9ed1-aeb83f3a2bf5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cb6e700a-03ba-4067-ba37-48765f66065a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cbc58843-2f4f-4780-b7d1-3ff236e294cd");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cc7f5d9a-e9be-48bc-b07c-10060d3b31d2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cec9ce12-cdf5-4ec0-ac0d-53aa88750a40");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d11ada23-1a35-4ea2-b2ed-74584ac80eaf");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d22095d1-48ee-49d5-9abb-96332d6acb78");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d4aa48d2-fab8-4395-935a-3e3be051c656");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d69ea9ce-1417-40fb-9c00-8bedf1ff0d65");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d8f7d2bd-1316-4238-87a6-23c1f8fe3539");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "dbf6d3d3-2963-403c-a648-5f1b3a853c95");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ded21d06-664b-4b31-aec2-03d626067371");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e616c7d2-1ba9-4cc7-a521-8f2d8689dd21");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ef011558-218c-4433-94c4-459d6896a402");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f05caaea-9cc1-4bd4-93f3-2affab5ba95e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f16589af-5451-4efe-821c-3dd15932f3cb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fa2860e9-564b-4edd-a594-5bc7cecee549");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fb854fd3-0e77-4cd9-9f21-2dfca6e2b4fe");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fb88693c-8fb1-4ebd-9f3f-1c1072e51c30");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Seats",
                columns: new[] { "SeatID", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Hall", "IsAvailable", "LastUpdatedBy", "LastUpdatedTime", "Number", "Row" },
                values: new object[,]
                {
                    { "03c3f51b-392f-4539-aa26-7d5e4e6d80f3", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(240), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(241), 2, "D" },
                    { "04cf414f-e29f-4199-adbe-4cef4536a65f", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(424), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(428), 3, "E" },
                    { "05aede11-6960-4a2c-84f2-4de65774fdda", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(517), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(518), 5, "B" },
                    { "074edf97-49b6-4b90-a8b1-592aea30dade", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(172), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(174), 3, "C" },
                    { "0ab2eaec-4a94-4ac3-ac95-35b2a327dc74", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(400), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(402), 3, "D" },
                    { "0c1eb912-5677-40c5-b944-3f884cc754af", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(225), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(229), 5, "C" },
                    { "0f9f2b0e-d341-458e-b946-bbcbe052509b", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(550), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(552), 1, "D" },
                    { "10ec98c9-0e6f-4d0e-b543-1406bbe08298", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(520), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(522), 6, "B" },
                    { "13129f23-248e-49a3-98b7-239c422c273a", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(307), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(309), 6, "A" },
                    { "13c61006-e704-4361-b883-82372ae186a8", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(151), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(154), 4, "B" },
                    { "1a7ba2c2-df06-4fe8-ae0a-d1ff414f45d4", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(357), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(362), 5, "B" },
                    { "1c656be1-9e5f-41e2-9a2b-98d026ac3a3c", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(265), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(267), 2, "E" },
                    { "1d508d1c-4c33-465d-bb7e-a77a7d0abb91", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(391), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(395), 1, "D" },
                    { "1e1317d7-d84e-48d1-bb0e-e979867757f7", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(272), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(274), 4, "E" },
                    { "24b7fc97-4a38-42cb-8fee-174169ac0181", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(286), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(288), 1, "A" },
                    { "25465937-4c22-4c79-83fb-cb438d250347", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(364), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(365), 6, "B" },
                    { "2e64a8d6-619c-4b47-9fda-0c5678089898", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(380), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(382), 4, "C" },
                    { "326768f8-b6bf-4d19-934a-4c3d800ab41f", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(567), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(569), 5, "D" },
                    { "34fe61dc-3a98-48f3-86e6-71a38c4db378", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(541), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(545), 5, "C" },
                    { "35c5bb23-c3c2-4cfb-a60d-275401d9d694", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(446), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(448), 2, "A" },
                    { "40767d02-11a7-46c9-9f85-cc00d174a1d0", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(404), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(406), 4, "D" },
                    { "481f5e42-e3f1-4e8c-b8e9-8a9cbb73bd2c", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(371), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(373), 2, "C" },
                    { "49e72211-67df-492b-b710-31080dfdf021", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(311), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(315), 1, "B" },
                    { "4dce05e3-b5c0-42ae-871b-b80853a2cd9e", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(252), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(254), 5, "D" },
                    { "4e20b1e6-cfaa-4038-bc09-8f366823807f", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(563), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(565), 4, "D" },
                    { "554f0e74-43b7-497b-a57c-12c3b210d6e3", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(407), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(411), 5, "D" },
                    { "56c078b0-d59c-4d36-ba18-807b71ff390c", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(384), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(385), 5, "C" },
                    { "5830de96-f5a6-4b8e-8d66-3dbf5ef25da5", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(290), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(291), 2, "A" },
                    { "58df5687-a923-4e8c-9f1e-397b957a05b9", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(529), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(531), 2, "C" },
                    { "5f3bf3b4-5149-4f7d-aa6e-a7f4f2965874", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(175), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(223), 4, "C" },
                    { "60140b4f-1583-4ad2-a09b-e6fc0f812a0a", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(66), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(105), 1, "A" },
                    { "603d735e-2128-4be8-9dec-3b58d1d06259", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(507), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(511), 3, "B" },
                    { "605d87f2-867b-46f4-86fc-1d2aa9bc6703", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(630), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(632), 6, "E" },
                    { "638c1c1a-ce44-43ac-9429-60309fc382ba", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(580), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(582), 2, "E" },
                    { "63c98236-56d2-4070-8630-c85aee6057a1", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(558), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(561), 3, "D" },
                    { "6685dec4-9b88-4b9a-93d7-a874d7d9312b", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(119), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(121), 4, "A" },
                    { "6ba39e40-9a3f-4f8d-8407-502e1a18c0a0", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(624), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(628), 5, "E" },
                    { "6ca27927-206d-4cb1-a67f-293e0e8579ac", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(282), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(284), 6, "E" },
                    { "7446d91c-7e5c-4c96-a3cc-5acd17dc3de2", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(293), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(297), 3, "A" },
                    { "7563056b-217c-4818-9f50-3639f898b520", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(304), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(305), 5, "A" },
                    { "7689a273-a525-4ce2-9fec-436f1f8d2508", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(500), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(502), 1, "B" },
                    { "76b55521-0d5d-47e9-8d46-cb4c52c25b01", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(243), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(247), 3, "D" },
                    { "786e3755-d724-4dd2-a75d-36d1b3fcb100", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(320), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(322), 3, "B" },
                    { "798ec8c7-d67f-45a4-8384-e86c70419306", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(115), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(117), 3, "A" },
                    { "7e946b0d-153c-4532-a93c-b36200629d36", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(387), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(389), 6, "C" },
                    { "809135f3-45a7-456a-90de-2ad46ab81d1a", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(275), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(280), 5, "E" },
                    { "85eed7f9-176f-4e20-a3ba-1d9d3c8b7581", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(450), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(451), 3, "A" },
                    { "88a8f612-8ef6-407d-b57d-ec3c8220676d", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(133), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(135), 6, "A" },
                    { "88d4e081-e67e-492c-a9de-70fde8e3bbac", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(420), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(422), 2, "E" },
                    { "89c86dc8-cef7-489d-b707-90db7ecc8552", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(413), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(415), 6, "D" },
                    { "8ba1d6c5-973f-4762-83ed-b03b71d79c80", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(497), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(498), 6, "A" },
                    { "8deade89-8289-4ea3-a364-a533ecf891aa", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(249), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(250), 4, "D" },
                    { "8e00f6d2-7b9c-40bb-8b1f-387389ac52d0", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(533), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(535), 3, "C" },
                    { "8f11ac8d-b6ed-4809-bdb7-8e4aac7328a8", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(513), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(515), 4, "B" },
                    { "90c2ba47-6cdd-4b18-ba7f-4a896d4e2158", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(416), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(418), 1, "E" },
                    { "92487dcd-7667-456c-af9f-0aa28ae01307", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(159), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(161), 6, "B" },
                    { "9930d1fc-5ff7-45ae-8a1a-f52f4bb946e6", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(504), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(505), 2, "B" },
                    { "9b9161ed-9233-4a08-a92d-5e63520871cf", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(583), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(585), 3, "E" },
                    { "9c07ce09-c957-4fbc-bea0-d3f994dcc493", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(300), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(302), 4, "A" },
                    { "9e33c319-4a25-4a21-9e54-80aedbeb15b2", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(429), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(431), 4, "E" },
                    { "a6035c97-00b5-4790-b616-1ec190e0b9a6", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(554), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(556), 2, "D" },
                    { "a9648a5d-28f7-444f-bbb2-3a0cef0ded8c", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(433), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(435), 5, "E" },
                    { "ae14b5c4-0533-49b0-9d2e-0ea9d0094e95", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(110), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(113), 2, "A" },
                    { "af3d85d5-0c23-495b-8799-b0775c57251b", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(453), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(455), 4, "A" },
                    { "b0c53578-82aa-49c7-b69a-1fae52d17560", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(232), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(234), 6, "C" },
                    { "b6193d0a-f830-428c-8edf-853fabd5a7a8", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(155), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(157), 5, "B" },
                    { "baf5b690-6791-4a4f-bd5c-b61d7e0343ad", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(367), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(369), 1, "C" },
                    { "be66db13-8c71-46c6-b047-7ed5bc400c41", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(317), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(318), 2, "B" },
                    { "c11ffd51-d0f4-435e-a062-3e2f04867083", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(123), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(129), 5, "A" },
                    { "cb21d506-319a-406c-8e56-a56748ca9b4b", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(137), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(139), 1, "B" },
                    { "d4868198-79a9-41e6-a82b-013cb229d6f2", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(168), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(170), 2, "C" },
                    { "d7faf27c-b1e8-4ce3-8b30-0591cd3457ff", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(457), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(460), 5, "A" },
                    { "d8d4c6b2-bcd0-4fa9-80dc-194ccea26b1c", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(587), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(589), 4, "E" },
                    { "d9127566-7c18-45b2-a36a-39bc6088d407", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(141), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(143), 2, "B" },
                    { "d9204c2b-ac6f-4627-86a9-bf00bffd035d", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(354), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(356), 4, "B" },
                    { "d9cb7521-c2b6-44a9-9ece-e60fd77efcd1", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(397), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(398), 2, "D" },
                    { "e135b760-66a4-4239-84c1-1c40c494765d", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(574), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(578), 1, "E" },
                    { "e1a10a44-4d58-4134-9c65-5cc5a9889d92", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(268), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(270), 3, "E" },
                    { "e2072297-4675-4a40-9735-b7088d90a8b6", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(440), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(444), 1, "A" },
                    { "e26cfe03-8f11-49b4-8444-46989efee9ae", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(144), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(149), 3, "B" },
                    { "e38e45d9-49f6-4c85-b5b1-2e8e8b3e3855", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(163), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(167), 1, "C" },
                    { "e8c41825-084e-4313-a6ad-d11f7296da88", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(375), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(378), 3, "C" },
                    { "e9ae9084-403c-4383-b518-19192582c47e", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(236), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(238), 1, "D" },
                    { "ec0adaa5-bebf-4d25-9686-a65d7ddf2444", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(259), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(263), 1, "E" },
                    { "f28b9708-021d-449d-86e2-33c48cc47feb", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(537), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(539), 4, "C" },
                    { "f5ca6d6e-3842-4336-99e8-df3a30a0c104", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(547), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(548), 6, "C" },
                    { "f964b084-c025-470a-a1d3-6075654216a1", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(256), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(257), 6, "D" },
                    { "fa595788-a5b4-42f1-b74b-7885f6b7ed53", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(571), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(572), 6, "D" },
                    { "fd7599eb-3c19-4822-b073-c52c8cb99da0", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(524), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(528), 1, "C" },
                    { "ff12447e-227a-4879-a1af-54899c30b42b", "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(436), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 17, 6, 689, DateTimeKind.Local).AddTicks(438), 6, "E" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_TicketID",
                schema: "dbo",
                table: "OrderDetails",
                column: "TicketID",
                unique: true,
                filter: "[TicketID] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_TicketID",
                schema: "dbo",
                table: "OrderDetails");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "03c3f51b-392f-4539-aa26-7d5e4e6d80f3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "04cf414f-e29f-4199-adbe-4cef4536a65f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "05aede11-6960-4a2c-84f2-4de65774fdda");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "074edf97-49b6-4b90-a8b1-592aea30dade");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0ab2eaec-4a94-4ac3-ac95-35b2a327dc74");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0c1eb912-5677-40c5-b944-3f884cc754af");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0f9f2b0e-d341-458e-b946-bbcbe052509b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "10ec98c9-0e6f-4d0e-b543-1406bbe08298");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "13129f23-248e-49a3-98b7-239c422c273a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "13c61006-e704-4361-b883-82372ae186a8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1a7ba2c2-df06-4fe8-ae0a-d1ff414f45d4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1c656be1-9e5f-41e2-9a2b-98d026ac3a3c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1d508d1c-4c33-465d-bb7e-a77a7d0abb91");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1e1317d7-d84e-48d1-bb0e-e979867757f7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "24b7fc97-4a38-42cb-8fee-174169ac0181");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "25465937-4c22-4c79-83fb-cb438d250347");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2e64a8d6-619c-4b47-9fda-0c5678089898");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "326768f8-b6bf-4d19-934a-4c3d800ab41f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "34fe61dc-3a98-48f3-86e6-71a38c4db378");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "35c5bb23-c3c2-4cfb-a60d-275401d9d694");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "40767d02-11a7-46c9-9f85-cc00d174a1d0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "481f5e42-e3f1-4e8c-b8e9-8a9cbb73bd2c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "49e72211-67df-492b-b710-31080dfdf021");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4dce05e3-b5c0-42ae-871b-b80853a2cd9e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4e20b1e6-cfaa-4038-bc09-8f366823807f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "554f0e74-43b7-497b-a57c-12c3b210d6e3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "56c078b0-d59c-4d36-ba18-807b71ff390c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5830de96-f5a6-4b8e-8d66-3dbf5ef25da5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "58df5687-a923-4e8c-9f1e-397b957a05b9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5f3bf3b4-5149-4f7d-aa6e-a7f4f2965874");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "60140b4f-1583-4ad2-a09b-e6fc0f812a0a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "603d735e-2128-4be8-9dec-3b58d1d06259");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "605d87f2-867b-46f4-86fc-1d2aa9bc6703");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "638c1c1a-ce44-43ac-9429-60309fc382ba");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "63c98236-56d2-4070-8630-c85aee6057a1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6685dec4-9b88-4b9a-93d7-a874d7d9312b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6ba39e40-9a3f-4f8d-8407-502e1a18c0a0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6ca27927-206d-4cb1-a67f-293e0e8579ac");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7446d91c-7e5c-4c96-a3cc-5acd17dc3de2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7563056b-217c-4818-9f50-3639f898b520");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7689a273-a525-4ce2-9fec-436f1f8d2508");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "76b55521-0d5d-47e9-8d46-cb4c52c25b01");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "786e3755-d724-4dd2-a75d-36d1b3fcb100");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "798ec8c7-d67f-45a4-8384-e86c70419306");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7e946b0d-153c-4532-a93c-b36200629d36");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "809135f3-45a7-456a-90de-2ad46ab81d1a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "85eed7f9-176f-4e20-a3ba-1d9d3c8b7581");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "88a8f612-8ef6-407d-b57d-ec3c8220676d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "88d4e081-e67e-492c-a9de-70fde8e3bbac");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "89c86dc8-cef7-489d-b707-90db7ecc8552");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8ba1d6c5-973f-4762-83ed-b03b71d79c80");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8deade89-8289-4ea3-a364-a533ecf891aa");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8e00f6d2-7b9c-40bb-8b1f-387389ac52d0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8f11ac8d-b6ed-4809-bdb7-8e4aac7328a8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "90c2ba47-6cdd-4b18-ba7f-4a896d4e2158");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "92487dcd-7667-456c-af9f-0aa28ae01307");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9930d1fc-5ff7-45ae-8a1a-f52f4bb946e6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9b9161ed-9233-4a08-a92d-5e63520871cf");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9c07ce09-c957-4fbc-bea0-d3f994dcc493");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9e33c319-4a25-4a21-9e54-80aedbeb15b2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a6035c97-00b5-4790-b616-1ec190e0b9a6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a9648a5d-28f7-444f-bbb2-3a0cef0ded8c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ae14b5c4-0533-49b0-9d2e-0ea9d0094e95");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "af3d85d5-0c23-495b-8799-b0775c57251b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b0c53578-82aa-49c7-b69a-1fae52d17560");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b6193d0a-f830-428c-8edf-853fabd5a7a8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "baf5b690-6791-4a4f-bd5c-b61d7e0343ad");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "be66db13-8c71-46c6-b047-7ed5bc400c41");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c11ffd51-d0f4-435e-a062-3e2f04867083");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cb21d506-319a-406c-8e56-a56748ca9b4b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d4868198-79a9-41e6-a82b-013cb229d6f2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d7faf27c-b1e8-4ce3-8b30-0591cd3457ff");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d8d4c6b2-bcd0-4fa9-80dc-194ccea26b1c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d9127566-7c18-45b2-a36a-39bc6088d407");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d9204c2b-ac6f-4627-86a9-bf00bffd035d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d9cb7521-c2b6-44a9-9ece-e60fd77efcd1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e135b760-66a4-4239-84c1-1c40c494765d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e1a10a44-4d58-4134-9c65-5cc5a9889d92");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e2072297-4675-4a40-9735-b7088d90a8b6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e26cfe03-8f11-49b4-8444-46989efee9ae");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e38e45d9-49f6-4c85-b5b1-2e8e8b3e3855");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e8c41825-084e-4313-a6ad-d11f7296da88");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e9ae9084-403c-4383-b518-19192582c47e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ec0adaa5-bebf-4d25-9686-a65d7ddf2444");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f28b9708-021d-449d-86e2-33c48cc47feb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f5ca6d6e-3842-4336-99e8-df3a30a0c104");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f964b084-c025-470a-a1d3-6075654216a1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fa595788-a5b4-42f1-b74b-7885f6b7ed53");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fd7599eb-3c19-4822-b073-c52c8cb99da0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ff12447e-227a-4879-a1af-54899c30b42b");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Seats",
                columns: new[] { "SeatID", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Hall", "IsAvailable", "LastUpdatedBy", "LastUpdatedTime", "Number", "Row" },
                values: new object[,]
                {
                    { "0210af6d-1bf1-4b02-b20e-15bc93047238", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4339), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4340), 2, "A" },
                    { "04b10bf3-3b6b-4093-9727-b9ab925a9603", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4199), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4200), 2, "D" },
                    { "08201bb5-3493-436b-9edb-97b61a58eaa5", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4352), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4353), 6, "A" },
                    { "09116e3e-739f-499a-b7b0-6caba53071e2", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4249), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4250), 4, "A" },
                    { "0a7bd15e-2c3b-48f7-a417-5c46858f018f", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4335), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4336), 1, "A" },
                    { "0b7f747c-a968-4e73-bc27-93d87bee3e24", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4264), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4265), 3, "B" },
                    { "0fb74ebf-e3b4-4d51-9056-caeb62f29ea1", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4180), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4181), 2, "C" },
                    { "1152c0df-0fee-4506-a91d-444ebd699622", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4290), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4291), 6, "C" },
                    { "12507532-0cb1-4c11-bdc9-93efcf4c56c7", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4410), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4411), 6, "D" },
                    { "13770daf-bcbd-4367-b14f-3436014e079a", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4288), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4289), 5, "C" },
                    { "1962b7f2-bb90-42fa-bbd6-1ef42cbc20f2", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4162), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4164), 3, "B" },
                    { "1af8bfa8-1407-4310-befd-202f8c423856", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4327), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4328), 4, "E" },
                    { "1eb30210-e350-496f-92fa-176e3773240a", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4400), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4402), 3, "D" },
                    { "219fd8b6-01e4-46e0-b328-fd36d45f819c", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4130), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4132), 2, "A" },
                    { "21a6cffd-dbf7-4df6-88d0-cdce2ded77d3", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4175), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4176), 1, "C" },
                    { "226c45f6-b6d9-440d-afe5-748c5e91c765", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4167), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4169), 4, "B" },
                    { "23af1159-1c3b-4c27-917a-aa460cfc8728", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4213), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4215), 1, "E" },
                    { "2479a391-128a-4e9b-bbf5-e07c5afbc6e7", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4196), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4198), 1, "D" },
                    { "2b729118-62ef-4a6e-8138-37a7d8546d2d", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4310), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4311), 6, "D" },
                    { "3554e5c6-913c-4606-9f75-6622cec7c6dc", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4405), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4406), 4, "D" },
                    { "364c94a4-fa3c-48a4-b721-19a3b9ce8b9e", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4226), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4227), 5, "E" },
                    { "37bda974-ecdd-499d-bf30-932b9af2488a", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4412), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4414), 1, "E" },
                    { "3a0179f0-9cfc-4ced-a04d-6978beb98a68", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4305), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4306), 5, "D" },
                    { "3be18e7e-f7d6-4c2d-9a4a-3fba3588b865", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4390), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4391), 1, "D" },
                    { "3d04a182-a631-4462-a53d-524de5979c80", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4371), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4372), 1, "C" },
                    { "3edbbe49-446d-4f06-8830-16f8c696cb12", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4269), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4270), 5, "B" },
                    { "408006df-ac42-482b-8b23-c982e5b8ecb9", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4218), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4219), 2, "E" },
                    { "4102afef-f941-4adb-9a2c-2650ba9c47b4", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4230), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4232), 6, "E" },
                    { "42b08244-fdd8-4c5c-8838-7b4e3af2882a", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4254), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4255), 6, "A" },
                    { "470b8eea-95d9-4f5f-ac60-7bd421397a5b", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4136), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4138), 4, "A" },
                    { "48b2c635-fa2d-4a70-8432-b97dc169aec5", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4425), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4426), 5, "E" },
                    { "4c1a326e-29a9-4e33-a7d8-47ad3ba66249", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4183), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4184), 3, "C" },
                    { "4eb4a5af-727f-4adc-9828-d05afcce6534", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4173), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4174), 6, "B" },
                    { "4ec18e96-d848-4bb4-9c34-70266ba1dcdc", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4380), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4382), 4, "C" },
                    { "4ffdd95e-e0d2-4770-ad3f-da82bd221974", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4332), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4333), 6, "E" },
                    { "518518d6-8eb0-4d39-84ef-53c8b7e21416", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4329), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4331), 5, "E" },
                    { "56d1603c-0a50-41d8-98b5-614fb8cf3e30", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4364), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4365), 4, "B" },
                    { "5bcc8704-1e18-4e78-a17b-723b1e04ac40", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4266), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4268), 4, "B" },
                    { "63737557-a860-4adf-b444-9576f9a39708", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4236), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4237), 2, "A" },
                    { "6585711b-b0b1-49dc-beeb-26a96228bd67", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4139), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4141), 5, "A" },
                    { "673c03f6-a2d3-4dc1-8a3e-0bfa0c30bf48", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4312), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4314), 1, "E" },
                    { "6acfc822-9b0e-412e-af6b-17fed3169277", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4317), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4319), 3, "E" },
                    { "6c1913b5-a782-4766-a4fa-b67ac1fd4fed", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4392), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4394), 2, "D" },
                    { "6dc94229-5b30-440b-bebb-eb34a2a8e0ac", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4211), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4212), 6, "D" },
                    { "7209ecb8-2e1c-4511-b79e-3fb83ee164e0", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4315), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4316), 2, "E" },
                    { "72546212-a6ae-4fc0-8edb-37a82340efc0", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4293), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4294), 1, "D" },
                    { "744bb2ba-0197-4be3-92fa-d11c67097855", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4170), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4171), 5, "B" },
                    { "74cb64ec-97ac-48cf-9443-bce22f9c8198", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4375), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4377), 2, "C" },
                    { "76935bd2-8779-4d07-b1e9-ff5003bd4aeb", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4303), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4304), 4, "D" },
                    { "7cdd5bc9-5edf-495b-bcd1-a5b32d0fbb70", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4419), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4421), 3, "E" },
                    { "7e4859e3-0e0f-4aec-ad1a-fdce0fa536f1", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4429), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4430), 6, "E" },
                    { "7f03e123-8e2e-46a0-8ae8-64ccdcf5d193", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4297), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4299), 2, "D" },
                    { "8083c4cc-a2d0-4c1f-b51f-e5fd4fb1dc98", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4261), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4263), 2, "B" },
                    { "854ba8e9-a54b-448c-b4c7-286770ea24be", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4383), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4384), 5, "C" },
                    { "8a6226ac-3f0f-4816-889e-6435d169d083", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4347), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4348), 5, "A" },
                    { "8a791849-de62-44b4-ba51-762af24c5d1d", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4223), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4225), 4, "E" },
                    { "8a9492aa-4b1e-4080-8fc7-1564bbf27266", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4278), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4280), 2, "C" },
                    { "90a3a2ba-f03d-43ea-98b4-a2d5c3da30c5", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4273), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4275), 6, "B" },
                    { "91de2ccb-a0e3-4f8a-83de-015773c145c2", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4417), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4418), 2, "E" },
                    { "95ac8456-9399-4d00-9681-af5f4c5ca601", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4201), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4203), 3, "D" },
                    { "9c6a6621-6e45-4d0a-8ca7-ef7269f57aee", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4234), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4235), 1, "A" },
                    { "9d7abc72-4f29-4c71-9f69-dc9ec37824a8", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4208), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4209), 5, "D" },
                    { "a48752d5-c5f0-44a2-bfe4-d429ae6324d7", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4407), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4408), 5, "D" },
                    { "a69f626b-35f7-4353-9f49-a5687eccd897", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4194), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4195), 6, "C" },
                    { "a851f5dd-3816-4cba-9ef8-f7beb00c03c7", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4300), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4301), 3, "D" },
                    { "a8c412b8-ba1f-4776-844b-6a97e097ac8a", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4221), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4222), 3, "E" },
                    { "ac213600-ee7c-4eba-8102-0b2a235a9dd3", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4387), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4388), 6, "C" },
                    { "b76bd39a-a6cc-413d-9b64-e6a64e414eb9", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4133), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4135), 3, "A" },
                    { "bb9d9a2f-d3c1-4eaa-a989-b7f171b6896a", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4256), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4258), 1, "B" },
                    { "bdf98e84-418c-4903-9a5c-0b0f13bb0d5f", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4344), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4346), 4, "A" },
                    { "c4773719-da98-48eb-88df-b34747590745", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4097), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4118), 1, "A" },
                    { "cb511b3b-1c80-4a22-9ed1-aeb83f3a2bf5", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4244), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4245), 3, "A" },
                    { "cb6e700a-03ba-4067-ba37-48765f66065a", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4152), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4161), 2, "B" },
                    { "cbc58843-2f4f-4780-b7d1-3ff236e294cd", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4366), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4367), 5, "B" },
                    { "cc7f5d9a-e9be-48bc-b07c-10060d3b31d2", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4342), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4343), 3, "A" },
                    { "cec9ce12-cdf5-4ec0-ac0d-53aa88750a40", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4185), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4187), 4, "C" },
                    { "d11ada23-1a35-4ea2-b2ed-74584ac80eaf", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4251), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4252), 5, "A" },
                    { "d22095d1-48ee-49d5-9abb-96332d6acb78", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4357), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4358), 2, "B" },
                    { "d4aa48d2-fab8-4395-935a-3e3be051c656", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4206), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4207), 4, "D" },
                    { "d69ea9ce-1417-40fb-9c00-8bedf1ff0d65", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4285), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4286), 4, "C" },
                    { "d8f7d2bd-1316-4238-87a6-23c1f8fe3539", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4188), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4190), 5, "C" },
                    { "dbf6d3d3-2963-403c-a648-5f1b3a853c95", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4281), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4282), 3, "C" },
                    { "ded21d06-664b-4b31-aec2-03d626067371", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4378), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4379), 3, "C" },
                    { "e616c7d2-1ba9-4cc7-a521-8f2d8689dd21", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4149), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4151), 1, "B" },
                    { "ef011558-218c-4433-94c4-459d6896a402", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4369), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4370), 6, "B" },
                    { "f05caaea-9cc1-4bd4-93f3-2affab5ba95e", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4355), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4356), 1, "B" },
                    { "f16589af-5451-4efe-821c-3dd15932f3cb", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4146), null, null, "Alpha", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4148), 6, "A" },
                    { "fa2860e9-564b-4edd-a594-5bc7cecee549", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4359), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4361), 3, "B" },
                    { "fb854fd3-0e77-4cd9-9f21-2dfca6e2b4fe", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4276), null, null, "Beta", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4277), 1, "C" },
                    { "fb88693c-8fb1-4ebd-9f3f-1c1072e51c30", "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4422), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 5, 19, 17, 2, 535, DateTimeKind.Local).AddTicks(4424), 4, "E" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_TicketID",
                schema: "dbo",
                table: "OrderDetails",
                column: "TicketID");
        }
    }
}
