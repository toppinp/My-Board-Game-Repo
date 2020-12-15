using MyBoardGameRepo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBoardGameRepo.Models
{
    [Table("BoardGames")]
    public class BoardGame
    {
        public int       BoardGameId  { get; set; }

        [Required(ErrorMessage = "Game Name Is Required")]
        public string    Name         { get; set; }

        public string    Description  { get; set; }

        public string    CompanyName  { get; set; }

        public string    NumberOfPlayers { get; set; }

        public bool      CheckedOut   { get; set; } = false;

        public string    Genre        { get; set; }

        public int       AllowedAge   { get; set; }

        [ForeignKey("Players")]
        public int?     PlayerId      { get; set; }

        public Player   Player        { get; set; }

        public string   Image         { get; set; }
    }
}
