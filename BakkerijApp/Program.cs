using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.DataContext;
using Microsoft.EntityFrameworkCore;

namespace BakkerijApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool useLocalDb = true;

            Boolean.TryParse(ConfigurationManager.AppSettings["UseLocalDb"], out useLocalDb);

            if (useLocalDb)
            {
                using (var dbContext = new BakkerijDataContext())
                {
                    dbContext.Database.EnsureCreated();
                }
            }

            Application.Run(new MainForm());
        }
    }
}
