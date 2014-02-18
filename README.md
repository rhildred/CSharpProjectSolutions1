CSharpProjectSolutions
======================

examples from introductory C# class 2014

Adding Machine
--------------

Simple XAML WPF app, taken from [Rob Miles' C# Yellow book](http://www.robmiles.com/c-yellow-book/).

Sprite Animation
----------------

Turns out that there are no simple examples of Sprite Animation using WPF/XAML. I wrote one that I think is pretty straightforward.

XAML

    <Window>
            xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
            xmlns:Properties="clr-namespace:SpriteAnimation.Properties" x:Class="SpriteAnimation.MainWindow"
            Title="MainWindow" Height="400" Width="555">
        <Grid>
            <Image x:Name="ImageControl" HorizontalAlignment="Left" Height="300" Margin="0,0,0,0" VerticalAlignment="Top" Width="555"/>
        </Grid>
    </Window>
  
CS

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
                  // DispatcherTimer setup
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

TDD Application
---------------

Simple TDD application using nUnit. The main example is TaxTest.cs and CanadianTax.cs.
