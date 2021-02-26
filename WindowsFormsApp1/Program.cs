using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            var collection = new ServiceCollection();
            Configure(collection);
            var provider = collection.BuildServiceProvider();
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(provider.GetService<Form1>());
        }

        public static void Configure(IServiceCollection services)
        {
            services.AddSingleton<IDataService, DataService>();
            services.AddSingleton<Form1>();
        }
   

    }
}
