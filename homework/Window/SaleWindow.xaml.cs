using homework.Entity;
using homework.Models;
using System.ComponentModel;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace homework
{
    /// <summary>
    /// Логика взаимодействия для SaleWindow.xaml
    /// </summary>
    public partial class SaleWindow : Window
    {
      


        public SaleWindow()
        {
            InitializeComponent();

            //using (var db = new EntityContext())
            //{
            //    db.Client.Load();
            //    db.User.Load();
            //    db.Order.Load();
            //    db.Products.Load();
            //    var sl = from c in db.Client
            //             join u in db.User on new { x1 = c.UserId } equals new { x1 = u.ID }
                      
            //             select new { c.ID, u.FirstName };
            //    TableGrid.ItemsSource = sl.ToList();
            //}

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
           
            new ManajerWindow().Show();
            Close();
        }


    }
}
