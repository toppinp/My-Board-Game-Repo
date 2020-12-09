using MyBoardGameRepo.Models.BoardGames;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBoardGameRepo.Models.Players
{
    [Table("Players")]
    public class Player
    {
        public int PlayerId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

    }
}
