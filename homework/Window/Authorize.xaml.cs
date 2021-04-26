using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace homework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Authorize : Window
    {
        public Authorize()
        {
            InitializeComponent();
        }
        private void Visible_Checked(object sender, RoutedEventArgs e)
        {

            Pastext.Text = PasswordBox.Password;
            Pastext.Visibility = Visibility.Visible;
            PasswordBox.Visibility = Visibility.Collapsed;
            PasswordBox.IsEnabled = false;
            Pastext.IsEnabled = true;
            Pastext.Focus();
            return;
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordBox.Password = Pastext.Text;
            Pastext.Visibility = Visibility.Collapsed;
            PasswordBox.Visibility = Visibility.Visible;
            PasswordBox.IsEnabled = true;
            Pastext.IsEnabled = false;
            PasswordBox.Focus();
            return;
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text == "login1" && PasswordBox.Password == "tuptup" )
            {
                new ManajerWindow().Show();
                Close();
            }
            else if (LoginBox.Text == "" || PasswordBox.Password == "" )
            {
                MessageBox.Show("Поле не заполнено","Ошибка" );
            }
            else if (LoginBox.Text != "login1" || PasswordBox.Password != "tuptup")
            {
                MessageBox.Show("Неправильный логин или пароль","Ошибка");
            }
           
          

        }
    }
}
