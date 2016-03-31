using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace TestCPU
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Tests test = new Tests();

        public Form1()
        {
            InitializeComponent();
        }

        // Запрос на получение информации о ЦП
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

        private void start_Click(object sender, EventArgs e)
        {
            // Вывод информации о ЦП в форму
            foreach (ManagementObject queryObj in searcher.Get())
            {
                name.Text = queryObj["Name"].ToString();
                numCore.Text = queryObj["NumberOfCores"].ToString();
                ident.Text = queryObj["ProcessorId"].ToString();
                speed.Text = queryObj["MaxClockSpeed"].ToString() + " MHz";
                sysName.Text = queryObj["SystemName"].ToString();
                numLogCore.Text = queryObj["NumberOfLogicalProcessors"].ToString();
                curSpeed.Text = queryObj["CurrentClockSpeed"].ToString() + " MHz";
                data.Text = queryObj["DataWidth"].ToString() + " Bit";
                Cache1.Text = queryObj["L2CacheSize"].ToString() + " Kilobytes";
                Cache2.Text = queryObj["L3CacheSize"].ToString() + " Kilobytes";
                //Load.Text = queryObj["LoadPercentage"].ToString() + " %"; // У меня эта строчка не работает
                Manufacturer.Text = queryObj["Manufacturer"].ToString();
            }
        }

        private void hashTestStart_Click(object sender, EventArgs e)
        {
            string time = test.HashTest();
            HashTestTime.Text = time;

            // Здесь должен быть запуск замеров

            form2.Show();
        }

        private void hashTestStop_Click(object sender, EventArgs e)
        {
            // Можно добавить остановку теста 
        }
    }
}
