using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;
using static Rapid_Trigger_Config.Settings;
using static Rapid_Trigger_Config.Form1;
using System.IO;

namespace Rapid_Trigger_Config
{
    internal class App
    {
        public static void ProcessResponse(string response)
        {
            ConfigArray = response.Split(',');
            for (int i = 0; i < ConfigArray.Length; i++)
            {
                Console.WriteLine("ConfigArray[" + i + "]: " + ConfigArray[i]);
            }
        }

        public static void PrepareConfigString()
        {
            ConfigString = string.Join(",", ConfigArray);
            Console.WriteLine("ConfigString: " + ConfigString);
        }

        public static string ConvertToMM(string i)
        {
            int value = int.Parse(i);
            double millimeters = value / 250.0;
            Console.WriteLine("Value: " + value + " Millimeters: " + millimeters);
            return millimeters.ToString("F1");
        }
    }
}