#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapp.Models;

namespace webapp.Data
{
    public class RazorClubContext : DbContext
    {
        public RazorClubContext (DbContextOptions<RazorClubContext> options)
            : base(options)
        {
        }

        public DbSet<webapp.Models.Student> Student { get; set; }

        public async virtual Task AddStudentAsync(webapp.Models.Student student)
        {
            await Student.AddAsync(student);
            await SaveChangesAsync();
        }
    }
}
