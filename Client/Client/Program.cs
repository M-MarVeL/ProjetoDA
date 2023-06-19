using Client.Controllers;
using Client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(CinemaController.getCinema().Count() <= 0) {
                Application.Run(new CinemaMain());
            } else {
                Application.Run(new FormMain());
            }
        }
    }
}
