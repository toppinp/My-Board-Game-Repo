using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBoardGameRepo.Migrations
{
    public partial class AddImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Players",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "BoardGames",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "BoardGameId",
                keyValue: 1,
                column: "Image",
                value: "https://plzcdn.com/ZillaIMG/50fb1509440c2b9dda58fb7813372c4d_1350123497.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "BoardGameId",
                keyValue: 2,
                column: "Image",
                value: "https://th.bing.com/th/id/OIP.r3fV0748qExcpVs7N-9PmgHaHa?pid=Api&rs=1");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "BoardGameId",
                keyValue: 3,
                column: "Image",
                value: "https://cdn.shopify.com/s/files/1/0921/7330/products/3_7c13f1db-49a4-458d-933b-fcb8fd66d4d8_670x670.jpg?v=1528539955");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "BoardGameId",
                keyValue: 4,
                column: "Image",
                value: "https://th.bing.com/th/id/OIP.YfEq31g7aMsHtmwV6DzZ1QHaHa?pid=Api&rs=1");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "BoardGameId",
                keyValue: 5,
                column: "Image",
                value: "https://www.forevergeek.com/wp-content/media/2013/12/cards-against-humanity.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "BoardGameId",
                keyValue: 6,
                column: "Image",
                value: "https://www.shopfuego.com/v/vspfiles/photos/201800014741-3.jpg?v-cache=1585728180");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "BoardGameId",
                keyValue: 7,
                column: "Image",
                value: "https://th.bing.com/th/id/OIP.3XWFN547DT-8P7Y6pYTogwHaHa?pid=Api&rs=1");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "BoardGameId",
                keyValue: 8,
                column: "Image",
                value: "https://coopboardgames.com/wp-content/uploads/2016/06/mice-and-mystics-board-game-review.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "BoardGameId",
                keyValue: 9,
                column: "Image",
                value: "https://www.gamesmen.com.au/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/t/r/trivial_pursuit_2000_2_.jpg");

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "BoardGameId",
                keyValue: 10,
                column: "Image",
                value: "https://i5.walmartimages.com/asr/5b49d981-d03a-4051-9bdd-54ee28a1f5ac_1.b75f2c28b4ca986425449ca93b185ce4.jpeg?odnHeight=450&odnWidth=450&odnBg=ffffff");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "BoardGames");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Age", "IsAdmin", "Name", "Password" },
                values: new object[] { 1, 40, true, "Patrick Toppin", "Password" });
        }
    }
}
