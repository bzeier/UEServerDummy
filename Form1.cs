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
            this.Text = "Wurms Online - Dedicated Server Instance (" + System.Net.Dns.GetHostName() + ")";
            this.ControlBox = false;
            label2.Text = Program.MyIPAdress;
            label4.Text = Program.MyPort;
            label6.Text = "Running";
            label6.BackColor = System.Drawing.Color.Lime;

            label10.Text = (DateTime.Now - Program.StartTime).Seconds.ToString();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}