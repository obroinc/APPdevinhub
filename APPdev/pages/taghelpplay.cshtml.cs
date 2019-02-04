using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace APPdev.pages
{
    public class taghelpplayModel : PageModel

    {
        public string Message { get; set; } = "";

       [BindProperty]
        public string Season{ get; set; }


        public void OnGet()
        {

        }
        public void OnPost()

        {
            Message = string.Format("The Season {0} ", Season);

                      
        }
    }
}