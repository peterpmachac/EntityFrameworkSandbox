#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoPets.UI.Data;
using ContosoPets.UI.Models;

namespace ContosoPets.UI.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ContosoPets.UI.Data.ContosoPetsContext _context;

        public IndexModel(ContosoPets.UI.Data.ContosoPetsContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
