using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Karan.Data;
using Karan.Models;

namespace Karan.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Karan.Data.KaranContext _context;

        public IndexModel(Karan.Data.KaranContext context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; }

        public async Task OnGetAsync()
        {
            Author = await _context.Author
                .Include(a => a.Customer).ToListAsync();
        }
    }
}
