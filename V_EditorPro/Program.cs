using System;
using System.Windows.Forms;

namespace V_EditorPro
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string filePath = args.Length > 0 ? args[0] : null;
            Application.Run(new Form1(filePath));
        }
    }
}