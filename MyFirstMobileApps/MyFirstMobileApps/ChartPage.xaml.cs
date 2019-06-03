using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Entry = Microcharts.Entry;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SkiaSharp;
using Microcharts;

namespace MyFirstMobileApps
{
    public class Flashdisk
    {
        public string Name { get; set; }
        public int Price { get; set; }
    } 

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChartPage : ContentPage
	{
        private const string url = "https://www.enterkomputer.com/api/product/flashdisk.json";
        private HttpClient client = new HttpClient();
        private ObservableCollection<Flashdisk> flashdisks;

        public ChartPage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var content = await client.GetStringAsync(url);
            flashdisks = new ObservableCollection<Flashdisk>(JsonConvert.DeserializeObject<List<Flashdisk>>(content));

            var entries = new Entry[] 
            {
                new Entry(flashdisks[0].Price)
                {
                    Label = flashdisks[0].Name,
                    ValueLabel = flashdisks[0].Price.ToString(),
                    Color = SKColor.Parse("#34495e")
                },
                new Entry(flashdisks[1].Price)
                {
                    Label = flashdisks[1].Name,
                    ValueLabel = flashdisks[1].Price.ToString(),
                    Color = SKColor.Parse("#34495e")
                },
                new Entry(flashdisks[2].Price)
                {
                    Label = flashdisks[2].Name,
                    ValueLabel = flashdisks[2].Price.ToString(),
                    Color = SKColor.Parse("#34495e")
                },
                new Entry(flashdisks[3].Price)
                {
                    Label = flashdisks[3].Name,
                    ValueLabel = flashdisks[3].Price.ToString(),
                    Color = SKColor.Parse("#34495e")
                },
                new Entry(flashdisks[4].Price)
                {
                    Label = flashdisks[4].Name,
                    ValueLabel = flashdisks[4].Price.ToString(),
                    Color = SKColor.Parse("#34495e")
                }
            };

            var chart = new BarChart() { Entries = entries };
            ChartView.Chart = chart;
            
        }
    }
}