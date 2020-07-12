using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cet322_FinalProject.Models
{
    public class Blog
    {
        [Key]
        public int Blog_Id { get; set; }


        [StringLength(512, MinimumLength = 2)]
        public string Forum { get; set; }


    }
}
