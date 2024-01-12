using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobid24;

public partial class CarPage : ContentPage
{
    private void OnHomeClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
    }
    public ObservableCollection<string> ImageList { get; set; }
    public CarPage()
    {
        InitializeComponent();
        
        ImageList = new ObservableCollection<string>
        {
            "bmw1bild.png",
            "bmw2bild.png",
            "bmw3bild.png",
            "bmw4bild.png"
            // Fügen Sie hier weitere Bild-URLs hinzu
        };
        
        carouselView.ItemsSource = ImageList;
        
    }
}