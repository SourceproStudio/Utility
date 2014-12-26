using System;
using System.Security.Principal;
using System.Windows.Forms;
using SourcePro.Csharp.Lab.Commons;
using SourcePro.Csharp.Lab.Forms;

namespace SourcePro.Csharp.Lab
{
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
            IsInAdministratorsGroup();
        }

        #region IsInAdministratorsGroup
        static private void IsInAdministratorsGroup()
        {
            try
            {
                WindowsIdentity currentIdentity = WindowsIdentity.GetCurrent();
                WindowsPrincipal currentNTUser = new WindowsPrincipal(currentIdentity);
                if (currentNTUser.IsInRole(WindowsBuiltInRole.Administrator))
                    Application.Run(new MainForm());
                else
                {
                    MessageBox.Show(string.Format("Dear {0}. Because you do not have administrator rights, so we'll exit !", currentNTUser.Identity.Name), MessageBoxCaptions.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("We encountered an unknown exception, and then exit !", MessageBoxCaptions.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
