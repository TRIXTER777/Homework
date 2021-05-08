using homework.Entity;
using homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using homework.Window;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace homework
{
    /// <summary>
    /// Логика взаимодействия для ManajerWindow.xaml
    /// </summary>
    public partial class ManajerWindow 
    {
        public ManajerWindow() 
        {
            InitializeComponent();

            var user = Class.UserSingleton.GetUser();
            LoginL.Text = user.GetLogin();
            FirstName.Text = user.GetFirstName();
            Name.Text = user.GetSurName();
            LastName.Text = user.GetLastName();

        }

        private void Spisok_Click(object sender, RoutedEventArgs e)
        {
            new SaleWindow().Show();
            Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            new Authorize().Show();
            Close();
        }

        private void NewZakaz_Click(object sender, RoutedEventArgs e)
        {
            new NewZakazWindow().ShowDialog();
            Close();
        }
    }
}

