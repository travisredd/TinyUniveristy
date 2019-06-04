using TinyUniversity.Models.SchoolViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinyUniversity.Data;
using TinyUniversity.Models;

namespace TinyUniversity.Pages
{
    public class AboutModel : PageModel
    {
        private readonly SchoolContext _context;

        public AboutModel(SchoolContext context)
        {
            _context = context;
        }

        public IList<EnrollmentStatistics> Student { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<EnrollmentStatistics> data =
                from student in _context.Student
                group student by student.EnrollmentDate into dateGroup
                select new EnrollmentStatistics()
                {
                    EnrollmentDate = dateGroup.Key,
                    StudentCount = dateGroup.Count()
                };

            Student = await data.AsNoTracking().ToListAsync();
        }
    }
}