using System;
using Coding4Fun.Obd.InstrumentCluster.Classes;

namespace Coding4Fun.Obd.InstrumentCluster.Controls.SkinMetro
{
	/// <summary>
	/// Interaction logic for Skin.xaml
	/// </summary>
	public partial class Skin : InstrumentClusterSkin
	{
        private double _MPG;
        private double _Mileage;

		public Skin()
		{
			this.InitializeComponent();
		}

        new public double MPG
        {
            get { return _MPG; }
            set
            {
                _MPG = value;
                if (uxMPG != null) uxMPG.Text = String.Format("{0:0.0}", value);
            }
        }

        new public double Mileage
        {
            get { return _Mileage; }
            set
            {
                _Mileage = value;
                if (uxOdometer != null) uxOdometer.Text = String.Format("{0:0,0.0}", value);
            }
        }

	}
}