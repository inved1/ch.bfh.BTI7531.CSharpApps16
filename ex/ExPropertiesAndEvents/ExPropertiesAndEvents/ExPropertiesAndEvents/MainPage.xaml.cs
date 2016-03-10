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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ExPropertiesAndEvents
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

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var element = sender as FrameworkElement;

            int col = (int)Grid.GetColumn(element);
            int row = (int)Grid.GetRow(element);

            if ((col >= 2) || (row >= 2))
                MainGrid.Children.Remove(element);
            else if (col > row)
                Grid.SetRow(element, row + 1);
            else
                Grid.SetColumn(element, col + 1);
        }

        private void MainGrid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var btn = new Button();
            btn.Content = (new Random()).Next();
            btn.Tapped += Button_Tapped;
            Grid.SetColumn(btn, 0);
            Grid.SetRow(btn, 0);
            MainGrid.Children.Add(btn);
        }

        bool isYellow = true;
        Brush bg = null;

        private void Border_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Border border = sender as Border;

            if (isYellow)
            {
                bg = border.Background;
                border.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                e.Handled = true;
            }
            else
            {
                border.Background = bg;
            }

            isYellow = !isYellow;
        }
    }
}
