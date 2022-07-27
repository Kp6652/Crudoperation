#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Abby_.Data;
using Abby_.Model;

namespace Abby_.Pages.Categories.CategoryTemp
{
    public class IndexModel : PageModel
    {
        private readonly Abby_.Data.ApplicationDbContext _context;

        public IndexModel(Abby_.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
