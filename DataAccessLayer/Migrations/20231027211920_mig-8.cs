using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberCategory_Categories_CategoryId",
                table: "MemberCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberCategory_Members_MemberId",
                table: "MemberCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberTrainer_Members_MemberId",
                table: "MemberTrainer");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberTrainer_Trainers_TrainerId",
                table: "MemberTrainer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MemberTrainer",
                table: "MemberTrainer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MemberCategory",
                table: "MemberCategory");

            migrationBuilder.RenameTable(
                name: "MemberTrainer",
                newName: "MemberTrainers");

            migrationBuilder.RenameTable(
                name: "MemberCategory",
                newName: "MemberCategories");

            migrationBuilder.RenameIndex(
                name: "IX_MemberTrainer_TrainerId",
                table: "MemberTrainers",
                newName: "IX_MemberTrainers_TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_MemberCategory_CategoryId",
                table: "MemberCategories",
                newName: "IX_MemberCategories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MemberTrainers",
                table: "MemberTrainers",
                columns: new[] { "MemberId", "TrainerId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MemberCategories",
                table: "MemberCategories",
                columns: new[] { "MemberId", "CategoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MemberCategories_Categories_CategoryId",
                table: "MemberCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberCategories_Members_MemberId",
                table: "MemberCategories",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberTrainers_Members_MemberId",
                table: "MemberTrainers",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberTrainers_Trainers_TrainerId",
                table: "MemberTrainers",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberCategories_Categories_CategoryId",
                table: "MemberCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberCategories_Members_MemberId",
                table: "MemberCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberTrainers_Members_MemberId",
                table: "MemberTrainers");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberTrainers_Trainers_TrainerId",
                table: "MemberTrainers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MemberTrainers",
                table: "MemberTrainers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MemberCategories",
                table: "MemberCategories");

            migrationBuilder.RenameTable(
                name: "MemberTrainers",
                newName: "MemberTrainer");

            migrationBuilder.RenameTable(
                name: "MemberCategories",
                newName: "MemberCategory");

            migrationBuilder.RenameIndex(
                name: "IX_MemberTrainers_TrainerId",
                table: "MemberTrainer",
                newName: "IX_MemberTrainer_TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_MemberCategories_CategoryId",
                table: "MemberCategory",
                newName: "IX_MemberCategory_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MemberTrainer",
                table: "MemberTrainer",
                columns: new[] { "MemberId", "TrainerId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MemberCategory",
                table: "MemberCategory",
                columns: new[] { "MemberId", "CategoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MemberCategory_Categories_CategoryId",
                table: "MemberCategory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberCategory_Members_MemberId",
                table: "MemberCategory",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberTrainer_Members_MemberId",
                table: "MemberTrainer",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberTrainer_Trainers_TrainerId",
                table: "MemberTrainer",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
