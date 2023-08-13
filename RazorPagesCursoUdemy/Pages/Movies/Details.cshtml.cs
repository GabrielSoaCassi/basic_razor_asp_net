using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCursoUdemy.Data;
using RazorPagesCursoUdemy.Model;

namespace RazorPagesCursoUdemy.Pages.Filmes
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesCursoUdemy.Data.RazorPagesCursoUdemyContext _context;

        public DetailsModel(RazorPagesCursoUdemy.Data.RazorPagesCursoUdemyContext context)
        {
            _context = context;
        }

      public Movie Filme { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var filme = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if (filme == null)
            {
                return NotFound();
            }
            else 
            {
                Filme = filme;
            }
            return Page();
        }
    }
}
