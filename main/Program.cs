using System;
using System.Windows.Forms;
using YugiohApp.view;

namespace CSharp_SQL_App {
    internal static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            Application.Exit();
        }
    }
}