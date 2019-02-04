using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace APPdev.pages
{
    public class WB1bModel : PageModel
    {
        public string Message { get; set; }

        [BindProperty]
        public int? Number1 { get; set; }//This makes int nullable i.e zero will not be diplayed by default

        [BindProperty]
        public int? Number2 { get; set; }

        public void OnGet()
        {

        }
        public void OnPost()
        {

            Message = string.Format("The Sum of {0} and {1} is {2}", Number1, Number2, Number1 + Number2);
        }
    }
}