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
using System.Management;
using System.Management.Instrumentation;

namespace SystemMonitor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

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

        private void Button_Click(object sender, EventArgs e)
        {
            inf.Content = GetInfo();
        }

        public static String GetUptime()
        {
            TimeSpan time = TimeSpan.FromMilliseconds(Environment.TickCount);
            return $"{time.Days} дней {time.Hours} часов {time.Minutes} минут {time.Seconds} секунд";
        }

        public static String GetInfo()
        {
            var mo = new ManagementObject(@"\\.\root\cimv2:Win32_OperatingSystem=@");
            return $"ОС: {mo["Caption"]}\n" +
                $"Имя: {mo["CSName"]}\n" +
                $"Процессор: {String.Join("",GetHardwareInfo("Win32_Processor", "Name"))}\n" +
                $"Число потоков: {Environment.ProcessorCount} \n" +
                $"Видеоядро: {String.Join("", GetHardwareInfo("Win32_VideoController", "Name"))} \n" +
                $"ОЗУ: {Convert.ToInt64(mo["FreePhysicalMemory"]) / 1024} мб / {Convert.ToInt64(mo["TotalVisibleMemorySize"]) / 1024} мб\n" +
                $"Разрядность: {mo["OSArchitecture"]}\n" +
                $"Логические диски: {String.Join(" ", Environment.GetLogicalDrives()).TrimEnd(',', ' ').Replace("\\", String.Empty)}\n" +
                $"Время сеанса: {GetUptime()}\n\n" +
                $"Время обновления: {DateTime.Now}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void proglist_Click(object sender, RoutedEventArgs e)
        {
            Information.Hide();
            Window plist = new plist();
            plist.Show();
        }
    }
}
