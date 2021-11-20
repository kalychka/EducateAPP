﻿using EducateAPP.Models.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EducateAPP.Models
{
    public class AppCtx : IdentityDbContext<User>
    {
        public AppCtx(DbContextOptions<AppCtx> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<FormOfStudy> FormsOfStudy { get; set; }

        public DbSet<Discipline> Disciplines { get; set; }

        public DbSet<TypeOfTotal> TypesOfTotals { get; set; }
    }
}
