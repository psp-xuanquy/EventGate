using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventGate.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixForeignKeyIssues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "03b5de17-8775-44a3-89df-c7f309a92747");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "084d8589-ebe8-42ba-b7da-be0c6f4f1df6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "08fb7a61-5c14-49c0-82e4-af8e457e599f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "090d4732-b5e8-43fb-ba53-ddbd9480ccc8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0a27d6c2-d78c-4e00-86c2-09c26bd68cdf");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0b21fddb-4530-4f84-9f3a-b2da21af68b3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0e1b7de2-2025-4a86-8236-d6a53fa413df");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0e7288e3-f6f1-41d9-95b4-5e85cff6e815");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0ea12419-77a3-4a92-ab84-4da54d402a1a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "15595ea6-4185-4ea1-89bd-c374d74c5031");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "184a7e9a-df93-44e4-9b78-8c9ece9fedf5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1a5ff9f6-bdf7-4963-87b0-1de4a9bed12a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1b7711a7-de7e-4e46-81a1-4a9ba22045df");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1c1a094b-39c4-4b29-a927-c407a256e698");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "295101e3-9d15-43ff-8e61-adc59f015da4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "297a610f-bb14-46fe-9da3-7129e91139b2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2d2da7a6-0729-490f-abf2-ea4be81ced27");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2ec5e7ff-8acb-4463-87fb-35d99c5dd04d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "303c4054-a5f0-4eb3-b6be-1650e29fe148");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3464da66-bcd4-41b3-b506-12d3343f7106");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "34f68475-f68b-4f0b-afe2-e87064a0816d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "37374455-ea57-4aa7-8859-0e1aa5b16ec8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "37f39261-ddd5-4493-af33-a94e40f0a49a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3c41e003-1ebc-47b2-bbb1-4d3c854d7fb0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3ec8aab0-ec1d-4335-ac2b-6e2afc151d06");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "413a309b-8f79-4cbc-bec1-ed7ffd0e960c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "416ddd6a-d93f-48aa-8e27-c81cd42e5aba");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "43813a41-5ba2-4179-868a-77c299f0877e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "45c00867-188f-4198-bd28-7f437c43f13f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4d8a3545-85be-4690-b61a-031fa7675cfe");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4df88e2b-d363-47ac-a975-7228fba1ee33");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4e2f6e66-d83a-4009-973d-eca5638bbc09");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4ef34e12-17db-4413-b94f-b93dbf8e3e5a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "503fd13e-5e88-4fd4-bd89-6dd47eb25e08");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "548c1f47-7049-4f8a-9277-a0995e268a4b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "55864e9f-c58c-4148-b739-21a447e2a419");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5abad2de-45a5-4e4c-9242-52e978779912");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5b44a4a0-724a-4475-be19-9af3e5b5d781");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "60e18322-5beb-40a8-9864-9babae5bcd13");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "63e21617-048c-46cf-b0cf-aebb1883d661");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "67acc6af-842e-4655-9651-5943c5880e36");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6b5f08a1-0f41-4049-9736-11495dc734ca");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7323dbd1-e55f-4a52-8097-fb99dd6d62d3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7633a623-bb8c-402d-b182-cb76616ecc97");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "77cc2734-93dd-4b82-896e-3281a0793ed4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7a62f69e-2851-42da-a4a7-70b979122ce0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7a9cd02b-8224-4371-b35b-21d0ea73caf0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "81ca41cf-5a20-4e86-aebb-d8ea10ef4781");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "84aad58a-056c-4ad6-8cd4-66254d998f8b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8846ae11-a95b-4231-b0b3-0f567024d175");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8b196eb9-73b0-460c-afd9-3231d689c712");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8bca4a69-2ceb-442c-8a00-62e507c8bcfe");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8d12ac3a-ce8f-4b1a-897c-cfd852fffee6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8dea9130-a249-42fa-863b-7156aa48fd3f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "93fadeca-86c4-4e5b-acb1-8653900665a0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9ad4025e-592b-4dbe-a316-c8e72cb84931");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a25114be-63d7-4037-80d6-3278541787d1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a561bee4-0517-435c-b01a-c7ca130ac980");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a5df0c86-e1f9-4b70-929d-e87817bd08b8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a87ded43-522b-495a-967f-6c149bdf7bf7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ad0fc90d-df7a-44bd-8faa-68e1e6a4fcac");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "adb592ff-ba76-448b-89a2-43c7d13f7805");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "afd4c37d-b9b5-4e44-9d69-1b0cdf9be7cb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b3806383-d412-4bd4-8fb7-aedb9e1fa04d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b43b2bfe-8944-4696-99a0-76e51093e775");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b59e9666-d4ce-4534-9ab4-e559de390844");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b6cc6121-af8a-4e3b-9dcb-97eb99386524");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b8de0cf5-3466-4682-942a-f6de0e5d7058");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c209a90b-2ee2-4a6e-b047-84caf69b889f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c6f617bf-107a-4a0e-85af-37ebb64b80ec");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ca1154c7-c41d-460d-a4e1-e74703e0ecef");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cc7f736e-1f20-4a22-8772-aedd65f68c41");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ced6579e-a311-46a7-a8bb-8d7843519a94");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d12a3d07-7b10-43cf-acf9-fa6b97df883e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d168a96b-2b14-4250-b47e-46bceeccf66e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d1909cc8-c352-4456-bcbc-d3cb15bfb875");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d6d3f0f4-5a46-462b-a383-749f0f259758");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ddb30cc5-6884-4dcc-8d58-194d708212be");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "dddaa59c-392e-463d-adbf-ea1abf66755b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e092b7cc-89f1-46b8-9974-a22860436a72");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e9870308-f6f0-44f0-9c71-227e74f06335");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ea7233f5-fecf-446a-9698-d53d3162e1c6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ec32586c-2327-42d2-a333-9603b07a772c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ecc80755-793b-45b7-bc30-7946db3535ea");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f287a92e-00cd-4c06-a0ee-29f4ae20cc55");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f9c9b0c0-7ac3-4c9d-a057-e2f67a6925ad");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fb5f3a56-33ab-4967-8ee7-2ff0dcb44093");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fc3d4bb2-79b4-431d-9251-7f0c4cd8b108");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fd122336-7ec3-46b0-828c-fda54902e3d0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ff318c0e-7012-45f2-91e4-5c56cd3d717f");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Seats",
                columns: new[] { "SeatID", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Hall", "IsAvailable", "LastUpdatedBy", "LastUpdatedTime", "Number", "Row" },
                values: new object[,]
                {
                    { "00316c3f-8ba5-4611-9c81-48e764b80174", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4660), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4661), 5, "D" },
                    { "0276b102-314e-425a-8c64-2b2769bf9128", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4606), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4607), 5, "A" },
                    { "045ec21e-2598-4a3b-aa4c-91e2bff7ba47", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4617), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4618), 2, "B" },
                    { "0ebad0c0-3467-4c93-b0ed-0ce8cdf705e1", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4769), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4770), 3, "E" },
                    { "11ae4fdc-86eb-4ef9-addc-677e7beb4efb", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4807), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4808), 5, "B" },
                    { "175e03b7-fbb0-418e-be95-3fe819ed1df6", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4756), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4757), 4, "D" },
                    { "1811e272-9c05-435d-9523-5b549ac4f0c9", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4640), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4642), 4, "C" },
                    { "19f64797-c628-4028-b52c-e82714228192", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4603), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4605), 4, "A" },
                    { "218a6214-d403-4cbf-8186-2b422cb2c730", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4758), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4759), 5, "D" },
                    { "224162a2-c8a0-44d5-9003-fcd7c8b78dd2", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4790), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4791), 5, "A" },
                    { "225a196e-fd28-4d6a-ad9b-9b1cb0184f82", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4747), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4749), 1, "D" },
                    { "24106b06-7e04-4bed-b3bf-f1e4a6dceab1", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4646), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4648), 6, "C" },
                    { "24798107-e475-4c82-bce0-9c72d9ec840d", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4630), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4631), 6, "B" },
                    { "2955160f-9751-4504-a285-f63bfdc5bb86", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4782), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4783), 2, "A" },
                    { "2b5a933a-43bd-45f8-ae3a-f5910fdd85ee", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4706), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4708), 1, "B" },
                    { "325067fc-ae41-4621-9de8-9dac29a1a9b6", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4777), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4778), 6, "E" },
                    { "3289be36-0cd4-434e-b144-0c2ade920338", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4709), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4710), 2, "B" },
                    { "342f07d7-5cb7-4172-9f0a-cfacc60aa801", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4784), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4785), 3, "A" },
                    { "3a099e89-a107-4af2-a209-540c186f1c8f", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4558), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4579), 1, "A" },
                    { "3e10040f-4412-4575-a05a-0b62f764a6ab", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4730), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4731), 4, "C" },
                    { "3e363e21-e978-4130-af83-178e7676b4dc", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4836), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4837), 1, "D" },
                    { "3f24e65f-1571-466b-933e-c7b4e770b1e1", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4700), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4701), 5, "A" },
                    { "3f883576-6ec3-4141-845e-c7860ef47f9b", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4752), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4753), 3, "D" },
                    { "46a908b4-9056-4c64-9f47-49413d8ee78b", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4643), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4644), 5, "C" },
                    { "4a893336-b4c3-41f9-8e97-eeff17fd0129", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4683), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4684), 5, "E" },
                    { "4b17c5ec-ab98-4445-9736-731a636a53d9", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4681), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4682), 4, "E" },
                    { "4c78b929-98ad-4101-9f21-a672169b6336", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4760), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4762), 6, "D" },
                    { "4eba50af-f8b0-4def-bff6-a94dece529c9", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4609), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4611), 6, "A" },
                    { "5324288d-c001-4f04-939d-7db083fd75e8", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4626), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4627), 5, "B" },
                    { "53bbf7b0-1ae4-49a4-8a39-ac7642631884", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4688), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4689), 1, "A" },
                    { "57431a57-4724-44f2-9d26-df5f7a132292", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4725), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4726), 2, "C" },
                    { "587fd681-adde-4d04-8c30-37a6647d47be", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4727), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4728), 3, "C" },
                    { "58b34551-d3fb-41fa-805e-1e5133116419", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4853), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4854), 1, "E" },
                    { "5daf8dda-5fdb-4e2f-99e3-d6dd8db94e77", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4658), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4659), 4, "D" },
                    { "60b5eaec-15a2-43c0-b0d5-3a441b40f51d", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4592), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4593), 3, "A" },
                    { "623f70b4-adce-4e7f-a24f-aeb1123d9d33", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4844), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4845), 4, "D" },
                    { "63c817f0-25a0-4cb6-9ef4-b78225454d92", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4833), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4834), 6, "C" },
                    { "63f7c52b-14f8-433a-93a2-42078602356a", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4821), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4822), 1, "C" },
                    { "644674ec-1221-4784-b05e-0f3358beacdb", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4863), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4864), 5, "E" },
                    { "65d83eee-9e04-4d3a-9f7a-954f287cd4b7", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4717), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4718), 5, "B" },
                    { "68bba113-d11e-464a-87b5-cff36af5abee", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4694), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4695), 3, "A" },
                    { "6e3827a0-9d6c-402e-9d0f-3fdb8324e899", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4802), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4803), 3, "B" },
                    { "6f6b7215-baae-4ade-aacb-0cd2da36f418", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4771), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4772), 4, "E" },
                    { "73319d47-21ab-458d-9ddc-0908aa903b6b", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4623), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4624), 4, "B" },
                    { "744a7b79-da76-406e-a77c-e0b45c51e190", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4715), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4716), 4, "B" },
                    { "76b92ae0-8aaf-4e6f-8053-e545d6454c2e", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4767), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4768), 2, "E" },
                    { "8026afac-1f6d-487c-9f22-a1e0fd0b5b93", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4829), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4830), 4, "C" },
                    { "8459f734-7834-4ef5-a800-833e370154aa", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4831), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4832), 5, "C" },
                    { "849a1462-9789-40a9-9c73-4de25d3cbe09", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4588), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4590), 2, "A" },
                    { "85a40efe-b36d-4dfd-acaa-f086086697e9", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4663), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4665), 6, "D" },
                    { "869f6401-778c-4096-a324-2143d7329a71", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4800), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4801), 2, "B" },
                    { "8e242e48-78ce-4150-99fa-4c6544a9b198", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4823), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4824), 2, "C" },
                    { "944502a2-350d-4b8c-b713-dc42c734ebf4", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4861), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4862), 4, "E" },
                    { "95225c07-1edb-4208-a623-d470e30f2bac", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4794), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4795), 6, "A" },
                    { "95812913-7b07-4a55-9543-5b62a8cc0a4f", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4846), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4847), 5, "D" },
                    { "97794dcd-2e58-4882-96fe-0759601b99d8", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4711), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4712), 3, "B" },
                    { "9abd1c12-bf9f-4fe9-b2c5-411791a1a080", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4850), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4851), 6, "D" },
                    { "9b5ad7bc-88da-4b2b-8eb0-deb41c3ae595", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4677), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4678), 3, "E" },
                    { "a35d4734-63cc-48b0-a32c-125b12053bf7", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4649), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4650), 1, "D" },
                    { "a6d49bc5-d08b-42dc-9b7a-5743385d68a2", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4673), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4674), 1, "E" },
                    { "a90c1053-355b-4bd6-ad9b-66555228bcc2", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4686), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4687), 6, "E" },
                    { "aedc7734-3c84-46ae-8342-d819d3cf5799", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4634), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4635), 2, "C" },
                    { "b0d00567-21fd-4774-ab17-3f4b44795841", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4719), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4720), 6, "B" },
                    { "b2d556f9-9909-48ea-82b5-aa954bbedc9b", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4818), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4820), 6, "B" },
                    { "b328a776-2f17-498f-a944-bf191bef7443", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4612), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4613), 1, "B" },
                    { "b338caee-1bb9-48ce-ac55-cc07a0bd9a7c", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4750), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4751), 2, "D" },
                    { "b5b6c9c8-e498-464b-9ff8-331be3751438", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4637), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4638), 3, "C" },
                    { "b8995ba4-c8a8-4012-b78f-028e610ec739", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4692), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4693), 2, "A" },
                    { "bd1957de-4b53-4ab9-9f8e-7a0c50453b3e", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4804), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4805), 4, "B" },
                    { "be805dc9-b5c6-498c-abd1-c916e0102e54", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4721), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4723), 1, "C" },
                    { "c1ffebef-6d8d-415f-b3bf-c6e8bc71f60e", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4773), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4775), 5, "E" },
                    { "c2041405-eca6-469a-990f-bf5e64fd715d", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4763), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4764), 1, "E" },
                    { "c3428312-455a-45c7-9595-242115bca019", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4736), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4737), 6, "C" },
                    { "c407e9e2-71cb-4b44-8d35-1760c75fcba4", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4857), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4858), 3, "E" },
                    { "ca4d0373-ccdf-47f8-aea4-1b1affa1579a", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4865), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4866), 6, "E" },
                    { "ca66207c-cfd5-4f33-a2f4-8aadde55e9bd", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4825), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4826), 3, "C" },
                    { "cde3b048-67ed-48d1-a0b2-7f54b4a59768", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4632), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4633), 1, "C" },
                    { "d29fcd10-f217-4992-ba99-28286ebd0b07", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4655), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4657), 3, "D" },
                    { "d5ba81d2-f9dc-4fc4-b05a-4603be1fb0df", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4841), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4843), 3, "D" },
                    { "e0182782-5148-49ad-8256-e1718d6a7def", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4796), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4797), 1, "B" },
                    { "e4ab25d2-369d-4ced-8380-cd4ce9775953", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4788), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4789), 4, "A" },
                    { "e713c746-da09-4580-9bc7-7a58280e2789", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4697), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4699), 4, "A" },
                    { "e870d643-0934-4a32-93f3-b302365a345c", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4855), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4856), 2, "E" },
                    { "ee14333e-6bb2-471e-8845-e273184c8806", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4675), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4676), 2, "E" },
                    { "f147efca-9bf2-48cc-9ee3-0dfa79ddcfaf", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4839), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4840), 2, "D" },
                    { "f1a331ab-7e2e-4bed-92c9-67cc75afb0ff", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4619), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4621), 3, "B" },
                    { "f5d383d2-6ec2-4800-8a4a-9dbcf76de57b", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4780), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4781), 1, "A" },
                    { "f903a31c-da2f-497a-9172-82a6fa12d60d", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4732), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4733), 5, "C" },
                    { "fcd100bb-22a0-4590-8546-f7a7c55d0b92", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4704), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4705), 6, "A" },
                    { "ff658cb8-cbed-4890-a917-e86fc9b79808", "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4653), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 40, 22, 375, DateTimeKind.Local).AddTicks(4654), 2, "D" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "00316c3f-8ba5-4611-9c81-48e764b80174");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0276b102-314e-425a-8c64-2b2769bf9128");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "045ec21e-2598-4a3b-aa4c-91e2bff7ba47");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0ebad0c0-3467-4c93-b0ed-0ce8cdf705e1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "11ae4fdc-86eb-4ef9-addc-677e7beb4efb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "175e03b7-fbb0-418e-be95-3fe819ed1df6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1811e272-9c05-435d-9523-5b549ac4f0c9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "19f64797-c628-4028-b52c-e82714228192");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "218a6214-d403-4cbf-8186-2b422cb2c730");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "224162a2-c8a0-44d5-9003-fcd7c8b78dd2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "225a196e-fd28-4d6a-ad9b-9b1cb0184f82");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "24106b06-7e04-4bed-b3bf-f1e4a6dceab1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "24798107-e475-4c82-bce0-9c72d9ec840d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2955160f-9751-4504-a285-f63bfdc5bb86");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2b5a933a-43bd-45f8-ae3a-f5910fdd85ee");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "325067fc-ae41-4621-9de8-9dac29a1a9b6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3289be36-0cd4-434e-b144-0c2ade920338");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "342f07d7-5cb7-4172-9f0a-cfacc60aa801");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3a099e89-a107-4af2-a209-540c186f1c8f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3e10040f-4412-4575-a05a-0b62f764a6ab");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3e363e21-e978-4130-af83-178e7676b4dc");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3f24e65f-1571-466b-933e-c7b4e770b1e1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3f883576-6ec3-4141-845e-c7860ef47f9b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "46a908b4-9056-4c64-9f47-49413d8ee78b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4a893336-b4c3-41f9-8e97-eeff17fd0129");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4b17c5ec-ab98-4445-9736-731a636a53d9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4c78b929-98ad-4101-9f21-a672169b6336");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4eba50af-f8b0-4def-bff6-a94dece529c9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5324288d-c001-4f04-939d-7db083fd75e8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "53bbf7b0-1ae4-49a4-8a39-ac7642631884");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "57431a57-4724-44f2-9d26-df5f7a132292");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "587fd681-adde-4d04-8c30-37a6647d47be");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "58b34551-d3fb-41fa-805e-1e5133116419");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5daf8dda-5fdb-4e2f-99e3-d6dd8db94e77");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "60b5eaec-15a2-43c0-b0d5-3a441b40f51d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "623f70b4-adce-4e7f-a24f-aeb1123d9d33");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "63c817f0-25a0-4cb6-9ef4-b78225454d92");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "63f7c52b-14f8-433a-93a2-42078602356a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "644674ec-1221-4784-b05e-0f3358beacdb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "65d83eee-9e04-4d3a-9f7a-954f287cd4b7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "68bba113-d11e-464a-87b5-cff36af5abee");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6e3827a0-9d6c-402e-9d0f-3fdb8324e899");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6f6b7215-baae-4ade-aacb-0cd2da36f418");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "73319d47-21ab-458d-9ddc-0908aa903b6b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "744a7b79-da76-406e-a77c-e0b45c51e190");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "76b92ae0-8aaf-4e6f-8053-e545d6454c2e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8026afac-1f6d-487c-9f22-a1e0fd0b5b93");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8459f734-7834-4ef5-a800-833e370154aa");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "849a1462-9789-40a9-9c73-4de25d3cbe09");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "85a40efe-b36d-4dfd-acaa-f086086697e9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "869f6401-778c-4096-a324-2143d7329a71");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8e242e48-78ce-4150-99fa-4c6544a9b198");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "944502a2-350d-4b8c-b713-dc42c734ebf4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "95225c07-1edb-4208-a623-d470e30f2bac");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "95812913-7b07-4a55-9543-5b62a8cc0a4f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "97794dcd-2e58-4882-96fe-0759601b99d8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9abd1c12-bf9f-4fe9-b2c5-411791a1a080");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9b5ad7bc-88da-4b2b-8eb0-deb41c3ae595");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a35d4734-63cc-48b0-a32c-125b12053bf7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a6d49bc5-d08b-42dc-9b7a-5743385d68a2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a90c1053-355b-4bd6-ad9b-66555228bcc2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "aedc7734-3c84-46ae-8342-d819d3cf5799");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b0d00567-21fd-4774-ab17-3f4b44795841");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b2d556f9-9909-48ea-82b5-aa954bbedc9b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b328a776-2f17-498f-a944-bf191bef7443");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b338caee-1bb9-48ce-ac55-cc07a0bd9a7c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b5b6c9c8-e498-464b-9ff8-331be3751438");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b8995ba4-c8a8-4012-b78f-028e610ec739");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "bd1957de-4b53-4ab9-9f8e-7a0c50453b3e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "be805dc9-b5c6-498c-abd1-c916e0102e54");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c1ffebef-6d8d-415f-b3bf-c6e8bc71f60e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c2041405-eca6-469a-990f-bf5e64fd715d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c3428312-455a-45c7-9595-242115bca019");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c407e9e2-71cb-4b44-8d35-1760c75fcba4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ca4d0373-ccdf-47f8-aea4-1b1affa1579a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ca66207c-cfd5-4f33-a2f4-8aadde55e9bd");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cde3b048-67ed-48d1-a0b2-7f54b4a59768");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d29fcd10-f217-4992-ba99-28286ebd0b07");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d5ba81d2-f9dc-4fc4-b05a-4603be1fb0df");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e0182782-5148-49ad-8256-e1718d6a7def");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e4ab25d2-369d-4ced-8380-cd4ce9775953");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e713c746-da09-4580-9bc7-7a58280e2789");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e870d643-0934-4a32-93f3-b302365a345c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ee14333e-6bb2-471e-8845-e273184c8806");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f147efca-9bf2-48cc-9ee3-0dfa79ddcfaf");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f1a331ab-7e2e-4bed-92c9-67cc75afb0ff");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f5d383d2-6ec2-4800-8a4a-9dbcf76de57b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f903a31c-da2f-497a-9172-82a6fa12d60d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fcd100bb-22a0-4590-8546-f7a7c55d0b92");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ff658cb8-cbed-4890-a917-e86fc9b79808");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Seats",
                columns: new[] { "SeatID", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Hall", "IsAvailable", "LastUpdatedBy", "LastUpdatedTime", "Number", "Row" },
                values: new object[,]
                {
                    { "03b5de17-8775-44a3-89df-c7f309a92747", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1164), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1167), 5, "B" },
                    { "084d8589-ebe8-42ba-b7da-be0c6f4f1df6", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1536), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1542), 3, "B" },
                    { "08fb7a61-5c14-49c0-82e4-af8e457e599f", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1640), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1646), 1, "E" },
                    { "090d4732-b5e8-43fb-ba53-ddbd9480ccc8", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1470), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1472), 4, "E" },
                    { "0a27d6c2-d78c-4e00-86c2-09c26bd68cdf", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1461), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1467), 3, "E" },
                    { "0b21fddb-4530-4f84-9f3a-b2da21af68b3", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1371), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1375), 1, "C" },
                    { "0e1b7de2-2025-4a86-8236-d6a53fa413df", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1241), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1244), 5, "D" },
                    { "0e7288e3-f6f1-41d9-95b4-5e85cff6e815", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1122), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1125), 6, "A" },
                    { "0ea12419-77a3-4a92-ab84-4da54d402a1a", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1610), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1613), 2, "D" },
                    { "15595ea6-4185-4ea1-89bd-c374d74c5031", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1439), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1441), 6, "D" },
                    { "184a7e9a-df93-44e4-9b78-8c9ece9fedf5", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1510), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1515), 5, "A" },
                    { "1a5ff9f6-bdf7-4963-87b0-1de4a9bed12a", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1630), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1633), 5, "D" },
                    { "1b7711a7-de7e-4e46-81a1-4a9ba22045df", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1105), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1108), 4, "A" },
                    { "1c1a094b-39c4-4b29-a927-c407a256e698", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1616), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1622), 3, "D" },
                    { "295101e3-9d15-43ff-8e61-adc59f015da4", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1430), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1436), 5, "D" },
                    { "297a610f-bb14-46fe-9da3-7129e91139b2", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1659), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1662), 4, "E" },
                    { "2d2da7a6-0729-490f-abf2-ea4be81ced27", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1328), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1331), 6, "A" },
                    { "2ec5e7ff-8acb-4463-87fb-35d99c5dd04d", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1284), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1287), 6, "E" },
                    { "303c4054-a5f0-4eb3-b6be-1650e29fe148", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1190), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1192), 3, "C" },
                    { "3464da66-bcd4-41b3-b506-12d3343f7106", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1664), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1670), 5, "E" },
                    { "34f68475-f68b-4f0b-afe2-e87064a0816d", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1227), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1233), 3, "D" },
                    { "37374455-ea57-4aa7-8859-0e1aa5b16ec8", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1358), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1364), 5, "B" },
                    { "37f39261-ddd5-4493-af33-a94e40f0a49a", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1347), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1350), 3, "B" },
                    { "3c41e003-1ebc-47b2-bbb1-4d3c854d7fb0", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1296), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1306), 2, "A" },
                    { "3ec8aab0-ec1d-4335-ac2b-6e2afc151d06", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1252), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1258), 1, "E" },
                    { "413a309b-8f79-4cbc-bec1-ed7ffd0e960c", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1159), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1162), 4, "B" },
                    { "416ddd6a-d93f-48aa-8e27-c81cd42e5aba", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1308), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1314), 3, "A" },
                    { "43813a41-5ba2-4179-868a-77c299f0877e", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1210), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1213), 6, "C" },
                    { "45c00867-188f-4198-bd28-7f437c43f13f", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1579), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1581), 4, "C" },
                    { "4d8a3545-85be-4690-b61a-031fa7675cfe", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1366), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1369), 6, "B" },
                    { "4df88e2b-d363-47ac-a975-7228fba1ee33", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1353), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1355), 4, "B" },
                    { "4e2f6e66-d83a-4009-973d-eca5638bbc09", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1184), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1187), 2, "C" },
                    { "4ef34e12-17db-4413-b94f-b93dbf8e3e5a", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1499), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1502), 3, "A" },
                    { "503fd13e-5e88-4fd4-bd89-6dd47eb25e08", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1048), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1088), 1, "A" },
                    { "548c1f47-7049-4f8a-9277-a0995e268a4b", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1176), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1182), 1, "C" },
                    { "55864e9f-c58c-4148-b739-21a447e2a419", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1396), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1398), 5, "C" },
                    { "5abad2de-45a5-4e4c-9242-52e978779912", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1420), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1423), 3, "D" },
                    { "5b44a4a0-724a-4475-be19-9af3e5b5d781", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1425), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1428), 4, "D" },
                    { "60e18322-5beb-40a8-9864-9babae5bcd13", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1323), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1326), 5, "A" },
                    { "63e21617-048c-46cf-b0cf-aebb1883d661", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1584), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1589), 5, "C" },
                    { "67acc6af-842e-4655-9651-5943c5880e36", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1094), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1097), 2, "A" },
                    { "6b5f08a1-0f41-4049-9736-11495dc734ca", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1415), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1417), 2, "D" },
                    { "7323dbd1-e55f-4a52-8097-fb99dd6d62d3", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1391), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1393), 4, "C" },
                    { "7633a623-bb8c-402d-b182-cb76616ecc97", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1494), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1496), 2, "A" },
                    { "77cc2734-93dd-4b82-896e-3281a0793ed4", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1246), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1249), 6, "D" },
                    { "7a62f69e-2851-42da-a4a7-70b979122ce0", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1265), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1268), 3, "E" },
                    { "7a9cd02b-8224-4371-b35b-21d0ea73caf0", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1449), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1452), 2, "E" },
                    { "81ca41cf-5a20-4e86-aebb-d8ea10ef4781", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1625), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1628), 4, "D" },
                    { "84aad58a-056c-4ad6-8cd4-66254d998f8b", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1149), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1155), 3, "B" },
                    { "8846ae11-a95b-4231-b0b3-0f567024d175", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1236), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1239), 4, "D" },
                    { "8b196eb9-73b0-460c-afd9-3231d689c712", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1342), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1345), 2, "B" },
                    { "8bca4a69-2ceb-442c-8a00-62e507c8bcfe", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1271), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1274), 4, "E" },
                    { "8d12ac3a-ce8f-4b1a-897c-cfd852fffee6", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1170), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1173), 6, "B" },
                    { "8dea9130-a249-42fa-863b-7156aa48fd3f", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1525), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1528), 1, "B" },
                    { "93fadeca-86c4-4e5b-acb1-8653900665a0", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1573), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1576), 3, "C" },
                    { "9ad4025e-592b-4dbe-a316-c8e72cb84931", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1334), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1339), 1, "B" },
                    { "a25114be-63d7-4037-80d6-3278541787d1", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1111), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1117), 5, "A" },
                    { "a561bee4-0517-435c-b01a-c7ca130ac980", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1260), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1263), 2, "E" },
                    { "a5df0c86-e1f9-4b70-929d-e87817bd08b8", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1635), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1638), 6, "D" },
                    { "a87ded43-522b-495a-967f-6c149bdf7bf7", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1544), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1547), 4, "B" },
                    { "ad0fc90d-df7a-44bd-8faa-68e1e6a4fcac", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1504), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1507), 4, "A" },
                    { "adb592ff-ba76-448b-89a2-43c7d13f7805", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1406), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1412), 1, "D" },
                    { "afd4c37d-b9b5-4e44-9d69-1b0cdf9be7cb", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1520), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1522), 6, "A" },
                    { "b3806383-d412-4bd4-8fb7-aedb9e1fa04d", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1554), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1557), 6, "B" },
                    { "b43b2bfe-8944-4696-99a0-76e51093e775", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1549), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1552), 5, "B" },
                    { "b59e9666-d4ce-4534-9ab4-e559de390844", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1444), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1447), 1, "E" },
                    { "b6cc6121-af8a-4e3b-9dcb-97eb99386524", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1598), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1600), 1, "D" },
                    { "b8de0cf5-3466-4682-942a-f6de0e5d7058", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1318), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1321), 4, "A" },
                    { "c209a90b-2ee2-4a6e-b047-84caf69b889f", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1530), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1533), 2, "B" },
                    { "c6f617bf-107a-4a0e-85af-37ebb64b80ec", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1382), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1388), 3, "C" },
                    { "ca1154c7-c41d-460d-a4e1-e74703e0ecef", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1592), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1595), 6, "C" },
                    { "cc7f736e-1f20-4a22-8772-aedd65f68c41", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1401), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1404), 6, "C" },
                    { "ced6579e-a311-46a7-a8bb-8d7843519a94", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1654), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1657), 3, "E" },
                    { "d12a3d07-7b10-43cf-acf9-fa6b97df883e", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1486), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1491), 1, "A" },
                    { "d168a96b-2b14-4250-b47e-46bceeccf66e", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1100), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1102), 3, "A" },
                    { "d1909cc8-c352-4456-bcbc-d3cb15bfb875", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1475), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1478), 5, "E" },
                    { "d6d3f0f4-5a46-462b-a383-749f0f259758", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1560), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1565), 1, "C" },
                    { "ddb30cc5-6884-4dcc-8d58-194d708212be", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1144), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1146), 2, "B" },
                    { "dddaa59c-392e-463d-adbf-ea1abf66755b", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1276), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1282), 5, "E" },
                    { "e092b7cc-89f1-46b8-9974-a22860436a72", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1568), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1571), 2, "C" },
                    { "e9870308-f6f0-44f0-9c71-227e74f06335", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1221), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1225), 2, "D" },
                    { "ea7233f5-fecf-446a-9698-d53d3162e1c6", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1649), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1652), 2, "E" },
                    { "ec32586c-2327-42d2-a333-9603b07a772c", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1291), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1293), 1, "A" },
                    { "ecc80755-793b-45b7-bc30-7946db3535ea", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1128), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1141), 1, "B" },
                    { "f287a92e-00cd-4c06-a0ee-29f4ae20cc55", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1377), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1380), 2, "C" },
                    { "f9c9b0c0-7ac3-4c9d-a057-e2f67a6925ad", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1200), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1206), 5, "C" },
                    { "fb5f3a56-33ab-4967-8ee7-2ff0dcb44093", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1195), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1198), 4, "C" },
                    { "fc3d4bb2-79b4-431d-9251-7f0c4cd8b108", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1672), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1675), 6, "E" },
                    { "fd122336-7ec3-46b0-828c-fda54902e3d0", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1215), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1218), 1, "D" },
                    { "ff318c0e-7012-45f2-91e4-5c56cd3d717f", "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1480), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 0, 34, 11, 375, DateTimeKind.Local).AddTicks(1483), 6, "E" }
                });
        }
    }
}
