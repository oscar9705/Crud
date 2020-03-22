using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Prj_GestionPDC_OASG.Data;
using Prj_GestionPDC_OASG.Entities;

namespace Prj_GestionPDC_OASG.Pages.DepartamentoPage
{
    public class IndexModel : PageModel
    {
        private readonly Prj_GestionPDC_OASG.Data.Prj_GestionPDC_OASGContext _context;

        public IndexModel(Prj_GestionPDC_OASG.Data.Prj_GestionPDC_OASGContext context)
        {
            _context = context;
        }

        public IList<Departamento> Departamento { get;set; }

        public async Task OnGetAsync()
        {
            Departamento = await _context.Departamento
                .Include(d => d.Pais).ToListAsync();
        }
    }
}
