using System;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Media.Animation;

namespace Coding4Fun.Obd.InstrumentCluster.Controls.Skin1967
{
	/// <summary>
	/// Interaction logic for Marquee.xaml
	/// </summary>
	public partial class Marquee : UserControl
	{
        private Storyboard uxSB_GameLoop;

		public Marquee()
		{
			this.InitializeComponent();
            Loaded += new RoutedEventHandler(Marquee_Loaded);
		}

        void Marquee_Loaded(object sender, RoutedEventArgs e)
        {
            uxSB_GameLoop = (Storyboard)TryFindResource("uxSB_GameLoop");
            if (uxSB_GameLoop != null)
            {
                uxSB_GameLoop.Completed += new EventHandler(uxSB_GameLoop_Completed);
                uxSB_GameLoop.Begin();
            }
        }

        void uxSB_GameLoop_Completed(object sender, EventArgs e)
        {
            double x = (double)uxTextBlock.GetValue(Canvas.LeftProperty)-2;
            if (x <= -uxTextBlock.ActualWidth) x = LayoutRoot.Width;

            uxTextBlock.SetValue(Canvas.LeftProperty, x);
            uxSB_GameLoop.Begin();
        }

        private static void OnValuesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Marquee m = (Marquee)d;
            m.UpdateText();
        }

        public void UpdateText()
        {
            uxTextBlock.Text = Text;
            uxTextBlock.SetValue(Canvas.LeftProperty, LayoutRoot.Width);
        }

        [Category("Common Properties")]
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(Marquee), new PropertyMetadata("", new PropertyChangedCallback(OnValuesChanged)));
	}
}