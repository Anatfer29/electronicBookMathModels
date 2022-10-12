using System;
using System.Windows.Forms;

namespace dpdpdp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form f = new Auth();
            //if (f.ShowDialog() == DialogResult.OK)
            //{
            Application.Run(new Auth());
            // }
        }
    }
}
