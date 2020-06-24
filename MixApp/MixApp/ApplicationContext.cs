using Microsoft.EntityFrameworkCore;
using MixApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MixApp
{
    public class ApplicationContext : DbContext
    {
        private string _databasePath;

        public DbSet<Field> Fields { get; set; }

        public ApplicationContext(string databasePath)
        {
            _databasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }
    }
}
