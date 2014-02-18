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
using System.Windows.Threading;

namespace DispatchTimerExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dt = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            dt.Tick += new EventHandler(enterFrame);
            dt.Interval = new TimeSpan(0, 0, 2);
            dt.Start();

        }
        void enterFrame(object sender, EventArgs e)
        {
            Random rnd = new Random();
            byte[] vals = new byte[3];
            rnd.NextBytes(vals);
            Color c = Color.FromRgb(vals[0], vals[1], vals[2]);
            this.Background = new SolidColorBrush(c);
        }
    }
}
