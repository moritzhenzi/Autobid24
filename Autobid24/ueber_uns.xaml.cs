using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobid24;

public partial class ueber_uns : ContentPage
{
    public ueber_uns()
    {
        InitializeComponent();
    }
    
    private void OnVerkaufClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new VerkaufPage();
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