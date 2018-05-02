using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        private static Server server;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Console.WriteLine("Starting HttpServer...");

            server = new Server(8080);
            server.Run();

            Console.WriteLine("HttpServer started.");
            Console.WriteLine("Listening at {0}", server.BaseUrl);
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to exit");
            //Console.ReadLine();
        }

        protected override void OnStop()
        {
            if (server != null)
            {
                server.Stop();
            }
        }
    }
}
