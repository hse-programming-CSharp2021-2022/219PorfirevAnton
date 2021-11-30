using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        double step;
        bool cat;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Чеширский кот";
            this.label1.ForeColor = Color.DeepPink;
            this.timer1.Enabled = true;
            step = 0.1;
            cat = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.label1.Text.Length != 0 && cat)
                this.label1.Text = this.label1.Text.Substring(0, this.label1.Text.Length - 1);
            else if(this.label1.Text.Length == 0 && this.Opacity > 0)
            {
                cat = false;
                this.Opacity -= step;
            }
            else
            {
                this.label1.Text = "Кот уже ушёл";
                this.Opacity += step;
            }
        }
    }
}
