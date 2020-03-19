using ExtremeParkour.Services;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExtremeParkour.Views
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        protected async override void OnAppearing() 
        {
            base.OnAppearing();
            await CallApi();
        }

        async Task CallApi()
        {
            var nsAPI = RestService.For<IWeatherForecastApi>("http://localhost:5001");
            var sugars = await nsAPI.GetForecastAsync();
        }
    }
}