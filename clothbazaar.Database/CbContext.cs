using cloothbazaar.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clothbazaar.Database
{
  public class CbContext  : DbContext ,IDisposable
    {

        public CbContext() : base ("clothbzrconnections")
        {

        }
        public DbSet <Product> Products{ get; set; }
        public DbSet<Catregry> Categories { get; set; }


    }
}
