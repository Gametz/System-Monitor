using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;

namespace Practic
{
    public partial class Form1 : Form
    {

        private static List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
        {
            List<string> result = new List<string>();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);

            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    result.Add(obj[ClassItemField].ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        private static void OutputResult(string info, List<string> result)
        {
            if (info.Length > 0)
                Console.WriteLine(info);

            if (result.Count > 0)
            {
                for (int i = 0; i < result.Count; ++i)
                    Console.WriteLine(result[i]);
            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            time.Text = $"Время сеанса: {GetUptime()}";
            biostime.Text = GetStartUpTime();
            updtime.Text = $"Время обновления: {DateTime.Now}";
        }

        private void time_Click(object sender, EventArgs e, string text)
        {
        }

        public static String GetUptime()
        {
            TimeSpan time = TimeSpan.FromMilliseconds(Environment.TickCount);
            return $"{time.Days} дней {time.Hours} часов {time.Minutes} минут {time.Seconds} секунд";
        }

        public static String GetStartUpTime()
        {
            var mo = new ManagementObject(@"\\.\root\cimv2:Win32_OperatingSystem=@");
            return $"ОС: {mo["Caption"]}\n" +
                $"Имя: {mo["CSName"]}\n" +
                $"Процессор: {String.Join("",GetHardwareInfo("Win32_Processor", "Name"))}\n" +
                $"Число потоков: {Environment.ProcessorCount} \n" +
                $"Видеоядро: {String.Join("", GetHardwareInfo("Win32_VideoController", "Name"))} \n" +
                $"ОЗУ: {Convert.ToInt64(mo["FreePhysicalMemory"]) / 1024} мб / {Convert.ToInt64(mo["TotalVisibleMemorySize"]) / 1024} мб\n" +
                $"Разрядность: {mo["OSArchitecture"]}\n" +
                $"Логические диски: {String.Join(" ", Environment.GetLogicalDrives()).TrimEnd(',', ' ').Replace("\\", String.Empty)}";
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void biostime_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void proglist_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
