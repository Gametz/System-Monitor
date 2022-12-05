using Microsoft.SqlServer.Server;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace SystemMonitor
{
    /// <summary>
    /// Логика взаимодействия для plist.xaml
    /// </summary>
    public partial class plist : Window
    {
        public plist()
        {
            InitializeComponent();
            AddItemsactive();
        }
        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window form1 = new plist();
            form1.Show();
        }

        private void prog_Click(object sender, EventArgs e)
        {

        }

        public void AddItemsactive()
        {
            active.Items.Clear();
            int ii = 0;
            Process[] processlist = Process.GetProcesses();
            var tt = processlist.Length;
            prog.Content = "Кол-во: " + tt.ToString();
            string[] p = new string[tt];
            foreach (Process i in processlist)
            {
                p[ii] = (i.ProcessName);
                ii++;
            }
            Array.Sort(p);
            active.Items.Add(ListViewItem = p);
        }

        public void AddItemsinstalled()
        {
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (var uninstall = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"))
            {
                List<string> p = new List<string>();
                foreach (string name in uninstall.GetSubKeyNames())
                {
                    if (name[0] != '{')
                    {
                        p.Add(name);
                    }
                }
                prog.Content = "Кол-во: " + p.Count;
                //Array.Sort(p.ToArray());
                installed.Items.Add(p);
            }
        }

        private void installedb_Click(object sender, RoutedEventArgs e)
        {
            prog.Content = "Кол-во: 0";
            active.Items.Clear();
            AddItemsinstalled();
            active.Visibility= Visibility.Hidden;
            installed.Visibility = Visibility.Visible;
        }

        private void activeb_Click(object sender, RoutedEventArgs e)
        {
            prog.Content = "Кол-во: 0";
            installed.Items.Clear();
            AddItemsactive();
            installed.Visibility = Visibility.Hidden;
            active.Visibility = Visibility.Visible;
        }

        private void reload_Click(object sender, RoutedEventArgs e)
        {
            if (active.Visibility == Visibility.Visible) { AddItemsactive(); }
            else { AddItemsinstalled(); }

        }
    }
}
