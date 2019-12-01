using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Common
{
    static class EntryPoint
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (Form1 form = new Form1())
            {
                Application.Run(form);
            }
        }
    }
}
