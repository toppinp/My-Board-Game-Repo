using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBoardGameRepo.Models
{
    public class EfBoardGameRepository : IBoardGameRepository
    {

        // F i e l d s   &   P r o p e r t i e s

        private readonly AppDbContext _context;

        private ISession _session;

        // C o n s t r u c t o r s

        public EfBoardGameRepository(AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _session = httpContextAccessor.HttpContext.Session;
        }


        // M e t h o d s

        // C r e a t e

        public BoardGame AddGame(BoardGame boardGame)
        {
            _context.BoardGames.Add(boardGame);
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


        public IQueryable<BoardGame> GetBoardGameByPlayerId(int playerId)
        {
            return _context.BoardGames
                .Where(b => b.PlayerId == playerId);
        }


        public int? GetBoardGameIdByPlayerId(int playerId)
        {
            BoardGame boardGame = GetBoardGameByPlayerId(playerId)
                                                .FirstOrDefault();
            if(boardGame == null)
            {
                return null;
            }

            return boardGame.BoardGameId;
        }


        public string GetBoardGameNameByPlayerId(int playerId)
        {
            BoardGame boardGame = GetBoardGameByPlayerId(playerId)
                                                .FirstOrDefault();
            return boardGame.Name;
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
                boardGameToUpdate.Image = boardGame.Image;
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
                boardGameToUpdate.PlayerId = null;
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
                boardGameToUpdate.PlayerId = _session.GetInt32("playerId");
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
