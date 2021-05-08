using homework.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace homework.Window
{
    /// <summary>
    /// Логика взаимодействия для NewZakazWindow.xaml
    /// </summary>
    public partial class NewZakazWindow 
    {
        public NewZakazWindow() 
        {
            InitializeComponent();
          
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if(Product.ItemsSource!=null && FirstName.Text!="" && SurName.Text !="" && LastName.Text!="")
            {
               NewZakaz();
                DialogResult = true;
                Close();

            }
            else
            {
                MessageBox.Show("Заполните все поля !!!!!!!!!!!!!!!", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
            
      
            
        }
        private void NewZakaz()
        {
            
            using (var db = new EntityContext())
            {
                int User_status = 0;
                foreach (var user in db.User)
                {
                    if (user.FirstName == FirstName.Text && user.LastName == LastName.Text && user.SurName == SurName.Text) User_status = 1;
                }
                if (User_status == 0)
                {
                    db.User.Add(new User() { FirstName = FirstName.Text, LastName = LastName.Text, SurName = SurName.Text });
                    MessageBox.Show("New client");
                }
                int sale_ID = 0;
                foreach (var sale in db.Products)
                {
                    if (sale.ID > sale_ID) sale_ID = sale.ID;
                }
                MessageBox.Show(sale_ID.ToString(), "Sale_ID");
               
                db.SaveChanges();

            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            new ManajerWindow().Show();
           Close();
        }

        private void Product_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D0 || e.Key == Key.Back || e.Key == Key.D1 || e.Key == Key.D2 || e.Key == Key.D3 || e.Key == Key.D4 || e.Key == Key.D5 || e.Key == Key.D6 || e.Key == Key.D7 || e.Key == Key.D8 || e.Key == Key.D9)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
