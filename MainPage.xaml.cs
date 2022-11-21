using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace MauiMapTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();

        var pinLocation = new Location(20.7557, -155.9880);
        
        MapSpan mapSpan = MapSpan.FromCenterAndRadius(pinLocation, Distance.FromKilometers(3));
        map.MoveToRegion(mapSpan);
        map.Pins.Add(new Pin
        {
            Label = "MAUI Test Pin",
            Location = pinLocation
        });
    }

    async void OnMapClicked(object sender, MapClickedEventArgs e)
    {
        await DisplayAlert("Map", $"Area {e.Location.Latitude}, {e.Location.Longitude} clicked.", "Ok");
    }
}

