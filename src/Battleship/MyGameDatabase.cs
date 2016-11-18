using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Battleship
{
    public class MyGameDatabase : DbContext
    {
        // Database to retrieve GameName, GameId, and GameState for the DB
        public DbSet<Game> Games { get; set; }

        public MyGameDatabase()
        {
            Database.SetInitializer<MyGameDatabase>(new DropCreateDatabaseAlways<MyGameDatabase>());
        }
    }

    public class Game
    {
        public string GameName { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid GameId { get; set; }
    }
}