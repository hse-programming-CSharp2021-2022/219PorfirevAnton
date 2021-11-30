using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox1.Items.Add("one");
            this.listBox1.Items.Add("two");
            this.listBox1.Items.Add("three");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listBox1.Items.Add("one");
            this.listBox1.Items.Add("two");
            this.listBox1.Items.Add("three");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Cписок пуст, поэтому удалить невозможно или элемент не выбран");
            }
        }

    }
}
