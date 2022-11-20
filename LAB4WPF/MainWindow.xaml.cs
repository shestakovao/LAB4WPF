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

namespace LAB4WPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double tempRate = Convert.ToDouble(rateDollar.Text);
            double tempSum = Convert.ToDouble(sumDollar.Text);
            resultDollar.Text = Convert.ToString(tempRate * tempSum);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double tempRate = Convert.ToDouble(rateEvro.Text);
            double tempSum = Convert.ToDouble(sumEvro.Text);
            resultEvro.Text = Convert.ToString(tempRate * tempSum);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double tempRate = Convert.ToDouble(rateGrivna.Text);
            double tempSum = Convert.ToDouble(sumGrivna.Text);
            resultGrivna.Text = Convert.ToString(tempRate * tempSum);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double tempRate = Convert.ToDouble(rateDrami.Text);
            double tempSum = Convert.ToDouble(sumDrami.Text);
            resultDrami.Text = Convert.ToString(tempRate * tempSum);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double temp = Convert.ToDouble(inches.Text);
            resultInches.Text = Convert.ToString(temp * 2.54 / 100.0);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double temp = Convert.ToDouble(feet.Text);
            resultFeet.Text = Convert.ToString(temp * 0.3048);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double temp = Convert.ToDouble(miles.Text);
            resultMiles.Text = Convert.ToString(temp * 1609.34);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double temp = Convert.ToDouble(verst.Text);
            resultVerst.Text = Convert.ToString(temp * 1066.8);

        }
    }
}
