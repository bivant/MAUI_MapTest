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

    void OnBuildClicked(object sender, EventArgs e)
    {
        var pinLocation = new Location(20.7557, -155.9880);
        map.Pins.Add(new Pin
        {
            Label = "MAUI Test Pin",
            Location = pinLocation
        });

        var route = new Polyline()
        {
            StrokeWidth = 8,
            StrokeColor = Color.Parse("#1BA1E2")
        };
        route.Geopath.Add(pinLocation);
        route.Geopath.Add(new Location(20.750561, -155.986836));
        route.Geopath.Add(new Location(20.747872, -155.986332));
        route.Geopath.Add(new Location(20.743709, -155.985872));
        route.Geopath.Add(new Location(20.741195, -155.985788));
        route.Geopath.Add(new Location(20.738743, -155.985399));
        map.MapElements.Add(route);
    }

    void OnClearClicked(object sender, EventArgs e)
    {
        map.Pins.Clear();
        map.MapElements.Clear();
    }
}

