using homework.Entity;
using homework.Models;
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
    public partial class Authorize 
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
        private bool AutheficationMethod(string login, string password)
        {

            using (var  db = new EntityContext())
            {
                var maneger = db.Manager.FirstOrDefault(_maneger => _maneger.Login == login && _maneger.Password == password);
                if(maneger==null)

                    return false;

                int id = maneger.UserID;
                var manegerDb= db.User.FirstOrDefault(_managerDb =>_managerDb.id == id);
                Class.UserSingleton.FromDb(maneger, manegerDb);
                    return true;
            }

            
        }
        public void Login_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text != "" && (PasswordBox.Password != "" || Pastext.Text != "")) 
            {
                if (AutheficationMethod(LoginBox.Text, Pastext.Text.Length == 0 ? PasswordBox.Password : Pastext.Text))
                {


                    ManajerWindow user = new ManajerWindow();
                    user.Show();
                    this.Close();
                    return;
                }
                else 
                {
                    MessageBox.Show("Ошибка авторизации","Login error", MessageBoxButton.OKCancel,MessageBoxImage.Error);
                    return;
                }
            }
            MessageBox.Show("Заполните все поля", "Login error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
        }

               
    }




}
    


