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
    public class DetailsModel : PageModel
    {
        private readonly ASP_PS7.Data.ApplicationDbContext _context;

        public DetailsModel(ASP_PS7.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public FizzBuzz FizzBuzz { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FizzBuzz = await _context.FizzBuzzes.FirstOrDefaultAsync(m => m.ID == id);

            if (FizzBuzz == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
