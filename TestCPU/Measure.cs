using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace TestCPU
{
    class Measure
    {
        // Функция измерения текущей температуры ЦП
        public double GetTemperature()
        {
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\WMI",
                    "SELECT * FROM MSAcpi_ThermalZoneTemperature");

                double curTemp = 0;
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    double temp = Convert.ToDouble(queryObj["CurrentTemperature"].ToString());
                    curTemp = (temp / 10 - 273.15);
                }
                return curTemp;
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
                return 0;
            }
        }

        public double getLoad()
        {
            // Здесь будет код
            return 0;
        }

        // Также тут будет отрисовка графика
    }
}
