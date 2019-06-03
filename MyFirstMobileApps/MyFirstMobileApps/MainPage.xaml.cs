using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFirstMobileApps
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void Tictactoe_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TictactoePage());
        }

        async private void Chart_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChartPage());
        }
    }
}
