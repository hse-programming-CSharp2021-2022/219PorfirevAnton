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
        int W = 100;
        int H = 100;
        int X = 0;
        int Y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Y = Height - 100;
            trackBar2.Value = trackBar2.Minimum;
            BackColor = Color.Red;
        }
        // Метод для перерисовки формы:
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            trackBar1.Maximum = Width - W;
            trackBar2.Maximum = Height - H;
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDark), X, Y, W, H);
            // Устанавливаем цвет ControlDark "прозрачным":
            TransparencyKey = SystemColors.ControlDark;
        }

        // Метод реагирует на каждое перемещение  
        // пользователем ползунка на элементе trackBar1:
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            X = trackBar1.Value;
            // после изменения пользователем ползунка 
            // элемента trackBar1 необходимо 
            // переместить форточку, для чего перерисуем всю форму:
            Invalidate();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Y = Height - trackBar2.Value - 100;
            Invalidate();
        }
    }
}
