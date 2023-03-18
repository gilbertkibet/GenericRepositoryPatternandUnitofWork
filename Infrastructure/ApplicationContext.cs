﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options) { }

        public DbSet<Developer> tblDevelopers { get; set; }
        public DbSet<Project> tblProjects { get; set; }

    }
}
