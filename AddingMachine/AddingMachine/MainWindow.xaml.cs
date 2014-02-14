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

namespace AddingMachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            resultTextBlock.Text = "";
            firstNumberTextBox.Focus();
        }

        private void equalsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal nAmt1 = Decimal.Parse(firstNumberTextBox.Text);
                decimal nAmt2 = Decimal.Parse(secondNumberTextBox.Text);
                decimal nResult = nAmt1 + nAmt2;
                resultTextBlock.Text = nResult.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter numeric values for the numbers to be added");
            }
        }

    }
}
