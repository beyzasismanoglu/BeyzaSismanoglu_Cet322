using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cet322_FinalProject.ViewModel
{
    public class SearchViewModel
    {
        public string SearchText { get; set; }

        public string UserId { get; set; }


        public List<Models.User> Result { get; set; }
    }
}
