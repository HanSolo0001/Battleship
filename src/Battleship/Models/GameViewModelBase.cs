using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Battleship.Models
{
    public class GameViewModelBase
    {
        [Required]
        public Guid? GameId { get; set; }
    }
}