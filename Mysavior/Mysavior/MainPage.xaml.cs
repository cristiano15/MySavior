using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mysavior
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
            Browser.HeightRequest = 1000;
            Browser.WidthRequest = 1000;
            Browser.Source = "https://mysavior.com.br";

        }

    }
	
}
