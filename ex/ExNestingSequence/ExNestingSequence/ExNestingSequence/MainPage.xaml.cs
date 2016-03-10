using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ExNestingSequence
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

        private void b1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            b1.Opacity = (b1.Opacity < 0.1) ? 1.0 : b1.Opacity - 0.25;
            t1.Text = String.Format("Text before / Opacity = {0}", b1.Opacity);
        }

        private void b2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            b2.Opacity = (b2.Opacity < 0.1) ? 1.0 : b2.Opacity - 0.25;
            t2.Text = String.Format("Text inside / Opacity = {0}", b2.Opacity);
        }

        private void b3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            b3.Opacity = (b3.Opacity < 0.1) ? 1.0 : b3.Opacity - 0.25;
            t3.Text = String.Format("Text after / Opacity = {0}", b3.Opacity);
        }
    }
}
