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
            //need a timer to show the position of the mouse every 50 ms
            DispatcherTimer dt = new DispatcherTimer();
            dt.Tick += new EventHandler(interrogateMouse);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 50);
            dt.Start();

        }
        private void interrogateMouse(object sender, EventArgs e)
        {
            // called every 50 ms just display results from Mouse.GetPosition
            Point pMouse = Mouse.GetPosition(this);
            MouseXValue.Content = pMouse.X;
            MouseYValue.Content = pMouse.Y;
        }
        private void mouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // called if someone clicks anywhere in window
            Point p = Mouse.GetPosition(this);
            MouseClicked.Content = "Clicked at " + p;
        }

        private void keyPressed(object sender, KeyEventArgs e)
        {
            // called if key is pressed with focus on the window a switch is a fairly standard way of handling this sort of thing
            switch (e.Key)
            {
                case Key.Delete:
                    KeyPressLabel.Content = "Delete was pressed";
                    break;
                case Key.E:
                    KeyPressLabel.Content = "E was pressed";
                    break;
                default:
                    KeyPressLabel.Content = e.Key.ToString() + " was pressed with " + Keyboard.Modifiers;
                    break;
            }
        }
    }
}
