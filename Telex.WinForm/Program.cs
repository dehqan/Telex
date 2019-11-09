using System;
using System.Windows.Forms;
using Telex.Business.Services;
using Telex.Business.Services.Interfaces;
using Telex.WinForm.Forms;
using Unity;

namespace Telex.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UnityContainer container = new UnityContainer();
            container.RegisterType<ITelegramService, TelegramService>();

            var loginForm = container.Resolve<LoginForm>();

            Application.Run(loginForm);
        }
    }
}
