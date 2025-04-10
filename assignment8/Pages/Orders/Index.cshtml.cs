using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using assignment8.Data;
using assignment8.Models;

namespace assignment8.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly assignment8.Data.assignment8Context _context;

        public IndexModel(assignment8.Data.assignment8Context context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
        }
    }
}
