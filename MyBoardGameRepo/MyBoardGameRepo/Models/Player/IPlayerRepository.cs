﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBoardGameRepo.Models.Players
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


        // U p d a t e

        public Player UpdatePlayer(Player player);


        // D e l e t e

        public bool DeletePlayer(int playerId);


    }
}
