using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobid24;

public partial class ResultsPage : ContentPage
{
    public ResultsPage()
    {
        InitializeComponent();
    }

    private void OnMehrClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new CarPage();
    }
    
    private void OnVerkaufClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new VerkaufPage();
    }
    
    private void OnUnsClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new ueber_uns();
    }
    private void OnSearchClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new SearchPage();
    }
    private void OnHomeClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
    }
}