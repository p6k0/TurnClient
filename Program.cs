using System;
using System.Windows.Forms;
using System.Xml;

namespace TurnClient
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
            /*
            Application.Run(new LineGroupEditForm());
            Application.Exit();*/
            XmlDocument cfg = new XmlDocument();

            using (StartupForm f = new StartupForm())
            {
                switch (f.ShowDialog())
                {
                    case DialogResult.Yes:
                        using (OpenFileDialog dlg = new OpenFileDialog())
                            if (dlg.ShowDialog() == DialogResult.OK)
                                cfg.Load(dlg.FileName);
                        break;
                }
            }

            Application.Run(new Form1(cfg));
        }
    }
}
