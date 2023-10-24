using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tarea9Docker.Data;

namespace Tarea9Docker.Pages.crudPuesto
{
    public class IndexModel : PageModel
    {
        private readonly Tarea9Docker.Data.ApplicationDbContext _context;

        public IndexModel(Tarea9Docker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Puesto> Puesto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Puestos != null)
            {
                Puesto = await _context.Puestos.ToListAsync();
            }
        }
    }
}
