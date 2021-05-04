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



namespace LAB_1_WPF_
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

             
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(XValue.Text);
            double y = double.Parse(YValue.Text);
            double z = double.Parse(ZValue.Text);
            double a = Math.Exp(Math.Abs(x - y))
                       * Math.Pow(Math.Abs(x - y), x + y);
            double b = Math.Atan(x) + Math.Atan(z);
            double c = Math.Cbrt(Math.Pow(x, 6) + Math.Pow(Math.Log10(y),2.0));
            double rezult = a / b + c;
            Rezalt.Text = rezult.ToString();
        }

       
    }
}
