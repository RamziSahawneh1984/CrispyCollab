﻿using Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class IdentificationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public IdentificationDbContext(DbContextOptions<IdentificationDbContext> options) : base(options)
        {
            
        }

        public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }
        public DbSet<ApplicationUserTeam> ApplicationUserTeams { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);   
            base.OnModelCreating(modelBuilder);
        }
    }
}
