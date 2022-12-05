using cloothbazaar.entities;
using clothbazaar.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clothbazar.Services
{
  public   class CategriousService
    {
        public void SaveCategory(Catregry category)
        {
            using (var context = new CbContext())
            {

                context.Categories.Add(category);

                context.SaveChanges();

            }

        }


    }
}
