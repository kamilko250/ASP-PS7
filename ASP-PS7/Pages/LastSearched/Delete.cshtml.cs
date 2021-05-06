using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PS3.Models;
using System.Threading.Tasks;

namespace ASP_PS7.Pages.LastSearched
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly ASP_PS7.Data.ApplicationDbContext _context;

        public DeleteModel(ASP_PS7.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FizzBuzz = await _context.FizzBuzzes.FindAsync(id);

            if (FizzBuzz.UserName == HttpContext.User.Identity.Name)
            {
                if (FizzBuzz != null)
                {
                    _context.FizzBuzzes.Remove(FizzBuzz);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToPage("./Index");
        }
    }
}
