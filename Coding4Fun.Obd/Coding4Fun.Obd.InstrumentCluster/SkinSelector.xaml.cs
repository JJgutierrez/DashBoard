using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System;
using Coding4Fun.Obd.InstrumentCluster.Classes;
using Coding4Fun.Obd.InstrumentCluster.Controls.Skin1967;
using Coding4Fun.Obd.ObdManager;

namespace Coding4Fun.Obd.InstrumentCluster
{
	/// <summary>
	/// Interaction logic for SkinSelector.xaml
	/// </summary>
	public partial class SkinSelector : UserControl
	{
		private const int SwipeDistance = 200;

		private readonly InstrumentClusterSkin[] _skins = new InstrumentClusterSkin[3];
		private Point _startPoint;
		private ObdDevice _obd;

		public SkinSelector()
		{
			InitializeComponent();
		}

		void UserControl_Loaded(object sender, RoutedEventArgs e)
		{
			_obd = new ObdDevice();

			_obd.ObdConnectionChanged += _obd_ObdConnectionChanged;
			_obd.ObdChanged += _obd_ObdChanged;

			SetMessage("Connecting to OBD...");

			if(!DesignerProperties.GetIsInDesignMode(this) && !string.IsNullOrEmpty(Properties.Settings.Default.ComPort))
			{
				try
				{
					Task.Factory.StartNew(() => _obd.Connect(Properties.Settings.Default.ComPort, Properties.Settings.Default.Baud, ObdDevice.UnknownProtocol, true))
					.ContinueWith(action =>
					{
						Exception ex = action.Exception.Flatten();

						SetMessage("Unable to connect to OBD device: " + ex.Message);
						Debug.WriteLine(ex);
					}, TaskContinuationOptions.OnlyOnFaulted);
				}
				catch(Exception ex)
				{
					SetMessage("Unable to connect to OBD device: " + ex.Message);
					Debug.WriteLine(ex);
				}
			}

			uxSkin1967.uxSettings.Click += uxSettings_Click;
			uxSkin2011.uxSettings.Click += uxSettings_Click;
			uxSkinMetro.uxSettings.Click += uxSettings_Click;

			_skins[0] = uxSkin2011;
			_skins[1] = uxSkin1967;
			_skins[2] = uxSkinMetro;

			uxSkin1967.Visibility = Visibility.Collapsed;
			uxSkinMetro.Visibility = Visibility.Collapsed;
		}

		private void SetMessage(string txt)
		{
			Dispatcher.BeginInvoke(new Action(() => 
			{
				uxSkin1967.Message = txt;
				uxSkin2011.Message = txt;
				uxSkinMetro.Message = txt;
			}));
		}

		void _obd_ObdConnectionChanged(object sender, ConnectionChangedEventArgs e)
		{
			SetMessage("OBD " + (e.Connected ? "Connected" : "Disconnected"));
		}

		void _obd_ObdChanged(object sender, ObdChangedEventArgs e)
		{
			Dispatcher.BeginInvoke(new Action(() => SetInstrumentClusterValues(e.ObdState)));
		}

		private void SetInstrumentClusterValues(ObdState measurement)
		{
			foreach (var item in _skins)
			{
				if(!item.IsVisible)
					continue;

				item.IsMalfunctionVisible = measurement.MilLightOn;

				item.IsLowFuelVisible = item.Fuel < 10;

				item.MPG = measurement.MilesPerGallon;
				item.MPH = measurement.MilesPerHour;
				item.RPM = measurement.Rpm;
				item.Fuel = measurement.FuelLevel;
				item.Temperature = measurement.EngineCoolantTemperature;
			}
		}

		void uxSettings_Click(object sender, RoutedEventArgs e)
		{
			uxAccentColorsSelection.IsOpen = true;
		}

		private void Scroll_TouchDown(object sender, TouchEventArgs e)
		{
			TouchMouseDown(e.GetTouchPoint(Scroll).Position);
			e.Handled = true;
		}

		private void Scroll_TouchMove(object sender, TouchEventArgs e)
		{
			e.Handled = true;
		}

		private void Scroll_TouchUp(object sender, TouchEventArgs e)
		{
			TouchMouseUp(e.GetTouchPoint(Scroll).Position);
			e.Handled = true;
		}

		private void Scroll_PreviewMouseDown(object sender, MouseButtonEventArgs e)
		{
			TouchMouseDown(e.GetPosition(Scroll));
			e.Handled = true;
		}

		private void Scroll_MouseMove(object sender, MouseEventArgs e)
		{
			e.Handled = true;
		}

		private void Scroll_MouseUp(object sender, MouseButtonEventArgs e)
		{
			TouchMouseUp(e.GetPosition(Scroll));
			e.Handled = true;
		}

		private void TouchMouseDown(Point p)
		{
			uxSkin1967.Visibility = Visibility.Visible;
			uxSkin2011.Visibility = Visibility.Visible;
			uxSkinMetro.Visibility = Visibility.Visible;

			_startPoint = p;
		}

		private void TouchMouseUp(Point p)
		{
			if(p.X > _startPoint.X + SwipeDistance)
				DoScrollAnimation(-1);
			else if(p.X < _startPoint.X - SwipeDistance)
				DoScrollAnimation(1);
			else
				HandleVisibility();
		}


		private void DoScrollAnimation(int direction)
		{
			Storyboard sb = (Storyboard)FindResource("ScrollAnimation");
			DoubleAnimation da = (DoubleAnimation)sb.Children[0];
			da.To = Scroll.HorizontalOffset + (Scroll.ViewportWidth * direction);
			sb.Completed += sb_Completed;
			sb.Begin();
		}

		void sb_Completed(object sender, EventArgs e)
		{
			HandleVisibility();
		}

		private void HandleVisibility()
		{
			if(Math.Abs(Scroll.HorizontalOffset - Scroll.ViewportWidth * 0) < 1)
			{
				uxSkin2011.Visibility = Visibility.Visible;
				uxSkin1967.Visibility = Visibility.Collapsed;
				uxSkinMetro.Visibility = Visibility.Collapsed;
			}

			else if(Math.Abs(Scroll.HorizontalOffset - Scroll.ViewportWidth * 1) < 1)
			{
				uxSkin2011.Visibility = Visibility.Collapsed;
				uxSkin1967.Visibility = Visibility.Visible;
				uxSkinMetro.Visibility = Visibility.Collapsed;
			}

			else if(Math.Abs(Scroll.HorizontalOffset - Scroll.ViewportWidth * 2) < 1)
			{
				uxSkin2011.Visibility = Visibility.Collapsed;
				uxSkin1967.Visibility = Visibility.Collapsed;
				uxSkinMetro.Visibility = Visibility.Visible;
			}
		}
	}
}