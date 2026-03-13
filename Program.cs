using System;
using System.Windows.Forms;
using TechCheck.Views;

namespace TechCheck
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // .NET 9.0 için en temiz baþlatma yolu
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
        }
    }
}