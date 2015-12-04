using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SousaSoft.LogStuff;

namespace SousaSoft.LogStuff.CSharp
{
    public partial class ExampleApp : Form
    {
        public SousaSoft.LogStuff.Log Log;
        public SousaSoft.LogStuff.LogShow LogShow;
        public ExampleApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            path = Application.StartupPath + "\\Log.txt";
            Log.LogFile = path;
            Log.Header = "ExampleApp C# Test Log Header";
            Log.Add("ExampleApp " + textBox1.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path;
            path = Application.StartupPath + "\\Log.txt";
            LogShow.LogFile = path;
            LogShow.CLReader();
            richTextBox1.Text = LogShow.CurrentLog; 


        }
    }
}
