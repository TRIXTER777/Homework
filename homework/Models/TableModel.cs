using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Models
{
   public class TableModel
    {
        public int id { get; set; }
        
        public string SurName { get; set; }
      
        public string FirstName { get; set; }
      
        public string LastName { get; set; }

        public int id_Order { get; set; }

        public string Name { get; set; }

        public decimal? Price { get; set; }
    }
}
