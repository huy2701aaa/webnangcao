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

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
