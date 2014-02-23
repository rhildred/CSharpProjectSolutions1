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

namespace RunningMan
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
            dt.Interval = new TimeSpan(0, 0, 0, 0, 50);
            dt.Tick += new EventHandler(enterFrame);
            dt.Start();         
        }
        // copy from source to destination bitmap which needs to be writeable
        BitmapImage sourceBitmap = new BitmapImage(new Uri("pack://application:,,,/filmstrip.png"));
        WriteableBitmap destinationBitmap = null;
        const int nFrameHeight = 504, nFrames = 9;
        int dx = 8;
        int nFrame = 0, x = 0;
        private void enterFrame(object sender, EventArgs e)
        {
            destinationBitmap = new WriteableBitmap((int)DestinationImage.Width, (int)DestinationImage.Height, 
                96, 96, PixelFormats.Pbgra32, null);
            DestinationImage.Source = destinationBitmap;
            // make a copy buffer
            int nRowBytes = sourceBitmap.PixelWidth * sourceBitmap.Format.BitsPerPixel / 8;
            byte[] buffer = new byte[nRowBytes * nFrameHeight];
            // copy through buffer 
            sourceBitmap.CopyPixels(new Int32Rect(0, nFrame * nFrameHeight, sourceBitmap.PixelWidth, nFrameHeight), buffer, nRowBytes, 0);
            destinationBitmap.WritePixels(new Int32Rect(x, 0, sourceBitmap.PixelWidth, nFrameHeight), buffer, nRowBytes, 0);
            if (++nFrame == nFrames) nFrame = 0;
            x += dx;
            if (x > (int)DestinationImage.Width - sourceBitmap.PixelWidth) x = 0;
        }

        private void changeSpeedAndDirection(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                    dx++;
                    break;
                case Key.Down:
                    dx--;
                    if (dx == 0) dx = 8;
                    break;
            }
        }
    }
}
