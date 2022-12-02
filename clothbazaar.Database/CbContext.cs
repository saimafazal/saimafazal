using cloothbazaar.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clothbazaar.Database
{
  public class CbContext  : DbContext
    {
        public DbSet <product> products{ get; set; }
        public DbSet<catregry> catregries { get; set; }


    }
}
