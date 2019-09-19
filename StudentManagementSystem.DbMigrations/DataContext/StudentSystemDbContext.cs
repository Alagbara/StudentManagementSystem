using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using StudentManagementSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
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


    public class StudentSystemContextFactory : IDesignTimeDbContextFactory<StudentSystemDbContext>
    {
        public StudentSystemDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                                               .SetBasePath(Directory.GetCurrentDirectory())
                                               //SetBasePath(System.AppContext.BaseDirectory)
                                               .AddJsonFile("appconfig.json")
                                               .Build();

            var builder = new DbContextOptionsBuilder<StudentSystemDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new StudentSystemDbContext(builder.Options);
        }
    }


}
