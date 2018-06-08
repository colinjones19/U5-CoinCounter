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

namespace U5_CoinCounter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void counter_Click(object sender, RoutedEventArgs e)
        {
            double a;
            double b;
            double c;
            double d;
            double f;

            double.TryParse(Toonies.Text, out a);
            double.TryParse(Loonies.Text, out b);
            double.TryParse(Quarters.Text, out c);
            double.TryParse(Dimes.Text, out d);
            double.TryParse(Nickels.Text, out f);
         
            double avalue = a * 2;
            double bvalue = b * 1;
            double cvalue = c * 0.25;
            double dvalue = d * 0.10;
            double fvalue = f * 0.05;
            double totalvalue = avalue + bvalue + cvalue + dvalue + fvalue;
                   
            MessageBox.Show("The Total Value is" + totalvalue);
        }
              }
}
