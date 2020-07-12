using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cet322_FinalProject.Models
{
    public class Favorite
    {
        public int Id { get; set; }


        public string UserName { get; set; }
        public User User;


        public string GameName { get; set; }
        public Game Game;
    }
}
