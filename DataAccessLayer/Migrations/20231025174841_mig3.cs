using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryInfo", "CategoryName", "CategoryPrice" },
                values: new object[,]
                {
                    { 1, "üiğiüğğşğşsğaüğ", "Fitness", 1200.0 },
                    { 2, "üiğiüğğşğşsğaüğ", "Kickbox", 1700.0 },
                    { 3, "üiğiüğğşğşsğaüğ", "Zumba", 1500.0 },
                    { 4, "üiğiüğğşğşsğaüğ", "Pilates", 700.0 },
                    { 5, "üiğiüğğşğşsğaüğ", "Coaching", 15.699999999999999 }
                });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "DescriptionId", "CategoryId", "DescriptionName" },
                values: new object[,]
                {
                    { 1, 1, "Fitnes-1sweıpüqrıpoıqwmskdf" },
                    { 2, 1, "Fitnes-2weıpüqrıpoıqwmskdf" },
                    { 3, 1, "Fitnes-3weıpüqrıpoıqwmskdf" },
                    { 4, 2, "Kickbox-1sweıpüqrıpoıqwmskdf" },
                    { 5, 2, "Kickbox-2sweıpüqrıpoıqwmskdf" },
                    { 6, 2, "Kickbox-3weıpüqrıpoıqwmskdf" },
                    { 7, 3, "Zumba-1weıpüqrıpoıqwmskdf" },
                    { 8, 3, "Zumba-2weıpüqrıpoıqwmskdf" },
                    { 9, 3, "Zumba-3weıpüqrıpoıqwmskdf" },
                    { 10, 4, "Pilates-1weıpüqrıpoıqwmskdf" },
                    { 11, 4, "Pilates-2weıpüqrıpoıqwmskdf" },
                    { 12, 4, "Pilates-3weıpüqrıpoıqwmskdf" },
                    { 13, 5, "Coaching-1weıpüqrıpoıqwmskdf" },
                    { 14, 5, "Coaching-2weıpüqrıpoıqwmskdf" },
                    { 15, 5, "Coaching-3weıpüqrıpoıqwmskdf" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "CategoryId", "ImageName" },
                values: new object[,]
                {
                    { 1, 1, "fitness1.jpg" },
                    { 2, 1, "fitness2.jpg" },
                    { 3, 1, "fitness3.jpg" },
                    { 4, 2, "kickbox1.jpg" },
                    { 5, 2, "kickbox2.jpg" },
                    { 6, 2, "kickbox3.jpg" },
                    { 7, 3, "zumba1.jpg" },
                    { 8, 3, "zumba2.jpg" },
                    { 9, 3, "zumba3.jpg" },
                    { 10, 4, "pilates1.jpg" },
                    { 11, 4, "pilates2.jpg" },
                    { 12, 4, "pilates3.jpg" },
                    { 13, 5, "coaching1.jpg" },
                    { 14, 5, "coaching2.jpg" },
                    { 15, 5, "coaching3.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);
        }
    }
}
