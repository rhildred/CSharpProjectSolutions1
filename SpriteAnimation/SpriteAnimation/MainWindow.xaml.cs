using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpriteAnimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WriteableBitmap writeableBitmap = null;
        BitmapImage bi = null;
        public MainWindow()
        {
            InitializeComponent();
            //  DispatcherTimer setup
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(enterFrame);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 50);
            dispatcherTimer.Start();

            writeableBitmap = new WriteableBitmap(
                 (int)ImageControl.Width,
                 (int)ImageControl.Height,
                 96,
                 96,
                 PixelFormats.Pbgra32,
                 null);
            ImageControl.Source = writeableBitmap;
            bi = new BitmapImage(new Uri("pack://application:,,,/filmstrip.png"));

        }
        int nY = 0;
        private void enterFrame(object sender, EventArgs e)
        {
            // Calculate stride of source
            int nRowBytes = bi.PixelWidth * (bi.Format.BitsPerPixel / 8);

            // Create data array to hold source pixel data
            byte[] data = new byte[nRowBytes * 300];

            // Copy source image pixels to the data array
            bi.CopyPixels(new Int32Rect(0, nY*300, bi.PixelWidth, 300), data, nRowBytes, 0);
            writeableBitmap.WritePixels(
                new Int32Rect(0, 0, bi.PixelWidth, 300),
                data, nRowBytes, 0);
            if (++nY == 100) nY = 0;
        }
    }
}
