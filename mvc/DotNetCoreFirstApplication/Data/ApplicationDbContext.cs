using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; } = default!;
         public DbSet<CongTy> CongTy { get; set; } = default!;
         public DbSet<DaiLy> DaiLy { get; set; } = default!;
    }
