using System;
using System.Windows.Forms;

namespace inveentory__system
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start with LoginForm
            Application.Run(new Login());
        }
    }
}
