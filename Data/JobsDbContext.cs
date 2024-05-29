using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiJobs.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiJobs.Data
{
    public class JobsDbContext : DbContext
    {
        public JobsDbContext(DbContextOptions<JobsDbContext> options) : base(options) {}

        public DbSet<Job> Jobs {get; set;}
    }
}