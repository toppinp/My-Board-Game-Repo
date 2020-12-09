using Microsoft.AspNetCore.Mvc;
using MyBoardGameRepo.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBoardGameRepo.Controllers
{
    public class PlayerController : Controller
    {
        // F i e l d s   &   P r o p e r t i e s 

        private readonly IPlayerRepository _repository;


        // C o n s t r u c t o r s

        public PlayerController(IPlayerRepository repository)
        {
            _repository = repository;
        }


        // M e t h o d s

        // C r e a t e

        [HttpGet]
        public IActionResult Add()
        {
            Player newPlayer = new Player();
            return View(newPlayer);
        }


        [HttpPost]
        public IActionResult Add(Player player)
        {
            _repository.AddPlayer(player);
            return RedirectToAction("Index");
        }


        // R e a d 
        public IActionResult Index()
        {
            IQueryable<Player> allPlayers = _repository.GetAllPlayers();
            return View(allPlayers);
        }


        public IActionResult Detail(int playerId)
        {
            Player player = _repository.GetPlayerById(playerId);
            if (player != null)
            {
                return View(player);
            }
            return RedirectToAction("Index");
        }


        public IActionResult Search(string name)
        {
            IQueryable<Player> players = _repository.GetPlayersByName(name);
            return View(players);
        }


        // U p d a t e

        [HttpGet]
        public IActionResult UpdatePlayer(int playerId)
        {

            Player player = _repository.GetPlayerById(playerId);
            if (player != null)
            {
                return View(player);
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult UpdatePlayer(Player player)
        {
            if (ModelState.IsValid)
            {
                _repository.UpdatePlayer(player);
                return RedirectToAction("Index");
            }
            else
            {
                return View(player);
            }
        }


        // D e l e t e

        [HttpGet]
        public IActionResult Delete(int playerId)
        {
            Player player = _repository.GetPlayerById(playerId);
            if (player != null)
            {
                return View(player);
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Delete(Player player)
        {
            bool playerDeleted = _repository.DeletePlayer(player.PlayerId);
            if (playerDeleted == true)
            {
                return RedirectToAction("Index");
            }
            return View(player);
        }


    }
}
