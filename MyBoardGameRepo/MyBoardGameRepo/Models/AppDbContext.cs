using Microsoft.EntityFrameworkCore;

namespace MyBoardGameRepo.Models
{
    public class AppDbContext : DbContext
    {
        //   F i e l d s   &   P r o p e t r i e s

        public DbSet<BoardGame> BoardGames { get; set; }

        public DbSet<Player>    Players    { get; set; }


        //   C o n s t r u c t o r s

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //   M e t h o d s

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BoardGame>().HasData
               (new BoardGame
               {
                   BoardGameId = 1,
                   Name = "Truth Be Told",
                   Description = "The laugh out loud pretend to know your friends game.",
                   CompanyName = "Buffalo Games",
                   NumberOfPlayers = "3 - 8 Players",
                   CheckedOut = false,
                   Genre = "Party Games",
                   AllowedAge = 14,
                   Image = "https://plzcdn.com/ZillaIMG/50fb1509440c2b9dda58fb7813372c4d_1350123497.jpg"
               });

            modelBuilder.Entity<BoardGame>().HasData
               (new BoardGame
               {
                   BoardGameId = 2,
                   Name = "5 Second Rule",
                   Description = "Just spit it out!",
                   CompanyName = "Play Monster",
                   NumberOfPlayers = "3 or More Players",
                   CheckedOut = false,
                   Genre = "Party Games",
                   AllowedAge = 10,
                   Image = "https://th.bing.com/th/id/OIP.r3fV0748qExcpVs7N-9PmgHaHa?pid=Api&rs=1"
               });

            modelBuilder.Entity<BoardGame>().HasData
               (new BoardGame
               {
                   BoardGameId = 3,
                   Name = "The Chameleon",
                   Description = "Blend in, don't get caught!",
                   CompanyName = "Big Potato Games",
                   NumberOfPlayers = "3 - 8 Players",
                   CheckedOut = false,
                   Genre = "Party Games",
                   AllowedAge = 14,
                   Image = "https://cdn.shopify.com/s/files/1/0921/7330/products/3_7c13f1db-49a4-458d-933b-fcb8fd66d4d8_670x670.jpg?v=1528539955"
               });

            modelBuilder.Entity<BoardGame>().HasData
               (new BoardGame
               {
                   BoardGameId = 4,
                   Name = "Scattegories",
                   Description = "The crowd pleasing, fast thinking categories game.",
                   CompanyName = "Parker Brothers",
                   NumberOfPlayers = "2 - 6 Players",
                   CheckedOut = false,
                   Genre = "Party Games",
                   AllowedAge = 12,
                   Image = "https://th.bing.com/th/id/OIP.YfEq31g7aMsHtmwV6DzZ1QHaHa?pid=Api&rs=1"
               });

            modelBuilder.Entity<BoardGame>().HasData
               (new BoardGame
               {
                   BoardGameId = 5,
                   Name = "Cards Against Humanity",
                   Description = "A party game for horrible people.",
                   CompanyName = "Cards Against Humanity",
                   NumberOfPlayers = "4 - 20 Players",
                   CheckedOut = false,
                   Genre = "Party Games",
                   AllowedAge = 17,
                   Image = "https://www.forevergeek.com/wp-content/media/2013/12/cards-against-humanity.jpg"
               });

            modelBuilder.Entity<BoardGame>().HasData
               (new BoardGame
               {
                   BoardGameId = 6,
                   Name = "Donner Dinner Party",
                   Description = "Who can you trust when everyone tastes the same?",
                   CompanyName = "Chronicle Books",
                   NumberOfPlayers = "4 - 10 Players",
                   CheckedOut = false,
                   Genre = "Challenge",
                   AllowedAge = 12,
                   Image = "https://www.shopfuego.com/v/vspfiles/photos/201800014741-3.jpg?v-cache=1585728180"
               });

            modelBuilder.Entity<BoardGame>().HasData
               (new BoardGame
               {
                   BoardGameId = 7,
                   Name = "Catan",
                   Description = "Trade, Build, Settle.",
                   CompanyName = "Catan Studio",
                   NumberOfPlayers = "3 - 4 Players",
                   CheckedOut = false,
                   Genre = "Strategy",
                   AllowedAge = 5,
                   Image = "https://th.bing.com/th/id/OIP.3XWFN547DT-8P7Y6pYTogwHaHa?pid=Api&rs=1"
               });

            modelBuilder.Entity<BoardGame>().HasData
               (new BoardGame
               {
                   BoardGameId = 8,
                   Name = "Mice & Mystics",
                   Description = "Adventure Awaits!",
                   CompanyName = "Plaid Hat Games",
                   NumberOfPlayers = "1 - 4 Players",
                   CheckedOut = false,
                   Genre = "Role Playing",
                   AllowedAge = 7,
                   Image = "https://coopboardgames.com/wp-content/uploads/2016/06/mice-and-mystics-board-game-review.jpg"
               });

            modelBuilder.Entity<BoardGame>().HasData
               (new BoardGame
               {
                   BoardGameId = 9,
                   Name = "Trivial Pursuit 2000s",
                   Description = "The best trivia from 2000 to today.",
                   CompanyName = "Hasbro Gaming",
                   NumberOfPlayers = "2 - 6 Players",
                   CheckedOut = false,
                   Genre = "Trivia",
                   AllowedAge = 16,
                   Image = "https://www.gamesmen.com.au/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/t/r/trivial_pursuit_2000_2_.jpg"
               });

            modelBuilder.Entity<BoardGame>().HasData
               (new BoardGame
               {
                   BoardGameId = 10,
                   Name = "Candy Land",
                   Description = "The classic game of sweet adventures.",
                   CompanyName = "Hasbro Gaming",
                   NumberOfPlayers = "2 - 4 Players",
                   CheckedOut = false,
                   Genre = "Family",
                   AllowedAge = 3,
                   Image = "https://i5.walmartimages.com/asr/5b49d981-d03a-4051-9bdd-54ee28a1f5ac_1.b75f2c28b4ca986425449ca93b185ce4.jpeg?odnHeight=450&odnWidth=450&odnBg=ffffff"
               });
        }
    }
}
