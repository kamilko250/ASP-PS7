using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using PS3.Models;

namespace PS3.Pages
{
    public class ZapisaneWSesji : PageModel
    {
        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }
        public IActionResult OnGet()
        {
            var fizzBuzz = HttpContext.Session.GetString("Last");

            if (fizzBuzz != null)
                FizzBuzz = JsonConvert.DeserializeObject<FizzBuzz>(fizzBuzz);

            return Page();
        }

    }
}
