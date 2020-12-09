using Microsoft.EntityFrameworkCore;
using MyBoardGameRepo.Models.BoardGames;
using MyBoardGameRepo.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBoardGameRepo.Models
{
    public class AppDbContext : DbContext
    {
        //   F i e l d s   &   P r o p e t r i e s

        public DbSet<BoardGame> BoardGames { get; set; }

        public DbSet<Player> Players { get; set; }


        //   C o n s t r u c t o r s

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //   M e t h o d s

        protected override void OnModelCreating
   (ModelBuilder modelBuilder)
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
                   PlayerId = 1
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
                   PlayerId = 1
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
                   PlayerId = 1
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
                   PlayerId = 1
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
                   PlayerId = 1
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
                   PlayerId = 1
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
                   PlayerId = 1
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
                   PlayerId = 1
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
                   PlayerId = 1
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
                   PlayerId = 1
               });

            modelBuilder.Entity<Player>().HasData
                (new Player
                {
                    PlayerId = 1
                });

            modelBuilder.Entity<Player>().HasData
               (new Player
               {
                   PlayerId = 2,
                   Name = "Patrick Toppin",
                   Age = 40,
               });

            modelBuilder.Entity<Player>().HasData
               (new Player
               {
                   PlayerId = 3,
                   Name = "Lil Kid",
                   Age = 7,
               });

            modelBuilder.Entity<Player>().HasData
               (new Player
               {
                   PlayerId = 4,
                   Name = "Teenager Kid",
                   Age = 16,
               });
        }
    }
}
