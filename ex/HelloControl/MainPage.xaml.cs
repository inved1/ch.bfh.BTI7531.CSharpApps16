using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HelloControl
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        static readonly SolidColorBrush RED = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
        static readonly SolidColorBrush GREEN = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        static readonly SolidColorBrush BLUE = new SolidColorBrush(Color.FromArgb(255, 0, 0, 255));

        private void BtnColor_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (RectColor.Fill == BLUE)
                RectColor.Fill = RED;
            else if (RectColor.Fill == RED)
                RectColor.Fill = GREEN;
            else
                RectColor.Fill = BLUE;

            //this.HelloControl2.Message = this.EditMessage.Text;
            //this.HelloControl2.Foreground = this.RectColor.Fill;
        }
    }
}
