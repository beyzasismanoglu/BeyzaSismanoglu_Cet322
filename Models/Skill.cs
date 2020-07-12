using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cet322_FinalProject.Models
{
    public class Skill
    {
        public int Skill_id { get; set; }

        [Key]
        public string SkillName { get; set; }
    }
}
