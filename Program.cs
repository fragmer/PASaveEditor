﻿using System;
using System.Windows.Forms;

namespace PASaveEditor {
    internal static class Program {
        // The main entry point for the application.
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


        public const string Version = "revision 1, 4/6/2020";
    }
}
