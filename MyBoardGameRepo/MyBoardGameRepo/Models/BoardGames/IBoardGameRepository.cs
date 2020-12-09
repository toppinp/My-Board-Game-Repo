using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBoardGameRepo.Models.BoardGames
{
    public interface IBoardGameRepository
    {
        // M e t h o d s

        // C r e a t e

        public BoardGame AddGame(BoardGame boardGame);


        // R e a d 

        public IQueryable<BoardGame> GetAllBoardGames();

        public BoardGame GetGameById(int gameId);

        public IQueryable<BoardGame> GetGamesByGenre(string genre);

        // U p d a t e

        public BoardGame UpdateGame(BoardGame boardGame);


        public BoardGame CheckInGame(BoardGame boardGame);

        public BoardGame CheckOutGame(BoardGame boardGame);

        // D e l e t e

        public bool DeleteGame(int gameId);


    }
}
