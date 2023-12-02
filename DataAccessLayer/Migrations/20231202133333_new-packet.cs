using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class newpacket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Packets",
                columns: new[] { "PacketId", "PacketDescription", "PacketPrice", "PacketType" },
                values: new object[] { 1, "Antrenman Planı, Beslenme Planı, Haftalık Kontrol", 1500.0, "Normal" });

            migrationBuilder.InsertData(
                table: "Packets",
                columns: new[] { "PacketId", "PacketDescription", "PacketPrice", "PacketType" },
                values: new object[] { 2, "Antrenman Planı, Beslenme Planı, Haftalık Kontrol, Bireysel Koç, Supplement Desteği", 6000.0, "Pro" });

            migrationBuilder.InsertData(
                table: "Packets",
                columns: new[] { "PacketId", "PacketDescription", "PacketPrice", "PacketType" },
                values: new object[] { 3, "Antrenman Planı, Beslenme Planı, Haftalık Kontrol, Bireysel Koç, Supplement Desteği, Whatsapp Görüşme, Pro Sporcularla Tanışma Fırsatı", 10000.0, "Jossoft Özel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Packets",
                keyColumn: "PacketId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Packets",
                keyColumn: "PacketId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Packets",
                keyColumn: "PacketId",
                keyValue: 3);
        }
    }
}
