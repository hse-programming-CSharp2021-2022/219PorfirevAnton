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
    public partial class MainWindow : Window // происходит, какой-то рандомный прыжок иногда
    {
        double width;
        double height;
        public MainWindow()
        {
            width = 0;
            height = 295;
            InitializeComponent();
        }

        private void clickHandler(object sender, RoutedEventArgs e)
        {
            pol.Points.Clear();
            width = 38;
            height = 295;
            sliderH.Value = 0;
            sliderV.Value = 0;
        }

        private void sliderH_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            width = sliderH.Value * (357 / sliderH.Maximum);
            pol.Points.Add(new Point(width, height));
        }

        private void sliderV_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            height = 295 - sliderV.Value * (295 / sliderV.Maximum);
            pol.Points.Add(new Point(width, height));
        }
    }
}
