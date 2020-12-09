using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBoardGameRepo.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });

            migrationBuilder.CreateTable(
                name: "BoardGames",
                columns: table => new
                {
                    BoardGameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfPlayers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckedOut = table.Column<bool>(type: "bit", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllowedAge = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardGames", x => x.BoardGameId);
                    table.ForeignKey(
                        name: "FK_BoardGames_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Age", "Name" },
                values: new object[,]
                {
                    { 1, 0, null },
                    { 2, 40, "Patrick Toppin" },
                    { 3, 7, "Lil Kid" },
                    { 4, 16, "Teenager Kid" }
                });

            migrationBuilder.InsertData(
                table: "BoardGames",
                columns: new[] { "BoardGameId", "AllowedAge", "CheckedOut", "CompanyName", "Description", "Genre", "Name", "NumberOfPlayers", "PlayerId" },
                values: new object[,]
                {
                    { 1, 14, false, "Buffalo Games", "The laugh out loud pretend to know your friends game.", "Party Games", "Truth Be Told", "3 - 8 Players", 1 },
                    { 2, 10, false, "Play Monster", "Just spit it out!", "Party Games", "5 Second Rule", "3 or More Players", 1 },
                    { 3, 14, false, "Big Potato Games", "Blend in, don't get caught!", "Party Games", "The Chameleon", "3 - 8 Players", 1 },
                    { 4, 12, false, "Parker Brothers", "The crowd pleasing, fast thinking categories game.", "Party Games", "Scattegories", "2 - 6 Players", 1 },
                    { 5, 17, false, "Cards Against Humanity", "A party game for horrible people.", "Party Games", "Cards Against Humanity", "4 - 20 Players", 1 },
                    { 6, 12, false, "Chronicle Books", "Who can you trust when everyone tastes the same?", "Challenge", "Donner Dinner Party", "4 - 10 Players", 1 },
                    { 7, 5, false, "Catan Studio", "Trade, Build, Settle.", "Strategy", "Catan", "3 - 4 Players", 1 },
                    { 8, 7, false, "Plaid Hat Games", "Adventure Awaits!", "Role Playing", "Mice & Mystics", "1 - 4 Players", 1 },
                    { 9, 16, false, "Hasbro Gaming", "The best trivia from 2000 to today.", "Trivia", "Trivial Pursuit 2000s", "2 - 6 Players", 1 },
                    { 10, 3, false, "Hasbro Gaming", "The classic game of sweet adventures.", "Family", "Candy Land", "2 - 4 Players", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoardGames_PlayerId",
                table: "BoardGames",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoardGames");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
