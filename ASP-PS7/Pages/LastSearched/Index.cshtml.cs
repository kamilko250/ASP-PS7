using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_PS7.Data;
using PS3.Models;

namespace ASP_PS7.Pages.LastSearched
{
    public class IndexModel : PageModel
    {
        const int Count = 20;
        private readonly ApplicationDbContext _dbContext;

        public IndexModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<FizzBuzz> FizzBuzzes { get;set; }

        public async Task OnGetAsync()
        {
            FizzBuzzes = await _dbContext.FizzBuzzes.OrderByDescending(p => p.DateTime).Take(Count).ToListAsync();
        }
    }
}
