using homework.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Models
{
   public class TableContextModel : EntityContext
    { 
        public TableContextModel() 
        {

        }
        public DbSet<TableModel> Table { get; set; }
    }
}
