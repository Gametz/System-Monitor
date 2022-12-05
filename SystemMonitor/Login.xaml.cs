using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
using System.Threading;

namespace SystemMonitor
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private async void loginb_Click(object sender, RoutedEventArgs e)
        {
            if (user.Text == "admin" && pass.Password == "admin" || skipc.IsChecked == true)
            {
                Login.Hide();
                Window inf = new MainWindow();
                inf.Show();
            }
            else
            {
                loginb.Content = "Incorrect!";
                await Task.Delay(1000);
                loginb.Content = "Login";
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
