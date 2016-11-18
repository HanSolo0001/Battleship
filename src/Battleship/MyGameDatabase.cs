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
        public string Name { get; set; }
        public int Size { get; set; }
        // List every game square (10x10 grid) from left to right starting at top left corner
        public bool GameSquare1 { get; set; }
        public bool GameSquare2 { get; set; }
        public bool GameSquare3 { get; set; }
        public bool GameSquare4 { get; set; }
        public bool GameSquare5 { get; set; }
        public bool GameSquare6 { get; set; }
        public bool GameSquare7 { get; set; }
        public bool GameSquare8 { get; set; }
        public bool GameSquare9 { get; set; }
        public bool GameSquare10 { get; set; }
        public bool GameSquare11 { get; set; }
        public bool GameSquare12 { get; set; }
        public bool GameSquare13 { get; set; }
        public bool GameSquare14 { get; set; }
        public bool GameSquare15 { get; set; }
        public bool GameSquare16 { get; set; }
        public bool GameSquare17 { get; set; }
        public bool GameSquare18 { get; set; }
        public bool GameSquare19 { get; set; }
        public bool GameSquare20 { get; set; }
        public bool GameSquare21 { get; set; }
        public bool GameSquare22 { get; set; }
        public bool GameSquare23 { get; set; }
        public bool GameSquare24 { get; set; }
        public bool GameSquare25 { get; set; }
        public bool GameSquare26 { get; set; }
        public bool GameSquare27 { get; set; }
        public bool GameSquare28 { get; set; }
        public bool GameSquare29 { get; set; }
        public bool GameSquare30 { get; set; }
        public bool GameSquare31 { get; set; }
        public bool GameSquare32 { get; set; }
        public bool GameSquare33 { get; set; }
        public bool GameSquare34 { get; set; }
        public bool GameSquare35 { get; set; }
        public bool GameSquare36 { get; set; }
        public bool GameSquare37 { get; set; }
        public bool GameSquare38 { get; set; }
        public bool GameSquare39 { get; set; }
        public bool GameSquare40 { get; set; }
        public bool GameSquare41 { get; set; }
        public bool GameSquare42 { get; set; }
        public bool GameSquare43 { get; set; }
        public bool GameSquare44 { get; set; }
        public bool GameSquare45 { get; set; }
        public bool GameSquare46 { get; set; }
        public bool GameSquare47 { get; set; }
        public bool GameSquare48 { get; set; }
        public bool GameSquare49 { get; set; }
        public bool GameSquare50 { get; set; }
        public bool GameSquare51 { get; set; }
        public bool GameSquare52 { get; set; }
        public bool GameSquare53 { get; set; }
        public bool GameSquare54 { get; set; }
        public bool GameSquare55 { get; set; }
        public bool GameSquare56 { get; set; }
        public bool GameSquare57 { get; set; }
        public bool GameSquare58 { get; set; }
        public bool GameSquare59 { get; set; }
        public bool GameSquare60 { get; set; }
        public bool GameSquare61 { get; set; }
        public bool GameSquare62 { get; set; }
        public bool GameSquare63 { get; set; }
        public bool GameSquare64 { get; set; }
        public bool GameSquare65 { get; set; }
        public bool GameSquare66 { get; set; }
        public bool GameSquare67 { get; set; }
        public bool GameSquare68 { get; set; }
        public bool GameSquare69 { get; set; }
        public bool GameSquare70 { get; set; }
        public bool GameSquare71 { get; set; }
        public bool GameSquare72 { get; set; }
        public bool GameSquare73 { get; set; }
        public bool GameSquare74 { get; set; }
        public bool GameSquare75 { get; set; }
        public bool GameSquare76 { get; set; }
        public bool GameSquare77 { get; set; }
        public bool GameSquare78 { get; set; }
        public bool GameSquare79 { get; set; }
        public bool GameSquare80 { get; set; }
        public bool GameSquare81 { get; set; }
        public bool GameSquare82 { get; set; }
        public bool GameSquare83 { get; set; }
        public bool GameSquare84 { get; set; }
        public bool GameSquare85 { get; set; }
        public bool GameSquare86 { get; set; }
        public bool GameSquare87 { get; set; }
        public bool GameSquare88 { get; set; }
        public bool GameSquare89 { get; set; }
        public bool GameSquare90 { get; set; }
        public bool GameSquare91 { get; set; }
        public bool GameSquare92 { get; set; }
        public bool GameSquare93 { get; set; }
        public bool GameSquare94 { get; set; }
        public bool GameSquare95 { get; set; }
        public bool GameSquare96 { get; set; }
        public bool GameSquare97 { get; set; }
        public bool GameSquare98 { get; set; }
        public bool GameSquare99 { get; set; }
        public bool GameSquare100 { get; set; }
    }
}