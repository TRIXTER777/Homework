using homework.Entity;
using homework.Models;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace homework
{
    /// <summary>
    /// Логика взаимодействия для SaleWindow.xaml
    /// </summary>
    public partial class SaleWindow 
    {
      


        public SaleWindow()
        {
            InitializeComponent();
            using (var db = new EntityContext())
            {
                db.User.Load();
                db.Products.Load();
                db.Order.Load();
                TableGrid.ItemsSource = (from  u in db.User.Local 
                                         join p in db.Products.Local on u.id equals p.ID
                                         select new
                                         {
                                             u.FirstName,
                                             u.SurName,
                                             u.LastName,                                
                                             p.Name,
                                             p.Price
                                         });
            }


        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
           
            new ManajerWindow().Show();
            Close();
        }

      
    }
}
