using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBoardGameRepo.Models
{
    public interface IPlayerRepository
    {
        // M e t h o d s

        // C r e a t e

        public Player AddPlayer(Player player);


        // R e a d 

        public IQueryable<Player> GetAllPlayers();

        public Player GetPlayerById(int playerId);

        public IQueryable<Player> GetPlayersByName(string name);

        public Player GetPlayerByName(string name);

        public Player GetPlayerBySession();

        public bool Login(Player player);

        public bool IsPlayerLoggedIn();

        public string GetLoggedInPlayerName();

        public int? GetLoggedInPlayerId();

        public bool IsPlayerAdmin();

        public void Logout();


        // U p d a t e

        public Player UpdatePlayer(Player player);


        // D e l e t e

        public bool DeletePlayer(int playerId);


    }
}
