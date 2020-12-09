using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBoardGameRepo.Models.BoardGames
{
    public class EfBoardGameRepository : IBoardGameRepository
    {

        // F i e l d s   &   P r o p e r t i e s

        private AppDbContext _context;


        // C o n s t r u c t o r s

        public EfBoardGameRepository(AppDbContext context)
        {
            _context = context;
        }


        // M e t h o d s

        // C r e a t e

        public BoardGame AddGame(BoardGame boardGame)
        {
            _context.BoardGames.Add(boardGame);
            boardGame.PlayerId = 1;
            _context.SaveChanges();
            return boardGame;

        }



        // R e a d 

        public IQueryable<BoardGame> GetAllBoardGames()
        {
            return _context.BoardGames;
        }


        public BoardGame GetGameById(int gameId)
        {
            return _context.BoardGames.Find(gameId);
        }


        public IQueryable<BoardGame> GetGamesByGenre(string genre)
        {
            return _context.BoardGames
                   .Where(g => g.Genre.Contains(genre));
        }


        // U p d a t e

        public BoardGame UpdateGame(BoardGame boardGame)
        {
            BoardGame boardGameToUpdate = _context.BoardGames.Find(boardGame.BoardGameId);
            if(boardGameToUpdate != null)
            {
                boardGameToUpdate.CheckedOut = boardGame.CheckedOut;
                boardGameToUpdate.CompanyName = boardGame.CompanyName;
                boardGameToUpdate.Description = boardGame.Description;
                boardGameToUpdate.Genre = boardGame.Genre;
                boardGameToUpdate.Name = boardGame.Name;
                boardGameToUpdate.NumberOfPlayers = boardGame.NumberOfPlayers;
                _context.SaveChanges();
            }
            return boardGameToUpdate;
        }


        public BoardGame CheckInGame(BoardGame boardGame)
        {
            BoardGame boardGameToUpdate = _context.BoardGames.Find(boardGame.BoardGameId);
            if (boardGameToUpdate != null)
            {
                boardGameToUpdate.CheckedOut = boardGame.CheckedOut;
                _context.SaveChanges();
            }
            return boardGameToUpdate;

        }

        public BoardGame CheckOutGame(BoardGame boardGame)
        {
            BoardGame boardGameToUpdate = _context.BoardGames.Find(boardGame.BoardGameId);
            if (boardGameToUpdate != null)
            {
                boardGameToUpdate.CheckedOut = boardGame.CheckedOut;
                _context.SaveChanges();
            }
            return boardGameToUpdate;

        }


        // D e l e t e

        public bool DeleteGame(int gameId)
        {
            BoardGame boardGameToDelete = _context.BoardGames.Find(gameId);
            if(boardGameToDelete == null)
            {
                return false;
            }
            _context.BoardGames.Remove(boardGameToDelete);
            _context.SaveChanges();
            return true;
        }


    }
}
