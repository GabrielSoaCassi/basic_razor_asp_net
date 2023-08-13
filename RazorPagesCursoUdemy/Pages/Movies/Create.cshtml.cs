using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesCursoUdemy.Data;
using RazorPagesCursoUdemy.Model;

namespace RazorPagesCursoUdemy.Pages.Filmes
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesCursoUdemy.Data.RazorPagesCursoUdemyContext _context;

        public CreateModel(RazorPagesCursoUdemy.Data.RazorPagesCursoUdemyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Filme { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Movie == null || Filme == null)
            {
                return Page();
            }

            _context.Movie.Add(Filme);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
