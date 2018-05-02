using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsService1
{
    public partial class FormTestHttpServer : Form
    {
        private Server server;
        public FormTestHttpServer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Starting HttpServer...");

            server = new Server(8080);
            server.Run();

            Console.WriteLine("HttpServer started.");
            Console.WriteLine("Listening at {0}", server.BaseUrl);
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to exit");
            Console.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (server !=  null)
            {
                server.Stop();
            }
        }
    }
}
