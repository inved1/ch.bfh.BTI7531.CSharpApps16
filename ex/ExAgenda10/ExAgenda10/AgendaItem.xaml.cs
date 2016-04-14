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

namespace ExAgenda10
{
    public sealed partial class AgendaItem : UserControl
    {
        public AgendaItem()
        {
            this.InitializeComponent();
        }

        public new Brush Background
        {
            get { return this.GridBG.Background; }
            set { this.GridBG.Background = value; }
        }

        public new Brush Foreground
        {
            get { return this.TextText.Foreground; }
            set
            {
                this.TextText.Foreground = value;
                this.TextTime.Foreground = value;
                this.SymbolAttachment.Foreground = value;
                this.SymbolImportant.Foreground = value;
            }
        }

        public string Text
        {
            get { return this.TextText.Text; }
            set { this.TextText.Text = value; }
        }

        int day = 0;
        public int Day
        {
            get { return day; }
            set
            {
                day = (value < 0) ? 0 : value % 7;
                Grid.SetColumn(this, day + 1);
            }
        }

        public string Time
        {
            get { return this.TextTime.Text; }
            set
            {
                this.TextTime.Text = value;
                var v = value.Split(':', '-');
                int s = Int32.Parse(v[0]) * 2 + Int32.Parse(v[1]) / 30;
                int e = Int32.Parse(v[2]) * 2 + Int32.Parse(v[3]) / 30;
                Grid.SetRow(this, s + 1);
                Grid.SetRowSpan(this, e - s);
            }
        }

        static SolidColorBrush PrioBrush1 = new SolidColorBrush(Color.FromArgb(255, 0, 240, 240));
        static SolidColorBrush PrioBrush2 = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));

        public int Priority
        {
            get
            {
                if (this.BorderPrio.Visibility == Visibility.Visible)
                {
                    if (this.BorderPrio.Background == PrioBrush1)
                        return 1;
                    else if (this.BorderPrio.Background == PrioBrush2)
                        return 2;
                }
                return 0;
            }
            set
            {
                if (value == 1)
                    this.BorderPrio.Background = PrioBrush1;
                else if (value == 2)
                    this.BorderPrio.Background = PrioBrush2;

                if ((value == 1) || (value == 2))
                    this.BorderPrio.Visibility = Visibility.Visible;
                else
                    this.BorderPrio.Visibility = Visibility.Collapsed;
            }
        }

        public bool IsImportant
        {
            get { return this.SymbolImportant.Visibility == Visibility.Visible; }
            set { this.SymbolImportant.Visibility = (value) ? Visibility.Visible : Visibility.Collapsed; }
        }

        public bool HasAttachments
        {
            get { return this.SymbolAttachment.Visibility == Visibility.Visible; }
            set { this.SymbolAttachment.Visibility = (value) ? Visibility.Visible : Visibility.Collapsed; }
        }
    }
}
