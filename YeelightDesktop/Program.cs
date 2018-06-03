﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YeelightAPI;

namespace YeelightDesktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Console.WriteLine("start");
            test();
            Console.WriteLine("end");

        }

        private static void test()
        {
            Console.WriteLine("ins");

            Device device = new Device("192.168.0.105");
            device.Connect();
            device.SetPower(false);
            Console.WriteLine(device);
        }
    }
}
