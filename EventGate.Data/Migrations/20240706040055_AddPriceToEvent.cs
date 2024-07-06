using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventGate.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPriceToEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Events",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "01696ffa-79b7-44dc-8e63-2f95f20e8d7b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "067cb13a-1a21-4c96-b987-7d007845add1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0bb9b6df-7e2b-4bb3-b06f-01d29c09ee6e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0c21dbab-a345-4b78-9349-6a417b5cc803");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0d46315c-7f3c-4e86-8e67-1e0ddff9b144");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "116f0535-cfc9-4a7a-a0ad-d9614884f58f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "117634f6-adba-4364-8011-636c8a34f0e2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "187e1d70-f7c3-4d03-85da-3386b4386ab6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "18df7665-681b-4953-a46c-3fcfc30013f9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1afc6bf1-dc1c-4963-a083-a47cd2531014");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1c7cf625-ca9b-4e79-b9af-1f7bd787ef78");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1da592a1-09a3-491f-a3db-311c4877d4f1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1dc77cf4-2070-4df9-8e24-4cc739c21dee");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1e7bd036-d519-4223-9601-e0b4532f805d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "20faa19a-4ac8-44c5-adf1-d861b1de4a06");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2566848b-a9a0-4a67-a91d-496f1674df87");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "28372964-ab90-44f5-9416-11abaaedf625");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2c47ac75-9014-416d-810b-96d438296c67");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "39680999-9e1b-46dc-8d39-3bfd6b720b3c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3b6a1825-03c0-453d-885c-e75fdc49a057");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3baccee9-6fe7-4773-b476-23410efc0de1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3c727b07-4745-43c7-b12e-ea7882e4e74b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3e416032-4a80-482f-a7c3-c2086821c2c3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3f07af4c-247c-4685-8419-33c69a446304");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4655c0c2-7a26-4e75-bfbc-16bd768443ed");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "48d6c598-e487-4bc7-abad-ffe98fe8ce26");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4b4d8d37-e696-4e07-aeb2-28d38c6118d6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4e5bf4d7-7f2e-467b-ad31-b28ea9898d4e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4f7870b9-a7ce-4f9e-9dc5-5aafafe21059");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4fcdda1f-a727-4b62-8c67-e047f4afd224");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "51a065ff-708b-4d8d-b02e-2be1309627ed");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "52c70ff9-345f-4b25-9297-4f10d6228e6f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "56472199-b03b-4fac-ae09-fe152b9dc59b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "56b8f022-6931-4811-8f57-e74cfd5e280d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5749daeb-63ea-40c2-982e-e882f3b22792");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "57cede2c-2981-4b64-8e31-8254455bd286");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "580db51b-0416-463c-be05-e55d0f73e32b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5872a0fc-cd0e-4e3c-bce8-7c343c064b66");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5b7b60b7-be58-46b1-be7a-8b1e671cdb4f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5f7080ae-1421-4c42-bed3-bb78cbb12de4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5fa44291-d6b8-445d-8166-d6068e6bbe5e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "63c62b59-bf88-481f-9d5a-b18d70e79722");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "640a252e-e722-452f-b071-c4404d95f8eb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "69e22450-6582-4fe8-b4ff-e929c6a2888c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6cda0e49-bd39-4f55-8a22-d6ca5ce3842a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6f337722-5b3a-4e6f-bed2-9a42f79cf1d6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7283b7be-98d6-493e-a2a1-375a5a4df44e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "739aac2d-bed7-48c7-8cc9-5117e664db89");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "747c1e0b-1336-45d1-9bcf-213308e1fcc6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "74f0b309-78e1-4ca6-bee3-4e3f39f7069c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7570044a-35c5-4748-a80e-bffcfc8607d5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "76e21f4a-0b4a-40bf-a667-236b0ad9e13c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7c2e6cab-ad8d-45ad-ab23-94ac265ff444");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8434922f-ef6c-49e0-ba43-dfbe35079157");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "864e45df-78d0-4712-9f1e-6e6cd699d2eb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "88c90ae8-29b0-423c-bdb8-0e102153c715");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8affed79-69ed-4c71-8b82-87f365530ad8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8d9bbcfe-41bf-49e8-9e2f-8c9be8768dd8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8dce0599-28a1-439c-98ac-a0d9ae8aa9d7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9174ce25-216f-469b-8259-8339342d4f4b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a01ca0d0-9e77-40d2-b1be-d5dfb1a67e1c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a46f5f73-b095-474e-8dd6-219ce2b9231a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a5c6d70a-f1bd-41ca-ac29-43fd28630b6a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "abb8857c-d5d5-4684-9e29-fcec6fb62446");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ad9cd57b-f7c8-48ed-8e52-32ddcd7a2389");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b005cc11-8387-4a58-b509-ca937a228454");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b28f43a2-fb57-4075-98a9-1fb41bfa8cb5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b46ae735-27eb-4c05-8c4b-54165f973b00");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b6f83197-fc01-45d4-bd96-07b733ed4579");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c0707fd5-efee-4574-a17d-921d4448d0fb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c91e89ec-135a-4353-bc56-1e6a52e2fa20");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ce2a84a8-4b78-487f-a5c4-60e4d59d4f60");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cf6219fa-9728-441a-875a-12b578016529");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d3e46aac-d3ad-4186-bb21-2baa8f224899");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d506d3bd-deb5-48cd-9d95-d78a0e8a46ef");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d762cb81-75ed-4325-98d5-81688465c80e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d8a10903-5cdb-4111-ac26-e60f7fabe267");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e13353c2-b751-48e3-b5d2-d098a721dd82");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e3ca17d5-07ad-4231-8feb-e6b58de35caa");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e696d51e-b5d1-439d-96c3-27ebbbe4a026");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e6fa90c2-8de3-4674-b052-0a624ff04f90");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e9cbcdd8-3f7d-46b5-8353-892ddb41e407");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "eb23e5e8-c1ae-4804-b1b3-6e0f79148817");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f1cd94cd-aaf9-4f7f-8968-516d14498ca6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f3653445-8482-4913-8d9b-6610b05982a5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f7e03c78-d6cc-4516-968e-c0b6581b5224");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f8c25508-1109-49aa-84a9-5e4cef8c2368");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fb14c2ee-e97b-402f-a3f4-cec56c40cab5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fd74d52f-3e97-4491-8564-a5d7874da701");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fe89663e-0faf-4b69-b3ed-43405c8dfa24");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Seats",
                columns: new[] { "SeatID", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Hall", "IsAvailable", "LastUpdatedBy", "LastUpdatedTime", "Number", "Row" },
                values: new object[,]
                {
                    { "03024ed9-42da-4c93-b564-13396b26ebb4", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1202), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1205), 4, "A" },
                    { "09a4975d-43b5-41b4-9ed5-4e4507507db4", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1320), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1321), 1, "B" },
                    { "0b2a9b06-89af-4f51-9dd3-7a78a8859b83", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1117), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1118), 5, "B" },
                    { "11c30853-93c8-4475-a83e-b7a87c84fb3f", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1188), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1191), 6, "E" },
                    { "14329b96-d271-45a7-8deb-186ea8155b3b", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1091), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1093), 5, "A" },
                    { "1765b23a-f5f6-48f7-acdb-bb7263218f55", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1209), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1210), 6, "A" },
                    { "1d135ec8-704f-401a-b820-6e4dd45843c7", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1377), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1380), 2, "E" },
                    { "23cb00df-e2ef-4a2e-a940-758743f10cf6", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1360), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1361), 2, "D" },
                    { "266451a8-b98a-4793-b2bc-f2446d67fdbb", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1325), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1326), 3, "B" },
                    { "28815cef-bc4c-4797-b46c-acc22d268b7c", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1164), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1167), 4, "D" },
                    { "29208a0e-5a2d-46b9-bb0a-26ad3404b5d9", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1293), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1294), 1, "A" },
                    { "2a010602-0841-4d90-9bf0-d541cea20109", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1302), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1303), 4, "A" },
                    { "2f1cbcea-6c3d-4b30-ad35-94f6062e02c4", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1283), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1286), 4, "E" },
                    { "306cf73d-8224-4600-9d61-faee6decff5b", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1334), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1335), 6, "B" },
                    { "36022bde-23c2-49e6-a819-743bc2af7ac3", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1344), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1345), 3, "C" },
                    { "3a3cad8f-2769-4741-8fdd-7852bb49b6fa", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1161), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1162), 3, "D" },
                    { "3abc2c8e-3075-41ca-8173-f4cb1e11d9fb", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1287), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1289), 5, "E" },
                    { "3ad2632e-65c8-4082-9d41-16fd7d2fce67", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1088), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1090), 4, "A" },
                    { "3da6683f-393a-4422-a680-8475bc068322", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1369), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1370), 5, "D" },
                    { "3f31959a-9e0c-4268-9162-41ae4c1589d1", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1278), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1279), 2, "E" },
                    { "3f9adb96-7e24-40d4-901f-570c6363e984", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1365), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1368), 4, "D" },
                    { "41b4fa99-d017-442d-8c14-5a63b5320440", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1322), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1323), 2, "B" },
                    { "41cfbc20-d3c2-4590-8cba-ff89b9e4dc9d", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1399), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1402), 6, "E" },
                    { "42f209a1-fd02-486a-8351-42617fcb871d", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1315), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1318), 6, "A" },
                    { "44388f75-46fd-4a0f-ab22-e84375d677d6", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1271), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1274), 6, "D" },
                    { "45e5301a-f02d-416c-b6be-acb3c255b6e6", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1122), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1124), 1, "C" },
                    { "462c0d80-1167-4878-8051-6cbb5a503642", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1112), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1115), 4, "B" },
                    { "4abf6ad7-a939-41d7-9d82-33d87cbac8d3", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1214), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1225), 2, "B" },
                    { "4c41a1ad-a437-4256-b05c-c43cec29d7b8", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1347), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1348), 4, "C" },
                    { "5084128f-2805-402a-b725-601632cb6b2b", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1229), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1230), 4, "B" },
                    { "513c74e7-c9b3-46c3-a0a8-f3aff8a2a0c1", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1362), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1364), 3, "D" },
                    { "51475f36-2c47-4c17-995b-cf3c8728d98d", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1332), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1333), 5, "B" },
                    { "51a28100-7a86-4c5b-a405-a60265ae969a", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1176), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1179), 2, "E" },
                    { "54e9339f-a427-46d4-a952-185376edc10b", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1198), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1199), 3, "A" },
                    { "556bb5a0-cb3b-4f80-bfca-d25115e5a75b", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1254), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1255), 6, "C" },
                    { "56c23027-f68e-468f-a6cc-6599f9e34115", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1038), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1067), 1, "A" },
                    { "56c38450-d016-4db9-9048-3303b697c563", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1241), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1243), 2, "C" },
                    { "5923d251-2ce3-4cd0-8b5b-ec143facef9a", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1352), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1355), 6, "C" },
                    { "5b21047a-0577-414b-8336-d0c343c35ddd", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1281), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1282), 3, "E" },
                    { "5cc47419-3986-4422-945a-66b816a95897", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1340), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1343), 2, "C" },
                    { "60c3b85a-4cf4-40a9-9e24-91e080383749", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1396), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1397), 5, "E" },
                    { "64d0903f-646f-48c3-9b7a-cd9071084920", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1193), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1194), 1, "A" },
                    { "653b3f4e-ed11-4848-bfba-6a298572a9ac", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1105), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1107), 2, "B" },
                    { "6b102806-73a9-4dfc-a05c-bec8ddf94169", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1256), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1258), 1, "D" },
                    { "6bbba191-b7c0-44a8-9f77-93a475952827", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1372), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1373), 6, "D" },
                    { "71ed7dd7-3047-4a3b-9b4d-6a6d691c0908", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1171), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1172), 6, "D" },
                    { "74e59411-00c7-4b6f-a6f0-9353ab7848b2", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1268), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1270), 5, "D" },
                    { "7ad1a82c-6234-44e4-8e31-21635dcd43c1", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1195), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1197), 2, "A" },
                    { "82381da1-b9dd-4fe5-a581-6f0758422532", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1183), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1184), 4, "E" },
                    { "8254a41c-c88d-4f03-a8e3-92d24a75abd9", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1085), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1087), 3, "A" },
                    { "86166cc8-6429-41e2-8cee-bec3ba932168", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1232), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1233), 5, "B" },
                    { "8c6120d3-bf6c-4aaf-92b3-b9f018e6e53e", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1212), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1213), 1, "B" },
                    { "8ee3a14c-cdc2-42a0-b0b3-a8a727151435", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1148), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1149), 5, "C" },
                    { "8f71b71f-4614-4fe4-99c6-7bad93f6d1b1", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1156), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1157), 1, "D" },
                    { "91e60720-5069-4a15-8261-d6cd6e6c6b91", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1357), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1358), 1, "D" },
                    { "9291ad6f-0a88-4aec-b74b-6f1de5db9173", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1247), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1250), 4, "C" },
                    { "9f682f1f-1bb4-40bb-9f25-6b53cb91dd52", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1108), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1110), 3, "B" },
                    { "a338b3db-c557-492b-96c4-0b44b9520ef9", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1295), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1298), 2, "A" },
                    { "a6b4f65d-88cf-4686-a44c-d44c49f8e63a", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1097), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1100), 6, "A" },
                    { "a810b07e-ade3-4ab3-ae63-63209bb9d63c", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1374), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1376), 1, "E" },
                    { "aa32cc63-fee9-4881-8166-175ca1240346", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1226), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1228), 3, "B" },
                    { "ab0685b9-d034-442a-8796-e1f48fe5f09e", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1299), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1301), 3, "A" },
                    { "b4260ebb-c03b-4532-9c16-1fa1b5aa0036", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1234), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1237), 6, "B" },
                    { "b4d9d28e-8342-45ae-8f3d-c54d0282140a", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1145), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1146), 4, "C" },
                    { "bb7ec23e-9d2c-4526-a62d-3ddad76f3117", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1125), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1128), 2, "C" },
                    { "c0175b2a-97c8-45e1-9683-7f841fa676c0", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1290), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1291), 6, "E" },
                    { "c5026618-88f9-4d2c-93d1-2469a9f86e77", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1102), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1104), 1, "B" },
                    { "c7a8fdb0-458b-4836-a909-2cf530d328b4", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1120), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1121), 6, "B" },
                    { "ccfff026-c758-4534-a642-cf293c75f9b3", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1337), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1338), 1, "C" },
                    { "cf99eb85-569c-42d9-9b60-9bdeb37dc9c3", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1266), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1267), 4, "D" },
                    { "d351514b-87fd-479d-a36c-134c9879ee1b", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1142), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1144), 3, "C" },
                    { "d3e17bd7-b7f1-4f0d-a150-e0e9e2500f51", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1275), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1277), 1, "E" },
                    { "d5a06152-805b-4353-8774-eacd727c6f24", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1071), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1083), 2, "A" },
                    { "d94ae281-f1c8-4caf-bc17-e66241c0c1c2", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1263), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1264), 3, "D" },
                    { "daa69dc3-66a4-4a5d-ba24-752281698881", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1381), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1392), 3, "E" },
                    { "ddaa41c6-5f7c-41d8-adb1-e2d683ff5847", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1244), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1245), 3, "C" },
                    { "dffbabc9-f270-446e-9a2a-d691db502c05", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1259), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1262), 2, "D" },
                    { "e1512622-4661-484c-b40f-328578cd04bc", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1185), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1187), 5, "E" },
                    { "e1daad96-aae8-4687-9c3b-4f49a276f3f9", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1168), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1170), 5, "D" },
                    { "e232c199-971f-4bef-a003-e917186a1357", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1251), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1252), 5, "C" },
                    { "e25cc4de-6ea4-4a7b-9124-b91582efa63c", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1349), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1351), 5, "C" },
                    { "e42c9850-d94f-442f-9fb1-e52cddd9d4cc", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1207), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1208), 5, "A" },
                    { "e6d8d633-a19c-4007-b69b-cbcec36d0736", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1239), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1240), 1, "C" },
                    { "e7be9c2e-c2e6-4e68-ba55-32be179c9a81", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1174), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1175), 1, "E" },
                    { "e809ffa4-2aea-4349-a213-b31c77b6d0d9", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1180), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1182), 3, "E" },
                    { "e947290d-f984-42f6-a222-78d9f4206d76", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1327), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1330), 4, "B" },
                    { "e97f8815-3089-44ad-a5d3-3d6fe8f4419a", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1393), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1395), 4, "E" },
                    { "f6c98e40-d172-4c21-8463-67db86f70a4f", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1151), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1155), 6, "C" },
                    { "fa6f8b16-3b98-4ad2-b8fd-e37e89342d91", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1311), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1312), 5, "A" },
                    { "fdb38f24-c506-4f7b-8dff-d3ab5b50c8a7", "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1159), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 11, 0, 54, 470, DateTimeKind.Local).AddTicks(1160), 2, "D" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Events");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "03024ed9-42da-4c93-b564-13396b26ebb4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "09a4975d-43b5-41b4-9ed5-4e4507507db4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0b2a9b06-89af-4f51-9dd3-7a78a8859b83");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "11c30853-93c8-4475-a83e-b7a87c84fb3f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "14329b96-d271-45a7-8deb-186ea8155b3b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1765b23a-f5f6-48f7-acdb-bb7263218f55");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1d135ec8-704f-401a-b820-6e4dd45843c7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "23cb00df-e2ef-4a2e-a940-758743f10cf6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "266451a8-b98a-4793-b2bc-f2446d67fdbb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "28815cef-bc4c-4797-b46c-acc22d268b7c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "29208a0e-5a2d-46b9-bb0a-26ad3404b5d9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2a010602-0841-4d90-9bf0-d541cea20109");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2f1cbcea-6c3d-4b30-ad35-94f6062e02c4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "306cf73d-8224-4600-9d61-faee6decff5b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "36022bde-23c2-49e6-a819-743bc2af7ac3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3a3cad8f-2769-4741-8fdd-7852bb49b6fa");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3abc2c8e-3075-41ca-8173-f4cb1e11d9fb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3ad2632e-65c8-4082-9d41-16fd7d2fce67");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3da6683f-393a-4422-a680-8475bc068322");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3f31959a-9e0c-4268-9162-41ae4c1589d1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3f9adb96-7e24-40d4-901f-570c6363e984");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "41b4fa99-d017-442d-8c14-5a63b5320440");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "41cfbc20-d3c2-4590-8cba-ff89b9e4dc9d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "42f209a1-fd02-486a-8351-42617fcb871d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "44388f75-46fd-4a0f-ab22-e84375d677d6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "45e5301a-f02d-416c-b6be-acb3c255b6e6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "462c0d80-1167-4878-8051-6cbb5a503642");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4abf6ad7-a939-41d7-9d82-33d87cbac8d3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4c41a1ad-a437-4256-b05c-c43cec29d7b8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5084128f-2805-402a-b725-601632cb6b2b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "513c74e7-c9b3-46c3-a0a8-f3aff8a2a0c1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "51475f36-2c47-4c17-995b-cf3c8728d98d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "51a28100-7a86-4c5b-a405-a60265ae969a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "54e9339f-a427-46d4-a952-185376edc10b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "556bb5a0-cb3b-4f80-bfca-d25115e5a75b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "56c23027-f68e-468f-a6cc-6599f9e34115");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "56c38450-d016-4db9-9048-3303b697c563");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5923d251-2ce3-4cd0-8b5b-ec143facef9a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5b21047a-0577-414b-8336-d0c343c35ddd");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5cc47419-3986-4422-945a-66b816a95897");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "60c3b85a-4cf4-40a9-9e24-91e080383749");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "64d0903f-646f-48c3-9b7a-cd9071084920");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "653b3f4e-ed11-4848-bfba-6a298572a9ac");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6b102806-73a9-4dfc-a05c-bec8ddf94169");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6bbba191-b7c0-44a8-9f77-93a475952827");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "71ed7dd7-3047-4a3b-9b4d-6a6d691c0908");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "74e59411-00c7-4b6f-a6f0-9353ab7848b2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7ad1a82c-6234-44e4-8e31-21635dcd43c1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "82381da1-b9dd-4fe5-a581-6f0758422532");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8254a41c-c88d-4f03-a8e3-92d24a75abd9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "86166cc8-6429-41e2-8cee-bec3ba932168");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8c6120d3-bf6c-4aaf-92b3-b9f018e6e53e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8ee3a14c-cdc2-42a0-b0b3-a8a727151435");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8f71b71f-4614-4fe4-99c6-7bad93f6d1b1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "91e60720-5069-4a15-8261-d6cd6e6c6b91");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9291ad6f-0a88-4aec-b74b-6f1de5db9173");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9f682f1f-1bb4-40bb-9f25-6b53cb91dd52");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a338b3db-c557-492b-96c4-0b44b9520ef9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a6b4f65d-88cf-4686-a44c-d44c49f8e63a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a810b07e-ade3-4ab3-ae63-63209bb9d63c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "aa32cc63-fee9-4881-8166-175ca1240346");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ab0685b9-d034-442a-8796-e1f48fe5f09e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b4260ebb-c03b-4532-9c16-1fa1b5aa0036");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b4d9d28e-8342-45ae-8f3d-c54d0282140a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "bb7ec23e-9d2c-4526-a62d-3ddad76f3117");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c0175b2a-97c8-45e1-9683-7f841fa676c0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c5026618-88f9-4d2c-93d1-2469a9f86e77");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c7a8fdb0-458b-4836-a909-2cf530d328b4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ccfff026-c758-4534-a642-cf293c75f9b3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cf99eb85-569c-42d9-9b60-9bdeb37dc9c3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d351514b-87fd-479d-a36c-134c9879ee1b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d3e17bd7-b7f1-4f0d-a150-e0e9e2500f51");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d5a06152-805b-4353-8774-eacd727c6f24");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d94ae281-f1c8-4caf-bc17-e66241c0c1c2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "daa69dc3-66a4-4a5d-ba24-752281698881");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ddaa41c6-5f7c-41d8-adb1-e2d683ff5847");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "dffbabc9-f270-446e-9a2a-d691db502c05");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e1512622-4661-484c-b40f-328578cd04bc");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e1daad96-aae8-4687-9c3b-4f49a276f3f9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e232c199-971f-4bef-a003-e917186a1357");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e25cc4de-6ea4-4a7b-9124-b91582efa63c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e42c9850-d94f-442f-9fb1-e52cddd9d4cc");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e6d8d633-a19c-4007-b69b-cbcec36d0736");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e7be9c2e-c2e6-4e68-ba55-32be179c9a81");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e809ffa4-2aea-4349-a213-b31c77b6d0d9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e947290d-f984-42f6-a222-78d9f4206d76");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e97f8815-3089-44ad-a5d3-3d6fe8f4419a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f6c98e40-d172-4c21-8463-67db86f70a4f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fa6f8b16-3b98-4ad2-b8fd-e37e89342d91");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fdb38f24-c506-4f7b-8dff-d3ab5b50c8a7");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Seats",
                columns: new[] { "SeatID", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Hall", "IsAvailable", "LastUpdatedBy", "LastUpdatedTime", "Number", "Row" },
                values: new object[,]
                {
                    { "01696ffa-79b7-44dc-8e63-2f95f20e8d7b", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4140), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4141), 2, "A" },
                    { "067cb13a-1a21-4c96-b987-7d007845add1", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4070), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4072), 6, "B" },
                    { "0bb9b6df-7e2b-4bb3-b06f-01d29c09ee6e", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3913), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3915), 1, "B" },
                    { "0c21dbab-a345-4b78-9349-6a417b5cc803", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4228), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4230), 5, "E" },
                    { "0d46315c-7f3c-4e86-8e67-1e0ddff9b144", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4149), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4151), 5, "A" },
                    { "116f0535-cfc9-4a7a-a0ad-d9614884f58f", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4031), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4033), 5, "E" },
                    { "117634f6-adba-4364-8011-636c8a34f0e2", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4039), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4040), 2, "A" },
                    { "187e1d70-f7c3-4d03-85da-3386b4386ab6", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4217), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4218), 1, "E" },
                    { "18df7665-681b-4953-a46c-3fcfc30013f9", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3934), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3936), 1, "C" },
                    { "1afc6bf1-dc1c-4963-a083-a47cd2531014", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4049), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4050), 5, "A" },
                    { "1c7cf625-ca9b-4e79-b9af-1f7bd787ef78", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4124), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4125), 3, "E" },
                    { "1da592a1-09a3-491f-a3db-311c4877d4f1", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4061), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4062), 3, "B" },
                    { "1dc77cf4-2070-4df9-8e24-4cc739c21dee", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4047), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4048), 4, "A" },
                    { "1e7bd036-d519-4223-9601-e0b4532f805d", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4189), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4190), 4, "C" },
                    { "20faa19a-4ac8-44c5-adf1-d861b1de4a06", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3965), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3966), 5, "D" },
                    { "2566848b-a9a0-4a67-a91d-496f1674df87", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4132), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4133), 6, "E" },
                    { "28372964-ab90-44f5-9416-11abaaedf625", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3898), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3900), 3, "A" },
                    { "2c47ac75-9014-416d-810b-96d438296c67", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3924), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3926), 4, "B" },
                    { "39680999-9e1b-46dc-8d39-3bfd6b720b3c", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4024), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4025), 3, "E" },
                    { "3b6a1825-03c0-453d-885c-e75fdc49a057", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4080), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4081), 3, "C" },
                    { "3baccee9-6fe7-4773-b476-23410efc0de1", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4201), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4202), 2, "D" },
                    { "3c727b07-4745-43c7-b12e-ea7882e4e74b", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4114), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4116), 6, "D" },
                    { "3e416032-4a80-482f-a7c3-c2086821c2c3", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4068), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4069), 5, "B" },
                    { "3f07af4c-247c-4685-8419-33c69a446304", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3916), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3917), 2, "B" },
                    { "4655c0c2-7a26-4e75-bfbc-16bd768443ed", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4177), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4178), 6, "B" },
                    { "48d6c598-e487-4bc7-abad-ffe98fe8ce26", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4193), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4194), 5, "C" },
                    { "4b4d8d37-e696-4e07-aeb2-28d38c6118d6", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4153), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4154), 6, "A" },
                    { "4e5bf4d7-7f2e-467b-ad31-b28ea9898d4e", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4043), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4045), 3, "A" },
                    { "4f7870b9-a7ce-4f9e-9dc5-5aafafe21059", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4212), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4214), 6, "D" },
                    { "4fcdda1f-a727-4b62-8c67-e047f4afd224", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4219), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4220), 2, "E" },
                    { "51a065ff-708b-4d8d-b02e-2be1309627ed", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4165), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4166), 4, "B" },
                    { "52c70ff9-345f-4b25-9297-4f10d6228e6f", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3870), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3891), 1, "A" },
                    { "56472199-b03b-4fac-ae09-fe152b9dc59b", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3910), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3912), 6, "A" },
                    { "56b8f022-6931-4811-8f57-e74cfd5e280d", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4105), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4106), 3, "D" },
                    { "5749daeb-63ea-40c2-982e-e882f3b22792", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4137), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4138), 1, "A" },
                    { "57cede2c-2981-4b64-8e31-8254455bd286", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4085), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4086), 5, "C" },
                    { "580db51b-0416-463c-be05-e55d0f73e32b", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4174), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4175), 5, "B" },
                    { "5872a0fc-cd0e-4e3c-bce8-7c343c064b66", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3937), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3938), 2, "C" },
                    { "5b7b60b7-be58-46b1-be7a-8b1e671cdb4f", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4073), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4074), 1, "C" },
                    { "5f7080ae-1421-4c42-bed3-bb78cbb12de4", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4129), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4131), 5, "E" },
                    { "5fa44291-d6b8-445d-8166-d6068e6bbe5e", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3927), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3928), 5, "B" },
                    { "63c62b59-bf88-481f-9d5a-b18d70e79722", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3920), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3922), 3, "B" },
                    { "640a252e-e722-452f-b071-c4404d95f8eb", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4102), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4103), 2, "D" },
                    { "69e22450-6582-4fe8-b4ff-e929c6a2888c", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3942), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3943), 4, "C" },
                    { "6cda0e49-bd39-4f55-8a22-d6ca5ce3842a", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3979), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3980), 1, "E" },
                    { "6f337722-5b3a-4e6f-bed2-9a42f79cf1d6", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4058), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4060), 2, "B" },
                    { "7283b7be-98d6-493e-a2a1-375a5a4df44e", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4222), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4223), 3, "E" },
                    { "739aac2d-bed7-48c7-8cc9-5117e664db89", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3955), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3956), 2, "D" },
                    { "747c1e0b-1336-45d1-9bcf-213308e1fcc6", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3946), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3948), 5, "C" },
                    { "74f0b309-78e1-4ca6-bee3-4e3f39f7069c", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4184), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4185), 2, "C" },
                    { "7570044a-35c5-4748-a80e-bffcfc8607d5", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4142), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4143), 3, "A" },
                    { "76e21f4a-0b4a-40bf-a667-236b0ad9e13c", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4126), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4128), 4, "E" },
                    { "7c2e6cab-ad8d-45ad-ab23-94ac265ff444", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3939), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3941), 3, "C" },
                    { "8434922f-ef6c-49e0-ba43-dfbe35079157", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4112), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4113), 5, "D" },
                    { "864e45df-78d0-4712-9f1e-6e6cd699d2eb", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4196), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4197), 6, "C" },
                    { "88c90ae8-29b0-423c-bdb8-0e102153c715", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4087), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4097), 6, "C" },
                    { "8affed79-69ed-4c71-8b82-87f365530ad8", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4034), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4035), 6, "E" },
                    { "8d9bbcfe-41bf-49e8-9e2f-8c9be8768dd8", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4082), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4084), 4, "C" },
                    { "8dce0599-28a1-439c-98ac-a0d9ae8aa9d7", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3962), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3963), 4, "D" },
                    { "9174ce25-216f-469b-8259-8339342d4f4b", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4158), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4159), 2, "B" },
                    { "a01ca0d0-9e77-40d2-b1be-d5dfb1a67e1c", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4181), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4182), 1, "C" },
                    { "a46f5f73-b095-474e-8dd6-219ce2b9231a", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4210), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4211), 5, "D" },
                    { "a5c6d70a-f1bd-41ca-ac29-43fd28630b6a", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4117), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4118), 1, "E" },
                    { "abb8857c-d5d5-4684-9e29-fcec6fb62446", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4156), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4157), 1, "B" },
                    { "ad9cd57b-f7c8-48ed-8e52-32ddcd7a2389", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4075), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4077), 2, "C" },
                    { "b005cc11-8387-4a58-b509-ca937a228454", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3959), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3961), 3, "D" },
                    { "b28f43a2-fb57-4075-98a9-1fb41bfa8cb5", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3974), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3976), 6, "D" },
                    { "b46ae735-27eb-4c05-8c4b-54165f973b00", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4021), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4022), 2, "E" },
                    { "b6f83197-fc01-45d4-bd96-07b733ed4579", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4120), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4121), 2, "E" },
                    { "c0707fd5-efee-4574-a17d-921d4448d0fb", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4186), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4187), 3, "C" },
                    { "c91e89ec-135a-4353-bc56-1e6a52e2fa20", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4205), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4206), 3, "D" },
                    { "ce2a84a8-4b78-487f-a5c4-60e4d59d4f60", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3930), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3931), 6, "B" },
                    { "cf6219fa-9728-441a-875a-12b578016529", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4056), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4057), 1, "B" },
                    { "d3e46aac-d3ad-4186-bb21-2baa8f224899", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4027), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4028), 4, "E" },
                    { "d506d3bd-deb5-48cd-9d95-d78a0e8a46ef", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4052), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4053), 6, "A" },
                    { "d762cb81-75ed-4325-98d5-81688465c80e", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4063), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4065), 4, "B" },
                    { "d8a10903-5cdb-4111-ac26-e60f7fabe267", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4198), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4200), 1, "D" },
                    { "e13353c2-b751-48e3-b5d2-d098a721dd82", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3950), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3951), 6, "C" },
                    { "e3ca17d5-07ad-4231-8feb-e6b58de35caa", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4162), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4163), 3, "B" },
                    { "e696d51e-b5d1-439d-96c3-27ebbbe4a026", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4100), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4101), 1, "D" },
                    { "e6fa90c2-8de3-4674-b052-0a624ff04f90", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3901), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3902), 4, "A" },
                    { "e9cbcdd8-3f7d-46b5-8353-892ddb41e407", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3906), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3908), 5, "A" },
                    { "eb23e5e8-c1ae-4804-b1b3-6e0f79148817", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4207), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4209), 4, "D" },
                    { "f1cd94cd-aaf9-4f7f-8968-516d14498ca6", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3952), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3954), 1, "D" },
                    { "f3653445-8482-4913-8d9b-6610b05982a5", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4231), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4232), 6, "E" },
                    { "f7e03c78-d6cc-4516-968e-c0b6581b5224", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4107), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4108), 4, "D" },
                    { "f8c25508-1109-49aa-84a9-5e4cef8c2368", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4037), null, null, "Beta", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4038), 1, "A" },
                    { "fb14c2ee-e97b-402f-a3f4-cec56c40cab5", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4145), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4146), 4, "A" },
                    { "fd74d52f-3e97-4491-8564-a5d7874da701", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4224), null, null, "Ceasar", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(4226), 4, "E" },
                    { "fe89663e-0faf-4b69-b3ed-43405c8dfa24", "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3894), null, null, "Alpha", true, "System", new DateTime(2024, 7, 6, 10, 40, 19, 180, DateTimeKind.Local).AddTicks(3896), 2, "A" }
                });
        }
    }
}
