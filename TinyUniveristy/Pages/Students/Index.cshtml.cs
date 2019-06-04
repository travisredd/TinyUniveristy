using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TinyUniversity.Models;

namespace TinyUniveristy.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly TinyUniversity.Models.SchoolContext _context;

        public IndexModel(TinyUniversity.Models.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
