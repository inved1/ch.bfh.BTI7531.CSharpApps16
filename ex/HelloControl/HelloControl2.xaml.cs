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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace HelloControl
{
    public sealed partial class HelloControl2 : UserControl
    {
        public HelloControl2()
        {
            this.InitializeComponent();
        }

        public String Message
        {
            get { return this.TB_Message.Text; }
            set { this.TB_Message.Text = value; }
        }

        public new Brush Background
        {
            get { return this.BG_Border.Background; }
            set { this.BG_Border.Background = value; }
        }
        public new Brush Foreground
        {
            get { return this.TB_Message.Foreground; }
            set
            {
                this.TB_Message.Foreground = value;
                this.BG_Border.BorderBrush = value;
            }
        }
    }
}
