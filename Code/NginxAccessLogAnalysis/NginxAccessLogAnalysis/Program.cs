using System;
using System.Windows.Forms;

namespace NginxAccessLogAnalysis
{
    /// <summary>
    /// 
    /// </summary>
    /// autor: 刘彦桢
    /// date: 2020-8-20
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
