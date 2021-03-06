﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyBoardGameRepo.Models;

namespace MyBoardGameRepo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("MyBoardGameRepo.Models.BoardGame", b =>
                {
                    b.Property<int>("BoardGameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AllowedAge")
                        .HasColumnType("int");

                    b.Property<bool>("CheckedOut")
                        .HasColumnType("bit");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberOfPlayers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("BoardGameId");

                    b.HasIndex("PlayerId");

                    b.ToTable("BoardGames");

                    b.HasData(
                        new
                        {
                            BoardGameId = 1,
                            AllowedAge = 14,
                            CheckedOut = false,
                            CompanyName = "Buffalo Games",
                            Description = "The laugh out loud pretend to know your friends game.",
                            Genre = "Party Games",
                            Image = "https://plzcdn.com/ZillaIMG/50fb1509440c2b9dda58fb7813372c4d_1350123497.jpg",
                            Name = "Truth Be Told",
                            NumberOfPlayers = "3 - 8 Players"
                        },
                        new
                        {
                            BoardGameId = 2,
                            AllowedAge = 10,
                            CheckedOut = false,
                            CompanyName = "Play Monster",
                            Description = "Just spit it out!",
                            Genre = "Party Games",
                            Image = "https://th.bing.com/th/id/OIP.r3fV0748qExcpVs7N-9PmgHaHa?pid=Api&rs=1",
                            Name = "5 Second Rule",
                            NumberOfPlayers = "3 or More Players"
                        },
                        new
                        {
                            BoardGameId = 3,
                            AllowedAge = 14,
                            CheckedOut = false,
                            CompanyName = "Big Potato Games",
                            Description = "Blend in, don't get caught!",
                            Genre = "Party Games",
                            Image = "https://cdn.shopify.com/s/files/1/0921/7330/products/3_7c13f1db-49a4-458d-933b-fcb8fd66d4d8_670x670.jpg?v=1528539955",
                            Name = "The Chameleon",
                            NumberOfPlayers = "3 - 8 Players"
                        },
                        new
                        {
                            BoardGameId = 4,
                            AllowedAge = 12,
                            CheckedOut = false,
                            CompanyName = "Parker Brothers",
                            Description = "The crowd pleasing, fast thinking categories game.",
                            Genre = "Party Games",
                            Image = "https://th.bing.com/th/id/OIP.YfEq31g7aMsHtmwV6DzZ1QHaHa?pid=Api&rs=1",
                            Name = "Scattegories",
                            NumberOfPlayers = "2 - 6 Players"
                        },
                        new
                        {
                            BoardGameId = 5,
                            AllowedAge = 17,
                            CheckedOut = false,
                            CompanyName = "Cards Against Humanity",
                            Description = "A party game for horrible people.",
                            Genre = "Party Games",
                            Image = "https://www.forevergeek.com/wp-content/media/2013/12/cards-against-humanity.jpg",
                            Name = "Cards Against Humanity",
                            NumberOfPlayers = "4 - 20 Players"
                        },
                        new
                        {
                            BoardGameId = 6,
                            AllowedAge = 12,
                            CheckedOut = false,
                            CompanyName = "Chronicle Books",
                            Description = "Who can you trust when everyone tastes the same?",
                            Genre = "Challenge",
                            Image = "https://www.shopfuego.com/v/vspfiles/photos/201800014741-3.jpg?v-cache=1585728180",
                            Name = "Donner Dinner Party",
                            NumberOfPlayers = "4 - 10 Players"
                        },
                        new
                        {
                            BoardGameId = 7,
                            AllowedAge = 5,
                            CheckedOut = false,
                            CompanyName = "Catan Studio",
                            Description = "Trade, Build, Settle.",
                            Genre = "Strategy",
                            Image = "https://th.bing.com/th/id/OIP.3XWFN547DT-8P7Y6pYTogwHaHa?pid=Api&rs=1",
                            Name = "Catan",
                            NumberOfPlayers = "3 - 4 Players"
                        },
                        new
                        {
                            BoardGameId = 8,
                            AllowedAge = 7,
                            CheckedOut = false,
                            CompanyName = "Plaid Hat Games",
                            Description = "Adventure Awaits!",
                            Genre = "Role Playing",
                            Image = "https://coopboardgames.com/wp-content/uploads/2016/06/mice-and-mystics-board-game-review.jpg",
                            Name = "Mice & Mystics",
                            NumberOfPlayers = "1 - 4 Players"
                        },
                        new
                        {
                            BoardGameId = 9,
                            AllowedAge = 16,
                            CheckedOut = false,
                            CompanyName = "Hasbro Gaming",
                            Description = "The best trivia from 2000 to today.",
                            Genre = "Trivia",
                            Image = "https://www.gamesmen.com.au/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/t/r/trivial_pursuit_2000_2_.jpg",
                            Name = "Trivial Pursuit 2000s",
                            NumberOfPlayers = "2 - 6 Players"
                        },
                        new
                        {
                            BoardGameId = 10,
                            AllowedAge = 3,
                            CheckedOut = false,
                            CompanyName = "Hasbro Gaming",
                            Description = "The classic game of sweet adventures.",
                            Genre = "Family",
                            Image = "https://i5.walmartimages.com/asr/5b49d981-d03a-4051-9bdd-54ee28a1f5ac_1.b75f2c28b4ca986425449ca93b185ce4.jpeg?odnHeight=450&odnWidth=450&odnBg=ffffff",
                            Name = "Candy Land",
                            NumberOfPlayers = "2 - 4 Players"
                        });
                });

            modelBuilder.Entity("MyBoardGameRepo.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("MyBoardGameRepo.Models.BoardGame", b =>
                {
                    b.HasOne("MyBoardGameRepo.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId");

                    b.Navigation("Player");
                });
#pragma warning restore 612, 618
        }
    }
}
