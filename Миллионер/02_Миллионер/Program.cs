﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Миллионер
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //Application.Run(new Form1());
            Form1 frm = new Form1();
           MainFormPresenter mainFrm = new MainFormPresenter(frm);
           frm.ShowDialog();
        }
    }
}
