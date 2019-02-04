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
        public string Message{ get; set; }

       // [BindProperty]
        //public bool IsContactAllowed{ get; set; }

       // [BindProperty]
       // public DateTime Number { get; set; }


[BindProperty]
        public string Season{ get; set; }


        public void OnGet()
        {

        }
        public void OnPost()

        {
            Message = string.Format("The Season {0} ", Season);

           // Message = string.Format("The time is {0} ", Number);


            // Message = string.Format("Are you allowed to make contact{0} ", IsContactAllowed);
        }
    }
}