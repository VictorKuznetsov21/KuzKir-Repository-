using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseCarsNStocks
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Stock> Stocks { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Cars.db");
        }

    }
}
