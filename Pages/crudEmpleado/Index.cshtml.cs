using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tarea9Docker.Data;

namespace Tarea9Docker.Pages.crudEmpleado
{
    public class IndexModel : PageModel
    {
        private readonly Tarea9Docker.Data.ApplicationDbContext _context;

        public IndexModel(Tarea9Docker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Empleado> Empleado { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Empleados != null)
            {
                Empleado = await _context.Empleados.ToListAsync();
            }
        }
    }
}
