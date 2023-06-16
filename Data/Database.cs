using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WpfApplication.Models;

namespace WpfApplication.Data
{

    public class Database : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=WpfS1187545;Trusted_Connection=True;");

        }

    }

}


//test
