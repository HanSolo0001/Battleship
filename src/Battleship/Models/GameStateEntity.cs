using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Battleship.Models
{
    public class GameStateEntity
    {
        // Entity class to retrieve GameName, GameId, and GameState for the DB
        public class GameEntity
        {
            public GameStartViewModel GameName { get; set; }
            public GameViewModelBase GameId { get; set; }
        }

        public class GameEntityData : DbContext
        {
            public DbSet<GameEntity> Games { get; set; }

            // reference game current state 
        }

    }
}