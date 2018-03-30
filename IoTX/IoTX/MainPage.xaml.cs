using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IoTX
{
	public partial class MainPage : ContentPage
	{
        private string connectionString;

		public MainPage()
		{
			InitializeComponent();
		}

        private async void ClickedHandler(object sender, EventArgs e)
        {
            IoT instance = new IoT(connectionString);
            await instance.SendMessage("HEHE IT WORKS!");
        }

    }
}
