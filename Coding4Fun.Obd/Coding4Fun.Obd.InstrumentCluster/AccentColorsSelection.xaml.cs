using System.Windows;
using System.Windows.Controls;

namespace Coding4Fun.Obd.InstrumentCluster
{
	/// <summary>
	/// Interaction logic for AccentColorsSelection.xaml
	/// </summary>
	public partial class AccentColorsSelection : UserControl
    {
        private bool _IsOpen = false;

		public AccentColorsSelection()
		{
			this.InitializeComponent();
            Loaded += new RoutedEventHandler(AccentColorsSelection_Loaded);
		}

        void AccentColorsSelection_Loaded(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "Closed", false);

            uxClose.Click += new RoutedEventHandler(uxClose_Click);

            uxThemeColor_Green.Click += new RoutedEventHandler(uxThemeColor_Click);
            uxThemeColor_Red.Click += new RoutedEventHandler(uxThemeColor_Click);
            uxThemeColor_Blue.Click += new RoutedEventHandler(uxThemeColor_Click);
            uxThemeColor_Yellow.Click += new RoutedEventHandler(uxThemeColor_Click);
            uxThemeColor_Pink.Click += new RoutedEventHandler(uxThemeColor_Click);
            uxThemeColor_Brown.Click += new RoutedEventHandler(uxThemeColor_Click);
            uxThemeColor_Lime.Click += new RoutedEventHandler(uxThemeColor_Click);
            uxThemeColor_Teal.Click += new RoutedEventHandler(uxThemeColor_Click);
            uxThemeColor_Purple.Click += new RoutedEventHandler(uxThemeColor_Click);
            uxThemeColor_Magenta.Click += new RoutedEventHandler(uxThemeColor_Click);
        }

        void uxThemeColor_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["AccentColor"] = ((RadioButton)sender).Foreground;
            IsOpen = false;
        }

        void uxClose_Click(object sender, RoutedEventArgs e)
        {
            IsOpen = false;
        }

        public bool IsOpen
        {
            get
            {
                return _IsOpen;
            }
            set
            {
                _IsOpen = value;
                VisualStateManager.GoToState(this, value ? "Open" : "Closed", true);
            }
        }
	}
}