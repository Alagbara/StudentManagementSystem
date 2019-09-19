using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem.DbMigrations.DataContext
{
    public class StudentSystemDbContext : DbContext
    {
        public StudentSystemDbContext(DbContextOptions<StudentSystemDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
