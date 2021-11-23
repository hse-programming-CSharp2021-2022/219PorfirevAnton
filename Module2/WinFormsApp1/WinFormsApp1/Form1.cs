using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "hi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "hello2";
        }
    }
}
