using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cet322_FinalProject.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public int Age { get; set; }



        public string GameName { get; set; }
        public Game Game;

        public string SkillName { get; set; }
        public Skill Skill;


    }
}
