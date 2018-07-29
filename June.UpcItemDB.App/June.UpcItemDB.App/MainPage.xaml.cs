using System;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;
using June.Tools.Functional;
using System.Linq;

namespace June.UpcItemDB.App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ScanButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanPage = new ZXingScannerPage();

                scanPage.OnScanResult += (result) =>
                { // Stop scanning
                    scanPage.IsScanning = false;

                    // Pop the page and show the result
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await Navigation.PopAsync();
                        var data = new UpcItemDBClient(null).LookupBarcode(result.Text);
                        UpdatePage(data.GetResultOrDefault());
                    });
                };
                // Navigate to our scanner page
                await Navigation.PushAsync(scanPage);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Failed:", ex.Message, "OK");
            }
        }

        private void UpdatePage(Item item)
        {
            Title.Text = item?.title;
            Description.Text = item?.description;
            Brand.Text = item?.brand;
            Model.Text = item?.model;
            Color.Text = item?.color;
            Size.Text = item?.size;
            Dimension.Text = item?.dimension;
            Weight.Text = item?.weight;
            if (item == null)
            {
                PriceRange.Text = null;
                Currency.Text = null;
            }
            else
            {
                Currency.Text = string.IsNullOrWhiteSpace(item.currency) ? "USD" : item.currency;
                PriceRange.Text = item.lowest_recorded_price.GetValueOrDefault().ToString("C") + " - " + item.highest_recorded_price.GetValueOrDefault().ToString("C");
            }

            Image.Source = item?.images.FirstOrDefault();
        }
    }
}
