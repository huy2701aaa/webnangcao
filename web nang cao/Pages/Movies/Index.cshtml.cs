using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using web_nang_cao.Data;
using web_nang_cao.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using web_nang_cao.Data;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace web_nang_cao.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly web_nang_cao.Data.web_nang_caoContext _context;

        public IndexModel(web_nang_cao.Data.web_nang_caoContext context)
        {
            _context = context;
        }
        
        public IList<Movie> Movie { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
