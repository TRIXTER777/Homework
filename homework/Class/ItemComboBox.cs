using homework.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Class
{
    class ItemComboBox
    {
        public ItemComboBox()
        {
            using (var context = new EntityContext())
            {

                context.Products.Load();
                product = new ObservableCollection<Products>(context.Products.Local.ToList());               
            }

        }
        public ObservableCollection<Products> product { get; set; }
        public Products SelectedProduct { get; set; }
       
    }

}
