using System.ComponentModel;
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
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            new ManajerWindow().Show();
            Close();
        }
    }
}
