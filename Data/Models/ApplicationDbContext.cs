﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System;

namespace Data.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Applicant> Applicant { get; set; }
        public DbSet<Employer> Employer { get; set; }
        public DbSet<Vacancy> Vacancy { get; set; }
        public DbSet<_archVacancies> _archVacancies { get; set; }
        public DbSet<VacancyApplications> VacancyApplications { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Cascade;
            }
        }
    }
}
