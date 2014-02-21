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

namespace UserInput
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer dt = new DispatcherTimer();
            dt.Tick += new EventHandler(enterFrame);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 50);
            dt.Start();
        }

        private void enterFrame(object sender, EventArgs e)
        {
            mouseLocation.Content = Mouse.GetPosition(this);
        }

        private void keypressed(object sender, KeyEventArgs e)
        {
            string sOut = "";
            switch (e.Key)
            {
                case Key.A:
                    sOut = "A is for apple";
                    break;
                default:
                    sOut = e.Key.ToString() + " was pressed with modifier " + Keyboard.Modifiers;
                    break;
            }
            keypressedtext.Content = sOut;
        }

        private void mouseClicked(object sender, MouseButtonEventArgs e)
        {
            mouseClickMessage.Content = "Clicked " + Mouse.GetPosition(this);
        }
    }
}
