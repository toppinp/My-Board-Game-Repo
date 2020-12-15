using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MyBoardGameRepo.Models
{
    public class EfPlayerRepository : IPlayerRepository
    {
        // F i e l d s  &  P r o p e r t i e s

        private AppDbContext _context;
        private ISession     _session;

        // C o n s t r u c t o r s

        public EfPlayerRepository(AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _session = httpContextAccessor.HttpContext.Session;
        }


        // M e t h o d s

        // C r e a t e

        public Player AddPlayer(Player player)
        {
            try
            {
                player.Password = encrypt(player.Password);
                _context.Players.Add(player);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                player.PlayerId = -1;
            }
            player.Password = "";
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


        public Player GetPlayerByName(string name)
        {
            return _context.Players
                .Where(p => p.Name.Contains(name))
                .FirstOrDefault();

        }


        public Player? GetPlayerBySession()
        {
            Player player = _context.Players
                .Where(p => p.PlayerId == _session.GetInt32("playerId"))
                .FirstOrDefault();
            return player;
        }

        public bool Login(Player player)
        {
            Player dbPlayer = GetPlayerByName(player.Name);

            if(dbPlayer == null)
            {
                return false;
            }

            player.Password = encrypt(player.Password);

            if(dbPlayer.Password == player.Password)
            {
                _session.SetInt32("playerId", dbPlayer.PlayerId);
                _session.SetString("name", dbPlayer.Name);
                if(dbPlayer.IsAdmin == true)
                {
                    _session.SetInt32("playerAdmin", 1);
                }
                else
                {
                    _session.SetInt32("playerAdmin", 0);
                }
                return true;
            }
            return false;
        }


        public bool IsPlayerLoggedIn()
        {
            int? playerId = _session.GetInt32("playerId");
            if(playerId == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public string GetLoggedInPlayerName()
        {
            string playerName = _session.GetString("name");
            if (playerName == null)
            {
                return "";
            }
            else
            {
                return playerName;
            }

        }

        public int? GetLoggedInPlayerId()
        {
            int? playerId = _session.GetInt32("playerId");
            return playerId;
        }

        public bool IsPlayerAdmin()
        {
            if (_session.GetInt32("playerAdmin") == 1)
            {
                return true;
            }
            return false;
        }


        public void Logout()
        {
            _session.Remove("playerId");
            _session.Remove("name");
            _session.Remove("playerAdmin");
        }



        // U p d a t e

        public Player UpdatePlayer(Player player)
        {
            Player playerToUpdate = _context.Players.Find(player.PlayerId);
            if(playerToUpdate != null)
            {
                playerToUpdate.Name = player.Name;
                playerToUpdate.Age = player.Age;
                playerToUpdate.Password = encrypt(player.Password);
                playerToUpdate.IsAdmin = player.IsAdmin;
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



        private string encrypt(string password)
        {
            if (password.Length > 3)
            {
                SHA256 myHashingVar = SHA256.Create();
                byte[] passwordByteArray = Encoding.ASCII.GetBytes(password);
                passwordByteArray[0] += 1;
                passwordByteArray[1] += 2;
                passwordByteArray[2] += 3;
                passwordByteArray[3] += 4;
                byte[] hashedPasswordByteArray = myHashingVar.ComputeHash(passwordByteArray);
                string hashedPassword = "";
                foreach (byte b in hashedPasswordByteArray)
                {
                    hashedPassword += b.ToString("x2");
                }
                return hashedPassword;
            }
            else
            {
                return "";
            }
        }
    }
}
