using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\ee841\source\repos\ConsoleApp18\ConsoleApp18\bin\Debug\ConsoleApp18.exe";
            //Application.ExecutablePath
            var driver = new Driver();
           string result= driver.Start(path);
            //Program.Main();
            this.textBoxOutput.Text = result;
        }
    }
}
