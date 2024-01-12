using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobid24;

public partial class SearchPage : ContentPage
{
    public SearchPage()
    {
        InitializeComponent();
    }

    private void home(object sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
    }
    
    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        // Runde den Slider-Wert auf das nächste Vielfache von 10.000
        double roundedValue = Math.Round(e.NewValue / 10000) * 10000;
        
        // Setze den gerundeten Wert zurück auf den Slider
        slider.Value = roundedValue;

        // Aktualisiere die Anzeige
        displayLabel.Text = $"Kilometer bis {roundedValue:F0}";
    }
    private void Slider_ValueChanged1(object sender, ValueChangedEventArgs e)
    {
        // Runde den Slider-Wert auf das nächste Vielfache von 10.000
        double roundedValue1 = Math.Round(e.NewValue / 10000) * 10000;
        
        // Setze den gerundeten Wert zurück auf den Slider
        slider1.Value = roundedValue1;

        // Aktualisiere die Anzeige
        displayLabel1.Text = $"Preis bis {roundedValue1:F0}";
    }

    private void OnAnzeigenClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new ResultsPage();
    }
    
    private void OnVerkaufClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new VerkaufPage();
    }
    private void OnUnsClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new ueber_uns();
    }
    private void OnHomeClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
    }
}