using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;

namespace UEServerDummy
{
    public partial class Form1 : Form
    {

        Process ServerProcess;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AllocConsole();
            label2.Text = Program.MyIPAdress;
            label4.Text = Program.MyPort;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

    }
}