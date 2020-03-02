using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infrastructure.Data.Context
{
    class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Course> Courses { get; set; }
    }
}
