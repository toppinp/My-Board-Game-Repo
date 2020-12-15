using MyBoardGameRepo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBoardGameRepo.Models
{
    [Table("Players")]
    public class Player
    {
        public int    PlayerId { get; set; }

        public string Name     { get; set; }

        public int?    Age      { get; set; }

        [MaxLength(128)]
        [Required(ErrorMessage ="Password Is Required")]
        [UIHint("password")]
        public string Password { get; set; }

        public bool   IsAdmin  { get; set; } = false;
    }
}
