using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class SqlServerContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-VH5VO8P;Initial Catalog=bestcode;Integrated Security=True;");
        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Article> Articles { get; set; }

    }
}
