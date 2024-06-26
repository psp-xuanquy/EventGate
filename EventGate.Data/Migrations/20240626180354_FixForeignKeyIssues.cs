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
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderID",
                schema: "dbo",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Tickets_TicketID",
                schema: "dbo",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Tickets_TicketID1",
                schema: "dbo",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_TicketID1",
                schema: "dbo",
                table: "OrderDetails");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "039dd51c-d01b-4d86-8249-395b753d8631");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "05d45fec-6f81-4410-b8d4-5d093b7965a5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "074662de-44cf-4687-91e2-cbe02e899007");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0aa7a4a8-6b51-4be5-8ca1-049ccb3a1daa");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0c323e63-533d-4f37-a035-da8eba15dace");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0f693988-3897-4254-926e-9db3cc8ddd9b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0f8e3f8e-316c-4f9d-b377-9e4471780b8b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0fea698f-5676-457a-bfdd-9da35a01ac5e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "119439df-77aa-449f-9efa-86bf1229ef0b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "15ae9ee0-1b45-41b0-837b-74d43d0835e8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "19b39443-b849-4b5e-b717-3ac0b92c9b5c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1a0976ad-ddc5-44f5-821a-32717c77028a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1ebab98e-8ca6-497e-8933-c3efd7c4cb90");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1fb5d811-aa9b-4576-85f7-7ae4b2fb2e29");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "20a67087-e03b-4380-b839-2ebac2eac1e7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2268c7ef-548f-4e2c-8098-e9571684fc2b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2577ce8c-acc0-45a7-a8c7-4169a2102c0c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2932e7f8-eaa9-4bf2-acdb-5d8acbf2de3f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2d49199c-ed8f-483e-9f4b-338c373f2deb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2ee0c38e-4344-4cc7-8f72-3b919e9e8040");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2fd8c1e7-7074-4452-b1c3-9f4da16c675f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "32aacdb9-1d77-4ad5-a981-b2b817b41f43");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "37fa023d-750d-40cc-81ea-eb7a9e2b03ad");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "39e692a1-cdcb-41ea-af69-5c0ce91cab16");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3b84bcc5-d5bf-4230-b724-6fe58edc9dc7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "40a24f4a-6a57-4623-b41f-1bc820b60e8d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "44ac177a-83eb-44c5-abf7-7a2b7951da0a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "46a75e79-bef9-4541-8d68-8440fc66d6fb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "49bd9da3-39d9-49d4-819c-388b3963d937");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4ba3a22c-d57b-410e-8f72-cedb1ee077ea");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4bea6ad5-5d6b-452a-9183-05beffb052f9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4ec237e8-8fbf-4282-a684-f38779bb7c8b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "530826e1-59f6-4a8b-b7c1-9bf468b41d20");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "544b4206-4654-4996-bf3a-ea54db935b3f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "56f78547-4689-49c2-89ac-713223421e63");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5fae4c17-45be-440e-b868-9ab5daaf5dcd");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "69373e1f-fc94-4615-883e-7cf0c482beb9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6da08964-58d1-46e4-b3f5-a290616e72e5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "70f4a272-1254-4167-96f3-76addb02d343");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7113dbf6-26c1-43fa-afcf-47b762922759");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "728debef-9468-4e80-9b9a-44e5178ed63b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "732602a3-439f-468a-bf5d-59c813f953db");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "74f9a7a5-1726-48f6-9acd-89c96489c40c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "76b9d5cb-47c1-47f0-a53b-87650a27b85e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7afda92e-b1d0-4953-9a5c-1de9e350acc0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8079a855-1c66-4ea8-8412-517864746772");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "85170394-c565-46aa-b3b1-d3bc7aa9219d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "936c2537-4554-4328-970c-e9a710a74c8e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "95b25182-737e-40d7-a19a-747e5d2d6a57");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "98eab408-e372-43f3-a649-11e51d274138");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9de88960-54ee-467b-839d-f54521fb7dfd");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a191370e-f75d-4897-80a9-ca09cb5a5c57");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a2d5a696-1129-4070-a854-1a9afdff4cb8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a3aaa56e-0244-4983-8dfa-1b3039d3662c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a3d368ab-eada-4dd1-9253-9f7780de98c3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a4f2c278-3a5f-4660-8453-bb6d012130d1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "aa30f848-20e0-415c-8c1d-75f675f7bab8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "aaecf6da-ae1d-45d2-8f1a-3ee433ed7d07");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "aaedebb0-c6c1-40e1-b13d-cb55d072bd36");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ad271cf2-f6bf-4a2e-8985-61bb6dc0e77c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "af039fa1-26ba-4cb4-aa2b-1f40b9fac80f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b0c710ec-2f19-4e15-a169-c7b50d14583d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b136380d-746e-489b-b4ed-aff65e317f15");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b1d18ec4-83f4-46ee-bdc7-2457df92c0ce");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b3b3d835-1dc2-427e-a9ee-a324ce4c9f9f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b710b7b7-912b-4b34-bac2-fbab0d049658");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b8d37705-5b5f-4da8-85f3-1864d2d8df28");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "be01bac3-f372-48f1-9c28-3652cc3636de");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c4810889-982b-4f9a-8f13-10be63b6085d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c8d56361-0c8d-4c2f-a289-d4523550d391");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c9cb41ac-69c3-404b-9b3c-3e52221a5afc");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cb7a1e70-40d8-4524-8fa2-ec4ea532081f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "cf05b559-9c95-4563-ad12-50e544868f9d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d89cb32e-5285-4291-9919-b89beaedff4e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d9b7823b-387f-4f1b-b021-1492263208c2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "dca17ac0-cfb3-4842-8ad0-b3ea1489360a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ddc0f1c5-dc83-43b3-b642-8af4ed3515a1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "dea49292-82be-4a8c-a02c-2ba3472dc412");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e733a459-d63d-4be9-b4f6-dc4213670837");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e7b387a1-4d54-46ce-b8db-9f8d28a070e3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "eec0499d-de6c-424b-864a-0b1a96dfc959");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ef814bbf-d24c-45c3-bae3-d8f64f768c88");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f00d82d7-07bc-4daa-89fc-2c17a9e5035a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f2fc6f67-e6a1-4ddc-86fd-8d16ad31baa2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f32b1918-6bb3-476b-8dd4-4388ea8bc6e6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f4eb3ef0-5da8-4398-a0fa-61003f1e1879");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f6d38201-6d89-4690-afc0-236fdf449bce");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "faf0f1f8-d4c7-43d4-98ae-5bd1fd32d4b0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fba38500-9c94-4103-9be3-cfc1e015397c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ff956a4f-dbb5-41de-8ffe-6efbe4ce35f9");

            migrationBuilder.DropColumn(
                name: "TicketID1",
                schema: "dbo",
                table: "OrderDetails");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Seats",
                columns: new[] { "SeatID", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Hall", "IsAvailable", "LastUpdatedBy", "LastUpdatedTime", "Number", "Row" },
                values: new object[,]
                {
                    { "00194226-20ed-45eb-9e5b-718af47411b9", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4333), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4334), 3, "B" },
                    { "02ca56f8-79ee-40a9-af88-0d90e63726e0", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4329), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4330), 1, "B" },
                    { "02fe83ff-b3c7-47c6-a83e-d39b6f5d451b", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(3971), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(3999), 1, "A" },
                    { "06d47b48-51ce-48d6-b85a-b8d5d6b91a46", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4371), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4372), 6, "D" },
                    { "0866a208-7ee9-4b09-b253-f250a6770ac9", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4045), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4046), 4, "B" },
                    { "11e0077f-f549-4021-8a68-278d7d8367b8", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4367), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4368), 4, "D" },
                    { "1b3251c4-3ac6-4052-851f-c2c6a1eaed9f", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4349), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4350), 3, "C" },
                    { "1c9be519-a3f3-4c60-b2ce-b520e3838b6b", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4363), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4364), 3, "D" },
                    { "29939481-ee4d-48d8-88d7-1e723fa79d87", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4056), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4057), 2, "C" },
                    { "29f41b4b-2d75-461c-a7aa-15f17b4cf0f8", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4136), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4137), 5, "B" },
                    { "2b7850ed-0874-4c59-abd6-24b2e7be3746", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4059), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4060), 3, "C" },
                    { "2bec381b-2254-4372-a5e9-92a1a96e71a4", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4040), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4041), 3, "B" },
                    { "2c123d59-5f45-4a0e-ac25-9e261db96282", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4357), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4358), 6, "C" },
                    { "2e24da0a-ed20-4442-ae84-b1309571f39c", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4381), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4383), 4, "E" },
                    { "2f7ed633-325b-4d26-8e56-9d8b3076760b", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4114), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4115), 3, "A" },
                    { "310bd8b1-65ba-47cf-92d3-649d8a7f8a98", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4085), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4086), 4, "D" },
                    { "31bd1a7a-9324-4832-83af-3461a5bb75c8", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4369), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4370), 5, "D" },
                    { "33bd9de6-4371-4b93-91e2-6280e57c3996", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4131), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4133), 3, "B" },
                    { "36329f95-f14d-4f47-ab02-56b04b4ae92a", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4291), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4292), 3, "E" },
                    { "3948fbb5-8ab5-46f5-bd21-7744dd9be352", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4112), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4113), 2, "A" },
                    { "3a6cfa0b-e4b1-46e0-a982-b2f6cbc00cf9", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4270), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4271), 1, "D" },
                    { "40a451ec-a1f0-4f24-8d33-ed1c2e3b10ef", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4347), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4348), 2, "C" },
                    { "40be114b-fc6e-46c6-9cd4-725bc090316e", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4384), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4385), 5, "E" },
                    { "493b9a7a-991b-48b2-997d-9cad7a04d3c9", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4359), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4360), 1, "D" },
                    { "4b4e2324-fcfd-4fb3-8006-a11c0ab798e2", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4297), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4298), 5, "E" },
                    { "4b7bdb9f-1b93-4e9a-8210-c4ca04d724e7", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4121), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4122), 5, "A" },
                    { "5115c825-b2df-4faa-b645-a536a0430214", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4119), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4120), 4, "A" },
                    { "52618743-515c-42b2-bdff-f3470c5f00b6", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4103), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4105), 5, "E" },
                    { "56e643cf-d93c-4176-ae05-10b38886ef66", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4063), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4065), 5, "C" },
                    { "57acd458-7600-4fc1-bab5-a7ff94826ce5", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4087), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4089), 5, "D" },
                    { "5aaa0972-a272-4569-9dcd-5035c5dbfce2", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4101), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4102), 4, "E" },
                    { "60181065-e3c3-4b5e-8ad8-dc5dd96b101f", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4021), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4023), 3, "A" },
                    { "63d1ba4f-1eb5-4a62-985f-1bbe9ddc6fc5", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4079), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4080), 2, "D" },
                    { "686d6a86-df4d-4243-8d9d-a1315694fe01", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4032), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4033), 6, "A" },
                    { "68f6ab4c-e31b-452a-9942-e9aa6b1cf5db", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4274), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4275), 2, "D" },
                    { "69c72b4f-7b3d-4ba5-9aba-244ffcc05536", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4301), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4302), 1, "A" },
                    { "6cb2dff9-ce00-40fd-be12-01c8166c6013", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4276), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4277), 3, "D" },
                    { "6d45866d-4d09-4fe2-ba13-c8cbfd47ccb2", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4326), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4327), 6, "A" },
                    { "729751b4-077e-4ea2-9e9c-08cdd61ecacc", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4341), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4342), 6, "B" },
                    { "741b1a72-01f3-4d96-b37e-ad1ac6d48e9c", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4266), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4267), 5, "C" },
                    { "77377b0e-e10b-44a3-bb97-f75d441a8dba", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4099), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4100), 3, "E" },
                    { "7af2c75d-c4d2-4d03-b5b4-90ee6d2dd872", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4061), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4062), 4, "C" },
                    { "7b1ea983-fac6-4096-90ec-324e0a0c1466", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4280), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4282), 5, "D" },
                    { "7d32922b-e78a-4c5d-9631-6d3fb99c4368", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4289), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4290), 2, "E" },
                    { "7eb345e1-34c0-4a87-991b-4a0cad9474f5", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4125), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4127), 1, "B" },
                    { "7f954991-fbac-4afd-8776-1247a8d8e3ad", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4123), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4124), 6, "A" },
                    { "8b58ac0e-4e54-46ed-96e7-48b483603e2c", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4090), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4091), 6, "D" },
                    { "8d59572c-b08d-4398-9fbb-d9cb95fe0259", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4343), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4344), 1, "C" },
                    { "8daee16e-57cb-4645-8eea-1738d543e711", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4278), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4279), 4, "D" },
                    { "8f84f932-8b6e-41c9-880f-42b8a4546d56", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4077), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4078), 1, "D" },
                    { "90c0316b-118c-4527-b8de-b67c0053cb1a", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4339), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4340), 5, "B" },
                    { "91bbd186-c375-4458-84df-d095dfe44971", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4081), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4083), 3, "D" },
                    { "9a44b4ca-81f2-4ced-86af-ee361ba8a145", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4337), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4338), 4, "B" },
                    { "9b725762-5f79-4ab8-a73f-b339aef5f0ad", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4284), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4285), 6, "D" },
                    { "a09d7046-ec4e-417e-bf33-de121f7b8259", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4097), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4098), 2, "E" },
                    { "a1fc9fa4-f7f8-4e66-84c2-99a435acd8fa", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4305), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4306), 2, "A" },
                    { "a20387df-7971-4f64-9792-a7ec761fb332", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4035), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4036), 1, "B" },
                    { "a24c28d7-934e-4ebd-a1e4-2e3bdfad59d2", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4093), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4094), 1, "E" },
                    { "a9efa8bc-a039-4983-9349-6c37f77b66d1", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4309), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4310), 4, "A" },
                    { "ad7bdc2e-a432-4c34-b954-0c326110d8f2", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4312), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4313), 5, "A" },
                    { "af23d8b8-0379-4164-bf16-96a07ab8c8e2", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4377), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4378), 2, "E" },
                    { "b1897995-8f87-4df9-81a1-d62c297c9ff3", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4294), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4296), 4, "E" },
                    { "b42353f7-cabe-4702-9561-b743df17fe47", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4353), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4354), 5, "C" },
                    { "b5cdba10-2c5a-4020-87b2-1f9b2aac65a4", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4388), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4389), 6, "E" },
                    { "b618da7b-0b0d-40fa-8ae7-71106326d5ac", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4052), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4054), 1, "C" },
                    { "bf668a4c-84d9-4fb0-8e72-940b9650ff83", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4134), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4135), 4, "B" },
                    { "c2ae86c0-cf89-4099-9117-db28bdf89ce3", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4129), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4130), 2, "B" },
                    { "ccc3aef0-fcef-4022-aaf5-db150d386fbf", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4307), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4308), 3, "A" },
                    { "d6521f31-479a-4c85-ae67-d614b31e8244", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4268), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4269), 6, "C" },
                    { "d69553b0-984a-41eb-92dc-e9680519ee01", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4256), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4257), 1, "C" },
                    { "d73b5bf3-c4b4-4fac-ac56-099624a5653b", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4140), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4141), 6, "B" },
                    { "d7910752-d971-4b7d-affd-6b3e5a515ba6", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4299), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4300), 6, "E" },
                    { "dc2dcd07-a914-404c-892d-06a80f16409a", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4038), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4039), 2, "B" },
                    { "dec237b9-5417-4621-be62-fded87df8198", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4351), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4352), 4, "C" },
                    { "e0277c22-f02c-4944-a37d-9101672a7fa7", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4050), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4051), 6, "B" },
                    { "e3803f3d-9d88-4bb9-9ced-5c194667e460", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4047), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4048), 5, "B" },
                    { "e64da769-f235-469e-81e4-9088fc9e7045", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4379), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4380), 3, "E" },
                    { "e6b1373d-f23d-4760-a249-283b96e63a2c", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4361), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4362), 2, "D" },
                    { "e7737f85-400c-45a1-994f-01d48a331e7d", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4024), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4025), 4, "A" },
                    { "e90da6c5-faff-461b-becb-bb7aec68fd2d", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4286), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4287), 1, "E" },
                    { "ef522acd-d8a8-44ef-b43b-d5729f5abceb", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4260), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4261), 3, "C" },
                    { "f2ecbb0a-1a6a-4778-9c99-7ce33301d07c", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4110), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4111), 1, "A" },
                    { "f5c055c2-25d7-4163-abf7-5515c95533f0", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4017), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4019), 2, "A" },
                    { "f69bd1c3-d894-42b0-9fa9-96bc1b318838", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4331), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4332), 2, "B" },
                    { "f7fba076-5559-41da-8424-40f554055e07", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4258), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4259), 2, "C" },
                    { "f8842c7e-782b-406e-b35d-7eaaa40c137e", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4026), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4027), 5, "A" },
                    { "f90357d8-bd8b-4f47-9e8f-bf9b6ef559f3", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4264), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4265), 4, "C" },
                    { "fc007e84-3819-40a9-928d-4273ed959a68", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4107), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4108), 6, "E" },
                    { "fd60e2c8-33ef-470a-8123-00f5b5483258", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4374), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4375), 1, "E" },
                    { "ff968f16-f2ed-42d1-aaa2-6e848830d555", "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4068), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 3, 54, 311, DateTimeKind.Local).AddTicks(4069), 6, "C" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderID",
                schema: "dbo",
                table: "OrderDetails",
                column: "OrderID",
                principalSchema: "dbo",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Tickets_TicketID",
                schema: "dbo",
                table: "OrderDetails",
                column: "TicketID",
                principalSchema: "dbo",
                principalTable: "Tickets",
                principalColumn: "TicketID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderID",
                schema: "dbo",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Tickets_TicketID",
                schema: "dbo",
                table: "OrderDetails");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "00194226-20ed-45eb-9e5b-718af47411b9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "02ca56f8-79ee-40a9-af88-0d90e63726e0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "02fe83ff-b3c7-47c6-a83e-d39b6f5d451b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "06d47b48-51ce-48d6-b85a-b8d5d6b91a46");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "0866a208-7ee9-4b09-b253-f250a6770ac9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "11e0077f-f549-4021-8a68-278d7d8367b8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1b3251c4-3ac6-4052-851f-c2c6a1eaed9f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "1c9be519-a3f3-4c60-b2ce-b520e3838b6b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "29939481-ee4d-48d8-88d7-1e723fa79d87");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "29f41b4b-2d75-461c-a7aa-15f17b4cf0f8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2b7850ed-0874-4c59-abd6-24b2e7be3746");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2bec381b-2254-4372-a5e9-92a1a96e71a4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2c123d59-5f45-4a0e-ac25-9e261db96282");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2e24da0a-ed20-4442-ae84-b1309571f39c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "2f7ed633-325b-4d26-8e56-9d8b3076760b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "310bd8b1-65ba-47cf-92d3-649d8a7f8a98");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "31bd1a7a-9324-4832-83af-3461a5bb75c8");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "33bd9de6-4371-4b93-91e2-6280e57c3996");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "36329f95-f14d-4f47-ab02-56b04b4ae92a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3948fbb5-8ab5-46f5-bd21-7744dd9be352");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "3a6cfa0b-e4b1-46e0-a982-b2f6cbc00cf9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "40a451ec-a1f0-4f24-8d33-ed1c2e3b10ef");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "40be114b-fc6e-46c6-9cd4-725bc090316e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "493b9a7a-991b-48b2-997d-9cad7a04d3c9");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4b4e2324-fcfd-4fb3-8006-a11c0ab798e2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "4b7bdb9f-1b93-4e9a-8210-c4ca04d724e7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5115c825-b2df-4faa-b645-a536a0430214");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "52618743-515c-42b2-bdff-f3470c5f00b6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "56e643cf-d93c-4176-ae05-10b38886ef66");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "57acd458-7600-4fc1-bab5-a7ff94826ce5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "5aaa0972-a272-4569-9dcd-5035c5dbfce2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "60181065-e3c3-4b5e-8ad8-dc5dd96b101f");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "63d1ba4f-1eb5-4a62-985f-1bbe9ddc6fc5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "686d6a86-df4d-4243-8d9d-a1315694fe01");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "68f6ab4c-e31b-452a-9942-e9aa6b1cf5db");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "69c72b4f-7b3d-4ba5-9aba-244ffcc05536");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6cb2dff9-ce00-40fd-be12-01c8166c6013");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "6d45866d-4d09-4fe2-ba13-c8cbfd47ccb2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "729751b4-077e-4ea2-9e9c-08cdd61ecacc");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "741b1a72-01f3-4d96-b37e-ad1ac6d48e9c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "77377b0e-e10b-44a3-bb97-f75d441a8dba");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7af2c75d-c4d2-4d03-b5b4-90ee6d2dd872");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7b1ea983-fac6-4096-90ec-324e0a0c1466");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7d32922b-e78a-4c5d-9631-6d3fb99c4368");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7eb345e1-34c0-4a87-991b-4a0cad9474f5");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "7f954991-fbac-4afd-8776-1247a8d8e3ad");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8b58ac0e-4e54-46ed-96e7-48b483603e2c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8d59572c-b08d-4398-9fbb-d9cb95fe0259");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8daee16e-57cb-4645-8eea-1738d543e711");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "8f84f932-8b6e-41c9-880f-42b8a4546d56");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "90c0316b-118c-4527-b8de-b67c0053cb1a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "91bbd186-c375-4458-84df-d095dfe44971");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9a44b4ca-81f2-4ced-86af-ee361ba8a145");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "9b725762-5f79-4ab8-a73f-b339aef5f0ad");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a09d7046-ec4e-417e-bf33-de121f7b8259");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a1fc9fa4-f7f8-4e66-84c2-99a435acd8fa");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a20387df-7971-4f64-9792-a7ec761fb332");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a24c28d7-934e-4ebd-a1e4-2e3bdfad59d2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "a9efa8bc-a039-4983-9349-6c37f77b66d1");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ad7bdc2e-a432-4c34-b954-0c326110d8f2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "af23d8b8-0379-4164-bf16-96a07ab8c8e2");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b1897995-8f87-4df9-81a1-d62c297c9ff3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b42353f7-cabe-4702-9561-b743df17fe47");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b5cdba10-2c5a-4020-87b2-1f9b2aac65a4");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "b618da7b-0b0d-40fa-8ae7-71106326d5ac");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "bf668a4c-84d9-4fb0-8e72-940b9650ff83");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "c2ae86c0-cf89-4099-9117-db28bdf89ce3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ccc3aef0-fcef-4022-aaf5-db150d386fbf");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d6521f31-479a-4c85-ae67-d614b31e8244");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d69553b0-984a-41eb-92dc-e9680519ee01");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d73b5bf3-c4b4-4fac-ac56-099624a5653b");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "d7910752-d971-4b7d-affd-6b3e5a515ba6");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "dc2dcd07-a914-404c-892d-06a80f16409a");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "dec237b9-5417-4621-be62-fded87df8198");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e0277c22-f02c-4944-a37d-9101672a7fa7");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e3803f3d-9d88-4bb9-9ced-5c194667e460");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e64da769-f235-469e-81e4-9088fc9e7045");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e6b1373d-f23d-4760-a249-283b96e63a2c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e7737f85-400c-45a1-994f-01d48a331e7d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "e90da6c5-faff-461b-becb-bb7aec68fd2d");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ef522acd-d8a8-44ef-b43b-d5729f5abceb");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f2ecbb0a-1a6a-4778-9c99-7ce33301d07c");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f5c055c2-25d7-4163-abf7-5515c95533f0");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f69bd1c3-d894-42b0-9fa9-96bc1b318838");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f7fba076-5559-41da-8424-40f554055e07");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f8842c7e-782b-406e-b35d-7eaaa40c137e");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "f90357d8-bd8b-4f47-9e8f-bf9b6ef559f3");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fc007e84-3819-40a9-928d-4273ed959a68");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "fd60e2c8-33ef-470a-8123-00f5b5483258");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Seats",
                keyColumn: "SeatID",
                keyValue: "ff968f16-f2ed-42d1-aaa2-6e848830d555");

            migrationBuilder.AddColumn<string>(
                name: "TicketID1",
                schema: "dbo",
                table: "OrderDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Seats",
                columns: new[] { "SeatID", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Hall", "IsAvailable", "LastUpdatedBy", "LastUpdatedTime", "Number", "Row" },
                values: new object[,]
                {
                    { "039dd51c-d01b-4d86-8249-395b753d8631", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5870), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5872), 2, "A" },
                    { "05d45fec-6f81-4410-b8d4-5d093b7965a5", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5935), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5936), 1, "D" },
                    { "074662de-44cf-4687-91e2-cbe02e899007", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5984), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5985), 5, "A" },
                    { "0aa7a4a8-6b51-4be5-8ca1-049ccb3a1daa", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6046), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6047), 3, "E" },
                    { "0c323e63-533d-4f37-a035-da8eba15dace", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5889), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5890), 4, "A" },
                    { "0f693988-3897-4254-926e-9db3cc8ddd9b", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6105), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6106), 6, "C" },
                    { "0f8e3f8e-316c-4f9d-b377-9e4471780b8b", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5921), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5922), 2, "C" },
                    { "0fea698f-5676-457a-bfdd-9da35a01ac5e", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6120), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6121), 6, "D" },
                    { "119439df-77aa-449f-9efa-86bf1229ef0b", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5898), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5900), 1, "B" },
                    { "15ae9ee0-1b45-41b0-837b-74d43d0835e8", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6100), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6101), 4, "C" },
                    { "19b39443-b849-4b5e-b717-3ac0b92c9b5c", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5912), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5913), 5, "B" },
                    { "1a0976ad-ddc5-44f5-821a-32717c77028a", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6125), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6126), 2, "E" },
                    { "1ebab98e-8ca6-497e-8933-c3efd7c4cb90", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6082), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6083), 5, "B" },
                    { "1fb5d811-aa9b-4576-85f7-7ae4b2fb2e29", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6130), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6132), 4, "E" },
                    { "20a67087-e03b-4380-b839-2ebac2eac1e7", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5945), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5947), 5, "D" },
                    { "2268c7ef-548f-4e2c-8098-e9571684fc2b", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6037), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6039), 6, "D" },
                    { "2577ce8c-acc0-45a7-a8c7-4169a2102c0c", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6066), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6067), 5, "A" },
                    { "2932e7f8-eaa9-4bf2-acdb-5d8acbf2de3f", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6079), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6081), 4, "B" },
                    { "2d49199c-ed8f-483e-9f4b-338c373f2deb", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5906), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5907), 3, "B" },
                    { "2ee0c38e-4344-4cc7-8f72-3b919e9e8040", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5990), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5991), 1, "B" },
                    { "2fd8c1e7-7074-4452-b1c3-9f4da16c675f", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5957), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5958), 1, "E" },
                    { "32aacdb9-1d77-4ad5-a981-b2b817b41f43", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6077), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6078), 3, "B" },
                    { "37fa023d-750d-40cc-81ea-eb7a9e2b03ad", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5939), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5940), 2, "D" },
                    { "39e692a1-cdcb-41ea-af69-5c0ce91cab16", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6097), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6098), 3, "C" },
                    { "3b84bcc5-d5bf-4230-b724-6fe58edc9dc7", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6117), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6118), 5, "D" },
                    { "40a24f4a-6a57-4623-b41f-1bc820b60e8d", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5923), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5924), 3, "C" },
                    { "44ac177a-83eb-44c5-abf7-7a2b7951da0a", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6035), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6036), 5, "D" },
                    { "46a75e79-bef9-4541-8d68-8440fc66d6fb", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6133), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6134), 5, "E" },
                    { "49bd9da3-39d9-49d4-819c-388b3963d937", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6113), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6114), 3, "D" },
                    { "4ba3a22c-d57b-410e-8f72-cedb1ee077ea", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6094), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6095), 2, "C" },
                    { "4bea6ad5-5d6b-452a-9183-05beffb052f9", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6135), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6136), 6, "E" },
                    { "4ec237e8-8fbf-4282-a684-f38779bb7c8b", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5895), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5897), 6, "A" },
                    { "530826e1-59f6-4a8b-b7c1-9bf468b41d20", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6060), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6061), 3, "A" },
                    { "544b4206-4654-4996-bf3a-ea54db935b3f", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5972), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5973), 1, "A" },
                    { "56f78547-4689-49c2-89ac-713223421e63", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6015), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6016), 5, "C" },
                    { "5fae4c17-45be-440e-b868-9ab5daaf5dcd", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5981), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5983), 4, "A" },
                    { "69373e1f-fc94-4615-883e-7cf0c482beb9", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5949), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5950), 6, "D" },
                    { "6da08964-58d1-46e4-b3f5-a290616e72e5", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5904), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5905), 2, "B" },
                    { "70f4a272-1254-4167-96f3-76addb02d343", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6054), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6055), 6, "E" },
                    { "7113dbf6-26c1-43fa-afcf-47b762922759", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5988), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5989), 6, "A" },
                    { "728debef-9468-4e80-9b9a-44e5178ed63b", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6092), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6093), 1, "C" },
                    { "732602a3-439f-468a-bf5d-59c813f953db", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5978), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5979), 3, "A" },
                    { "74f9a7a5-1726-48f6-9acd-89c96489c40c", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6050), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6051), 5, "E" },
                    { "76b9d5cb-47c1-47f0-a53b-87650a27b85e", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6005), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6006), 1, "C" },
                    { "7afda92e-b1d0-4953-9a5c-1de9e350acc0", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6115), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6116), 4, "D" },
                    { "8079a855-1c66-4ea8-8412-517864746772", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5909), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5910), 4, "B" },
                    { "85170394-c565-46aa-b3b1-d3bc7aa9219d", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5932), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5934), 6, "C" },
                    { "936c2537-4554-4328-970c-e9a710a74c8e", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5992), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5994), 2, "B" },
                    { "95b25182-737e-40d7-a19a-747e5d2d6a57", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6123), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6124), 1, "E" },
                    { "98eab408-e372-43f3-a649-11e51d274138", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6008), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6009), 2, "C" },
                    { "9de88960-54ee-467b-839d-f54521fb7dfd", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5929), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5930), 5, "C" },
                    { "a191370e-f75d-4897-80a9-ca09cb5a5c57", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6020), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6026), 1, "D" },
                    { "a2d5a696-1129-4070-a854-1a9afdff4cb8", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5873), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5875), 3, "A" },
                    { "a3aaa56e-0244-4983-8dfa-1b3039d3662c", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5943), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5944), 4, "D" },
                    { "a3d368ab-eada-4dd1-9253-9f7780de98c3", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5998), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5999), 4, "B" },
                    { "a4f2c278-3a5f-4660-8453-bb6d012130d1", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5968), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5969), 5, "E" },
                    { "aa30f848-20e0-415c-8c1d-75f675f7bab8", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6048), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6049), 4, "E" },
                    { "aaecf6da-ae1d-45d2-8f1a-3ee433ed7d07", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6000), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6001), 5, "B" },
                    { "aaedebb0-c6c1-40e1-b13d-cb55d072bd36", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6010), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6011), 3, "C" },
                    { "ad271cf2-f6bf-4a2e-8985-61bb6dc0e77c", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6075), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6076), 2, "B" },
                    { "af039fa1-26ba-4cb4-aa2b-1f40b9fac80f", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5970), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5971), 6, "E" },
                    { "b0c710ec-2f19-4e15-a169-c7b50d14583d", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5995), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5996), 3, "B" },
                    { "b136380d-746e-489b-b4ed-aff65e317f15", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5891), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5892), 5, "A" },
                    { "b1d18ec4-83f4-46ee-bdc7-2457df92c0ce", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6018), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6019), 6, "C" },
                    { "b3b3d835-1dc2-427e-a9ee-a324ce4c9f9f", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5966), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5967), 4, "E" },
                    { "b710b7b7-912b-4b34-bac2-fbab0d049658", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6043), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6045), 2, "E" },
                    { "b8d37705-5b5f-4da8-85f3-1864d2d8df28", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6002), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6003), 6, "B" },
                    { "be01bac3-f372-48f1-9c28-3652cc3636de", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6085), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6091), 6, "B" },
                    { "c4810889-982b-4f9a-8f13-10be63b6085d", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6033), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6034), 4, "D" },
                    { "c8d56361-0c8d-4c2f-a289-d4523550d391", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6056), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6057), 1, "A" },
                    { "c9cb41ac-69c3-404b-9b3c-3e52221a5afc", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6058), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6059), 2, "A" },
                    { "cb7a1e70-40d8-4524-8fa2-ec4ea532081f", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6110), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6112), 2, "D" },
                    { "cf05b559-9c95-4563-ad12-50e544868f9d", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5976), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5977), 2, "A" },
                    { "d89cb32e-5285-4291-9919-b89beaedff4e", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5846), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5867), 1, "A" },
                    { "d9b7823b-387f-4f1b-b021-1492263208c2", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6040), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6041), 1, "E" },
                    { "dca17ac0-cfb3-4842-8ad0-b3ea1489360a", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6107), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6108), 1, "D" },
                    { "ddc0f1c5-dc83-43b3-b642-8af4ed3515a1", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5918), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5919), 1, "C" },
                    { "dea49292-82be-4a8c-a02c-2ba3472dc412", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6030), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6031), 3, "D" },
                    { "e733a459-d63d-4be9-b4f6-dc4213670837", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6071), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6072), 1, "B" },
                    { "e7b387a1-4d54-46ce-b8db-9f8d28a070e3", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5962), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5963), 3, "E" },
                    { "eec0499d-de6c-424b-864a-0b1a96dfc959", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6027), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6028), 2, "D" },
                    { "ef814bbf-d24c-45c3-bae3-d8f64f768c88", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6102), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6103), 5, "C" },
                    { "f00d82d7-07bc-4daa-89fc-2c17a9e5035a", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6127), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6128), 3, "E" },
                    { "f2fc6f67-e6a1-4ddc-86fd-8d16ad31baa2", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5960), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5961), 2, "E" },
                    { "f32b1918-6bb3-476b-8dd4-4388ea8bc6e6", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5926), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5927), 4, "C" },
                    { "f4eb3ef0-5da8-4398-a0fa-61003f1e1879", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6013), null, null, "HallB", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6014), 4, "C" },
                    { "f6d38201-6d89-4690-afc0-236fdf449bce", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6069), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6070), 6, "A" },
                    { "faf0f1f8-d4c7-43d4-98ae-5bd1fd32d4b0", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5941), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5942), 3, "D" },
                    { "fba38500-9c94-4103-9be3-cfc1e015397c", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6064), null, null, "HallC", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(6065), 4, "A" },
                    { "ff956a4f-dbb5-41de-8ffe-6efbe4ce35f9", "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5916), null, null, "HallA", true, "System", new DateTime(2024, 6, 27, 1, 1, 9, 726, DateTimeKind.Local).AddTicks(5917), 6, "B" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_TicketID1",
                schema: "dbo",
                table: "OrderDetails",
                column: "TicketID1");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderID",
                schema: "dbo",
                table: "OrderDetails",
                column: "OrderID",
                principalSchema: "dbo",
                principalTable: "Orders",
                principalColumn: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Tickets_TicketID",
                schema: "dbo",
                table: "OrderDetails",
                column: "TicketID",
                principalSchema: "dbo",
                principalTable: "Tickets",
                principalColumn: "TicketID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Tickets_TicketID1",
                schema: "dbo",
                table: "OrderDetails",
                column: "TicketID1",
                principalSchema: "dbo",
                principalTable: "Tickets",
                principalColumn: "TicketID");
        }
    }
}
