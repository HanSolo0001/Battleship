using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Battleship.Models
{
    public class GameStartViewModel : GameViewModelBase
    {
        [Required]
        [StringLength(20)]
        public string GameName { get; set; }
    }
}