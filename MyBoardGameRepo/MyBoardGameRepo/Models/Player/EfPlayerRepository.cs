using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBoardGameRepo.Models.Players
{
    public class EfPlayerRepository : IPlayerRepository
    {
        // F i e l d s  &  P r o p e r t i e s

        private AppDbContext _context;

        // C o n s t r u c t o r s

        public EfPlayerRepository(AppDbContext context)
        {
            _context = context;
        }


        // M e t h o d s

        // C r e a t e

        public Player AddPlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
            return player;
        }


        // R e a d 

        public IQueryable<Player> GetAllPlayers()
        {
            return _context.Players;
        }


        public Player GetPlayerById(int playerId)
        {
            return _context.Players.Find(playerId);
        }


        public IQueryable<Player> GetPlayersByName(string name)
        {
            return _context.Players
                .Where(p => p.Name.Contains(name));
        }


        // U p d a t e

        public Player UpdatePlayer(Player player)
        {
            Player playerToUpdate = _context.Players.Find(player.PlayerId);
            if(playerToUpdate != null)
            {
                playerToUpdate.Name = player.Name;
                playerToUpdate.Age = player.Age;
                _context.SaveChanges();
            }
            return playerToUpdate;
        }


        // D e l e t e

        public bool DeletePlayer(int playerId)
        {
            Player playerToDelete = _context.Players.Find(playerId);
            if(playerToDelete == null)
            {
                return false;
            }
            _context.Players.Remove(playerToDelete);
            _context.SaveChanges();
            return true;
        }



    }
}
