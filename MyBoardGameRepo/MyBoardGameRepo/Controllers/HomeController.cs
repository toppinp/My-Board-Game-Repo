using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyBoardGameRepo.Models;
using MyBoardGameRepo.Models.BoardGames;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MyBoardGameRepo.Infrastructure;
using MyBoardGameRepo.Models.Players;

namespace MyBoardGameRepo.Controllers
{
    public class HomeController : Controller
    {
        // F i e l d s   &   P r o p e r t i e s 

        private readonly IBoardGameRepository _repository;

        public Player    Player    { get; set; }

        public string    ReturnUrl { get; set; }

        // C o n s t r u c t o r s

        public HomeController(IBoardGameRepository repository)
        {
            _repository = repository;
        }


        // M e t h o d s

        public void OnGet(string returnUrl = "/")
        {
            ReturnUrl = returnUrl;

            Player = HttpContext.Session.GetJson<Player>("player");
            if(Player == null)
            {
                Player = new Player();
            }
        }

        public void OnPost(int boardGameId, string returnUrl = "/")
        {
            ReturnUrl = returnUrl;
            Player = HttpContext.Session.GetJson<Player>("player");
            if(Player == null)
            {
                Player = new Player();
            }

            BoardGame boardGame = _repository.GetAllBoardGames()
                .FirstOrDefault(b => b.BoardGameId == boardGameId);
            if(boardGame != null)
            {
                
            }

            HttpContext.Session.SetJson("player", Player);
        }

        // C r e a t e

        [HttpGet]
        public IActionResult Add()
        {
            BoardGame newBoardGame = new BoardGame();
            return View(newBoardGame);
        }


        [HttpPost]
        public IActionResult Add(BoardGame boardGame)
        {
            _repository.AddGame(boardGame);
            return RedirectToAction("Index");
        }


        // R e a d
        public IActionResult Index()
        {
            IQueryable<BoardGame> allBoardGames = _repository.GetAllBoardGames();
            return View(allBoardGames);
        }


        public IActionResult Detail(int gameId)
        {
            BoardGame boardGame = _repository.GetGameById(gameId);
            if (boardGame != null)
            {
                return View(boardGame);
            }
            return RedirectToAction("Index");
        }


        public IActionResult Search(string genre)
        {
            IQueryable<BoardGame> boardGames = _repository.GetGamesByGenre(genre);
            return View(boardGames);
        }


        // U p d a t e

        [HttpGet]
        public IActionResult UpdateGame(int gameId)
        {

            BoardGame boardGame = _repository.GetGameById(gameId);
            if (boardGame != null)
            {
                return View(boardGame);
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult UpdateGame(BoardGame boardGame)
        {
            if (ModelState.IsValid)
            {
                _repository.UpdateGame(boardGame);
                return RedirectToAction("Index");
            }
            else
            {
                return View(boardGame);
            }
        }

        [HttpGet]
        public IActionResult CheckIn(int gameId)
        {

            BoardGame boardGame = _repository.GetGameById(gameId);
            if (boardGame != null)
            {
                return View(boardGame);
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult CheckIn(BoardGame boardGame)
        {
            if (ModelState.IsValid)
            {
                _repository.CheckInGame(boardGame);
                return RedirectToAction("Index");
            }
            else
            {
                return View(boardGame);
            }
        }

        [HttpGet]
        public IActionResult CheckOut(int gameId)
        {

            BoardGame boardGame = _repository.GetGameById(gameId);
            if (boardGame != null)
            {
                return View(boardGame);
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult CheckOut(BoardGame boardGame)
        {
            if (ModelState.IsValid)
            {
                _repository.CheckOutGame(boardGame);
                return RedirectToAction("Index");
            }
            else
            {
                return View(boardGame);
            }
        }

        // D e l e t e

        [HttpGet]
        public IActionResult Delete(int gameId)
        {
            BoardGame boardGame = _repository.GetGameById(gameId);
            if(boardGame != null)
            {
                return View(boardGame);
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Delete(BoardGame boardGame)
        {
            bool gameDeleted = _repository.DeleteGame(boardGame.BoardGameId);
            if (gameDeleted == true)
            {
                return RedirectToAction("Index");
            }
            return View(boardGame);
        }
    }
}
