using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.text.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.text.Text += "1";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.text.Text += "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.text.Text += "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.text.Text += "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.text.Text += "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.text.Text += "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.text.Text += "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            this.text.Text += "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            this.text.Text += "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            this.text.Text += "0";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            this.text.Text = "";
        }
    }
}
