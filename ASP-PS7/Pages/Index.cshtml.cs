using ASP_PS7.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PS3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_PS7.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ApplicationDbContext _dbContext;
        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                FizzBuzz.FizzBuzzing(HttpContext.User.Identity.Name);
                HttpContext.Session.SetString("Last", JsonConvert.SerializeObject(FizzBuzz));
                await _dbContext.AddAsync(FizzBuzz);
                await _dbContext.SaveChangesAsync();
            }
            return Page();
        }
    }
}
