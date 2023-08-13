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

        public IList<Movie> Movie { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FilmeGender { get; set; }

        public SelectList Genders { get; set; }

        public async Task OnGetAsync()
        {
            Genders = new SelectList(await _context.Movie.Select(o => o.Gender).Distinct().ToListAsync());
            var filmes = from m in _context.Movie select m;
            if (!string.IsNullOrWhiteSpace(SearchTerm))
                filmes = filmes.Where(f => f.Title.Contains(SearchTerm));


            if (!string.IsNullOrWhiteSpace(FilmeGender))
                filmes = filmes.Where(f => f.Gender.Equals(FilmeGender));
            if (_context.Movie != null)
            {

                Movie = await filmes.ToListAsync();
            }
        }
    }
}
