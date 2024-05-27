using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project_Prn221_Shop.Model;
using System.Threading.Tasks;

namespace Project_Prn221_Shop.Pages.Admin.Categories
{
    public class AddOrEditModel : PageModel
    {
        private readonly project_Prn221Context _context;

        [BindProperty]
        public Category Categ { get; set; }

        public AddOrEditModel()
        {
            _context = new project_Prn221Context();
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Categ != null)
            {
                _context.Categories.Add(Categ);
                await _context.SaveChangesAsync();
            }

            return Page();
        }
    }
}
