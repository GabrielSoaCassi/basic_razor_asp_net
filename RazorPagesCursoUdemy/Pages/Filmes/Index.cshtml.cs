using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCursoUdemy.Data;
using RazorPagesCursoUdemy.Model;

namespace RazorPagesCursoUdemy.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCursoUdemy.Data.RazorPagesCursoUdemyContext _context;

        public IndexModel(RazorPagesCursoUdemy.Data.RazorPagesCursoUdemyContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FilmeGender { get; set; }

        public SelectList Genders { get; set; }

        public async Task OnGetAsync()
        {
            var filmes = from m in _context.Filme select m;
            if(!string.IsNullOrWhiteSpace(SearchTerm))
                filmes = filmes.Where(f => f.Title.Contains(SearchTerm));
            if (_context.Filme != null)
            {
                
                Filme = await filmes.ToListAsync();
            }
        }
    }
}
