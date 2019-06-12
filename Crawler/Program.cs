#region COPYRIGHT & CODE DESCRIPTION

// © 2013-2013 by Chen Chen (s3361039) Xu Song (s3289486). All rights reserved
// 
// 
// SOLUTION: Crawler
// PROJECT:    Crawler
// FILENAME:  Program.cs
// 
// CREATED IN 11:30 PM (02/05/2013)
// 
// LAST EDITED: 9:27 PM (07/05/2013)

#endregion

using System;
using System.Windows.Forms;
using Crawler.Properties;

namespace Crawler
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new UI.frmCrawler(args));
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Program_Main_Illegal_parameter_);
                Application.Exit();
            }
        }
    }
}