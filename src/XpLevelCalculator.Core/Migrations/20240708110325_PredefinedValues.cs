using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace XpLevelCalculator.Core.Migrations
{
    /// <inheritdoc />
    public partial class PredefinedValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "Level", "LevelXp", "TotalXp" },
                values: new object[,]
                {
                    { 1L, 1, 0L, 0L },
                    { 2L, 2, 300L, 300L },
                    { 3L, 3, 450L, 750L },
                    { 4L, 4, 630L, 1380L },
                    { 5L, 5, 970L, 2350L },
                    { 6L, 6, 1440L, 3790L },
                    { 7L, 7, 1940L, 5730L },
                    { 8L, 8, 3000L, 8730L },
                    { 9L, 9, 3920L, 12650L },
                    { 10L, 10, 4970L, 17620L },
                    { 11L, 11, 5900L, 23520L },
                    { 12L, 12, 7430L, 30950L },
                    { 13L, 13, 8620L, 39570L },
                    { 14L, 14, 10200L, 49770L },
                    { 15L, 15, 11300L, 61070L },
                    { 16L, 16, 13100L, 74170L },
                    { 17L, 17, 15200L, 89370L },
                    { 18L, 18, 17400L, 106770L },
                    { 19L, 19, 19600L, 126370L },
                    { 20L, 20, 21900L, 148270L },
                    { 21L, 21, 24300L, 172570L },
                    { 22L, 22, 27400L, 199970L },
                    { 23L, 23, 30600L, 230750L },
                    { 24L, 24, 33900L, 264470L },
                    { 25L, 25, 37300L, 301770L },
                    { 26L, 26, 40800L, 342570L },
                    { 27L, 27, 49200L, 391770L },
                    { 28L, 28, 54600L, 446370L },
                    { 29L, 29, 61900L, 508270L },
                    { 30L, 30, 65600L, 573870L },
                    { 31L, 31, 68400L, 642270L },
                    { 32L, 32, 74000L, 716270L },
                    { 33L, 33, 82700L, 798970L },
                    { 34L, 34, 88700L, 887670L },
                    { 35L, 35, 95000L, 982670L },
                    { 36L, 36, 102000L, 1084670L },
                    { 37L, 37, 113000L, 1197670L },
                    { 38L, 38, 121000L, 1318670L },
                    { 39L, 39, 133000L, 1451670L },
                    { 40L, 40, 142000L, 1593670L },
                    { 41L, 41, 155000L, 1748670L },
                    { 42L, 42, 163000L, 1911670L },
                    { 43L, 43, 171000L, 2082670L },
                    { 44L, 44, 179000L, 2261670L },
                    { 45L, 45, 187000L, 2448670L },
                    { 46L, 46, 195000L, 2643670L },
                    { 47L, 47, 214000L, 2857670L },
                    { 48L, 48, 229000L, 3086670L },
                    { 49L, 49, 244000L, 3330670L },
                    { 50L, 50, 259000L, 3589670L },
                    { 51L, 51, 421000L, 4010670L },
                    { 52L, 52, 500000L, 4510670L },
                    { 53L, 53, 580000L, 5090670L },
                    { 54L, 54, 663000L, 5753670L },
                    { 55L, 55, 749000L, 6502670L },
                    { 56L, 56, 837000L, 7339670L },
                    { 57L, 57, 927000L, 8266670L },
                    { 58L, 58, 1019000L, 9285670L },
                    { 59L, 59, 1114000L, 10399670L },
                    { 60L, 60, 1211000L, 11610670L },
                    { 61L, 61, 1387000L, 12997670L },
                    { 62L, 62, 1456000L, 14453670L },
                    { 63L, 63, 1534000L, 15987670L },
                    { 64L, 64, 1621000L, 17608670L },
                    { 65L, 65, 1720000L, 19328670L },
                    { 66L, 66, 1834000L, 21162670L },
                    { 67L, 67, 1968000L, 23130670L },
                    { 68L, 68, 2126000L, 25256670L },
                    { 69L, 69, 2137000L, 27393670L },
                    { 70L, 70, 2550000L, 29943670L },
                    { 71L, 71, 2923000L, 32866670L },
                    { 72L, 72, 3018000L, 35884670L },
                    { 73L, 73, 3153000L, 39037670L },
                    { 74L, 74, 3324000L, 42361670L },
                    { 75L, 75, 3532000L, 45893670L },
                    { 76L, 76, 3770600L, 49664270L },
                    { 77L, 77, 4066000L, 53730270L },
                    { 78L, 78, 4377000L, 58107270L },
                    { 79L, 79, 4777000L, 62884270L },
                    { 80L, 80, 5256000L, 68140270L },
                    { 81L, 81, 5992000L, 74132270L },
                    { 82L, 82, 6171700L, 80303270L },
                    { 83L, 83, 6942000L, 87245270L },
                    { 84L, 84, 7205000L, 94450270L },
                    { 85L, 85, 7948000L, 102398270L },
                    { 86L, 86, 8287000L, 110685270L },
                    { 87L, 87, 9231000L, 119916270L },
                    { 88L, 88, 9529000L, 129445270L },
                    { 89L, 89, 10459000L, 139904270L },
                    { 90L, 90, 10838000L, 150742270L },
                    { 91L, 91, 13278000L, 164020270L },
                    { 92L, 92, 13659000L, 177679270L },
                    { 93L, 93, 15348000L, 193027270L },
                    { 94L, 94, 15912000L, 208939270L },
                    { 95L, 95, 17534000L, 226437270L },
                    { 96L, 96, 18263000L, 244736270L },
                    { 97L, 97, 20322000L, 265058270L },
                    { 98L, 98, 20957000L, 286015270L },
                    { 99L, 99, 22979000L, 308994270L },
                    { 100L, 100, 23789000L, 332783270L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 100L);
        }
    }
}
