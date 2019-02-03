using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace APPdev.pages
{
    public class ws1Model : PageModel

    {
        public string message { get; set; }

        public string[] MyTestArray { get; set; } = { "Ireland", "Scotland", "Wales", "England" };


        public void OnGet()
        {

         message=(foreach (string country in MyTestArray) ;
    {
        < li > country </ li >
    })

        }
        public void OnPost(string name)
        {
            message = string.Format("Hello there {0}", name);
        }
    }
}