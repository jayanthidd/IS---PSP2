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

namespace MathEvents
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

        private void onCalculation(object sender, RoutedEventArgs e)
        {
            var first = Int32.Parse(num1.Text);
            var second =Int32.Parse(num2.Text);
            var oper = ((ListBoxItem)operation.SelectedItem).Content.ToString();
            calculate(oper, first, second);
        }

        private void calculate(string oper, int first, int second)
        {
            var output = 0;
            if (oper.Equals("Add"))
            {
                output = first + second;
            }
            else if (oper.Equals("Subtract")) {
                output = first - second;
            }

            result.Content = output;
        }
    }
}
