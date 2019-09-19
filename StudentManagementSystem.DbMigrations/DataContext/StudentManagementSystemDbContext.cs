using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem.DbMigrations.DataContext
{
    public class StudentManagementSystemDbContext : DbContext
    {
        public StudentManagementSystemDbContext(DbContextOptions<StudentManagementSystemDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
