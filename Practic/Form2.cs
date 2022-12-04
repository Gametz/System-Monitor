using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace Practic
{
    public partial class Form2 : Form
    {

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form1 = new Form1();
            form1.Show();
        }

        private void prog_Click(object sender, EventArgs e)
        {

        }

        public void AddItemsactive()
        {
            int ii = 0;
            Process[] processlist = Process.GetProcesses();
            var tt = processlist.Length;
            prog.Text = "Кол-во: " + tt.ToString();
            string[] p = new string[tt];
            foreach (Process i in processlist)
            {
                p[ii] = (i.ProcessName); 
                ii++;
            }
            Array.Sort(p);
            active.Items.AddRange(p);
        }

        public void AddItemsinstalled()
        {
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (var uninstall = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"))
            {
                int i = 0;
                List<string> p = new List<string>();
                foreach (string name in uninstall.GetSubKeyNames())
                {
                    if (name[0] != '{')
                    {
                        p.Add(name);
                    }
                }
                Array.Sort(p.ToArray());
                installed.Items.AddRange(p.ToArray());
            }
        }

        public Form2()
        {
            InitializeComponent();
            AddItemsactive();
        }

        private void installedb_Click(object sender, EventArgs e)
        {
            prog.Text = "Кол-во: 0";
            active.Items.Clear();
            AddItemsinstalled();
            active.Hide();
            installed.Show();
        }

        private void activeb_Click(object sender, EventArgs e)
        {
            prog.Text = "Кол-во: 0";
            installed.Items.Clear();
            AddItemsactive();
            installed.Hide();
            active.Show();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            if (active.Visible == true) { AddItemsactive(); }
            else { AddItemsinstalled(); }
            
        }
    }
}
