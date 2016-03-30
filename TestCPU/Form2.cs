using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;
using System.Management;
using System.Messaging;

namespace TestCPU
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            //SHA1
            byte[] data = new byte[15000];
            byte[] result;

            SHA1 sha = new SHA1CryptoServiceProvider();
            // This is one implementation of the abstract class SHA1.
            result = sha.ComputeHash(data);

            sha1Res.Text = BitConverter.ToString(result);

            //Температура
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\WMI",
                    "SELECT * FROM MSAcpi_ThermalZoneTemperature");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    double temp = Convert.ToDouble(queryObj["CurrentTemperature"].ToString());
                    double temp_critical = Convert.ToDouble(queryObj["CriticalTripPoint"].ToString());
                    double temp_cel = (temp / 10 - 273.15);
                    double temp_critical_cel = temp_critical / 10 - 273.15;
                    tempProc.Text = temp_cel.ToString();
                    curTemp.Text = temp_critical_cel.ToString();
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }
        }
    }
}
