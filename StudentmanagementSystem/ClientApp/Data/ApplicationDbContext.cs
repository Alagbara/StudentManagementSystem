using System;
using Microsoft.EntityFrameworkCore;
using StudentmanagementSystem.Models;

namespace StudentmanagementSystem.ClientApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
