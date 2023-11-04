using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Trainers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Trainers",
                newName: "NameSurname");

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "TrainerId", "CategoryId", "NameSurname", "TrainerDescription", "TrainerImage" },
                values: new object[,]
                {
                    { 1, 1, "Yusuf Dilekci", "Fitness - Trainer - 1", "trainer1.jpg" },
                    { 2, 1, "Savas Cebeci", "Fitness - Trainer - 2", "trainer2.jpg" },
                    { 3, 2, "Birol E.", "Kickbox - Trainer - 1", "trainer3.jpg" },
                    { 4, 3, "Mert A.", "Zumba - Trainer - 1", "trainer4.jpg" },
                    { 5, 3, "Azat T.", "Zumba - Trainer - 2", "trainer5.jpg" },
                    { 6, 4, "Oguz R.", "Pilates - Trainer - 1", "trainer6.jpg" },
                    { 7, 5, "Sadik S.", "Coaching - 1", "trainer7.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 7);

            migrationBuilder.RenameColumn(
                name: "NameSurname",
                table: "Trainers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Trainers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
