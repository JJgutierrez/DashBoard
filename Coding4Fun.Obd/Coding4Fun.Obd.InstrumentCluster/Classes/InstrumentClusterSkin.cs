using System;
using System.Windows.Controls;
using System.Windows;
using Coding4Fun.Obd.InstrumentCluster.Controls;
using Coding4Fun.Obd.InstrumentCluster.Controls.Skin1967;

namespace Coding4Fun.Obd.InstrumentCluster.Classes
{
    public class InstrumentClusterSkin : UserControl
    {
        public Button uxSettings;
        public Blinker uxLeftTurn;
        public Blinker uxRightTurn;
        public FrameworkElement uxLowFuel;
        public FrameworkElement uxHazard;
        public FrameworkElement uxMalfunction;
        public FrameworkElement uxOpenDoor;
        public TextBlock uxMessage;
        public Marquee uxMessageMarquee;
        public TextBlock uxOdometer;
        public TextBlock uxMPG;
        public Slider uxMPH;
        public Slider uxRPM;
        public Slider uxFuel;
        public Slider uxTemp;
        public Slider uxOil;
        public Slider uxBattery;
        public TextBlock uxMPHLabel;
        public TextBlock uxRPMLabel;

        private bool _IsLeftTurnBlinkerVisible;
        private bool _IsRightTurnBlinkerVisible;
        private bool _IsLowFuelVisible;
        private bool _IsHazardVisible;
        private bool _IsMalfunctionVisible;
        private bool _IsOpenDoorVisible;
        private string _Message;
        private double _Mileage;
        private double _MPG;
        private double _MPH;
        private double _RPM;
        private double _Fuel;
        private double _Temperature;
        private double _Oil;
        private double _BatteryLevel;

        public InstrumentClusterSkin()
        {
            Initialized += new EventHandler(Skin_Initialized);
        }

        void Skin_Initialized(object sender, EventArgs e)
        {
            uxSettings = FindName("uxSettings") as Button;
            uxLeftTurn = FindName("uxLeftTurn") as Blinker;
            uxRightTurn = FindName("uxRightTurn") as Blinker;
            uxLowFuel = FindName("uxLowFuel") as FrameworkElement;
            uxHazard = FindName("uxHazard") as FrameworkElement;
            uxMalfunction = FindName("uxMalfunction") as FrameworkElement;
            uxOpenDoor = FindName("uxOpenDoor") as FrameworkElement;
            uxMessage = FindName("uxMessage") as TextBlock;
            uxMessageMarquee = FindName("uxMessageMarquee") as Marquee;
            uxOdometer = FindName("uxOdometer") as TextBlock;
            uxMPG = FindName("uxMPG") as TextBlock;
            uxMPH = FindName("uxMPH") as Slider;
            uxRPM = FindName("uxRPM") as Slider;
            uxFuel = FindName("uxFuel") as Slider;
            uxTemp = FindName("uxTemp") as Slider;
            uxOil = FindName("uxOil") as Slider;
            uxBattery = FindName("uxBattery") as Slider;
            uxMPHLabel = FindName("uxMPHLabel") as TextBlock;
            uxRPMLabel = FindName("uxRPMLabel") as TextBlock;
        }

        public bool IsLeftTurnBlinkerVisible
        {
            get { return _IsLeftTurnBlinkerVisible; }
            set
            {
                _IsLeftTurnBlinkerVisible = value;
                if (uxLeftTurn != null) uxLeftTurn.Visibility = value ? Visibility.Visible : Visibility.Hidden;
            }
        }

        public bool IsRightTurnBlinkerVisible
        {
            get { return _IsRightTurnBlinkerVisible; }
            set
            {
                _IsRightTurnBlinkerVisible = value;
                if (uxRightTurn != null) uxRightTurn.Visibility = value ? Visibility.Visible : Visibility.Hidden;
            }
        }

        public bool IsLowFuelVisible
        {
            get { return _IsLowFuelVisible; }
            set
            {
                _IsLowFuelVisible = value;
                if (uxLowFuel != null) uxLowFuel.Visibility = value ? Visibility.Visible : Visibility.Hidden;
                if (uxFuel != null) uxFuel.IsEnabled = !value;
            }
        }

        public bool IsHazardVisible
        {
            get { return _IsHazardVisible; }
            set
            {
                _IsHazardVisible = value;
                if (uxHazard != null) uxHazard.Visibility = value ? Visibility.Visible : Visibility.Hidden;
            }
        }

        public bool IsMalfunctionVisible
        {
            get { return _IsMalfunctionVisible; }
            set
            {
                _IsMalfunctionVisible = value;
                if(uxMalfunction != null) uxMalfunction.Visibility = value ? Visibility.Visible : Visibility.Hidden;
            }
        }

        public bool IsOpenDoorVisible
        {
            get { return _IsOpenDoorVisible; }
            set
            {
                _IsOpenDoorVisible = value;
                if (uxOpenDoor != null) uxOpenDoor.Visibility = value ? Visibility.Visible : Visibility.Hidden;
            }
        }

        public string Message
        {
            get { return _Message; }
            set
            {
                _Message = value;
                if (uxMessage != null) uxMessage.Text = value;
                if (uxMessageMarquee != null) uxMessageMarquee.Text = value;
            }
        }

        public double Mileage
        {
            get { return _Mileage; }
            set
            {
                _Mileage = value;
                if (uxOdometer != null) uxOdometer.Text = Math.Floor(value).ToString();
            }
        }

        public double MPG
        {
            get { return _MPG; }
            set
            {
                _MPG = value;
                if (uxMPG != null) uxMPG.Text = Math.Round(value).ToString();
            }
        }

        public double MPH { get { return _MPH; } 
            set {
                _MPH = value;
                if(uxMPH != null) uxMPH.Value = value;
                if (uxMPHLabel != null) uxMPHLabel.Text = Math.Ceiling(value).ToString();
            }
        }

        public double RPM { get { return _RPM; } 
            set {
                _RPM = value;
                if (uxRPM != null) uxRPM.Value = value;
                if (uxRPMLabel != null) uxRPMLabel.Text = Math.Ceiling(value).ToString();
            }
        }

        public double Fuel
        {
            get { return _Fuel; }
            set
            {
                _Fuel = value;
                if (uxFuel != null) uxFuel.Value = value;
                IsLowFuelVisible = value < 10;
            }
        }

        public double Temperature
        {
            get { return _Temperature; }
            set
            {
                _Temperature = value;
                if (uxTemp != null) uxTemp.Value = value;
            }
        }

        public double Oil
        {
            get { return _Oil; }
            set
            {
                _Oil = value;
                if (uxOil != null) uxOil.Value = value;
            }
        }

        public double BatteryLevel
        {
            get { return _BatteryLevel; }
            set
            {
                _BatteryLevel = value;
                if (uxBattery != null) uxBattery.Value = value;
            }
        }
    }
}
