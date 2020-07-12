using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cet322_FinalProject.Models
{
    public class Game
    {
        [Key]
        [StringLength(100,MinimumLength=2)]
        public string GameName { get; set; }

        public string Platform { get; set; }
        public int Rating { get; set; }
    }
}
