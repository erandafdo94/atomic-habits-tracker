using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtomicHabits.Repository.Modal;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AtomicHabits.Repository
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options) { }

        public DbSet<UserHabits> UserHabits { get; set; }
        public DbSet<HabitTracking> HabitTracking { get; set; }

    }
}