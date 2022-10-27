using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web_nang_cao.Models;

namespace web_nang_cao.Data
{
    public class web_nang_caoContext : DbContext
    {
        public web_nang_caoContext (DbContextOptions<web_nang_caoContext> options)
            : base(options)
        {
        }

        public DbSet<web_nang_cao.Models.Movie> Movie { get; set; } = default!;
    }
}
