using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace APPdev.pages
{
    public class greetingModel : PageModel
    {
        public string message { get; set; } = "Hello there this is  amessage from greetin.cshtml.cs";
        public void OnGet()
        {
            if (DateTime.Now.Hour >= 12)
            {
                message = "Goodafternoon";
            }
            else{
                message = "Good Morning";
            }

        }
    }
}