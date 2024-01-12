using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobid24;

public partial class VerkaufPage : ContentPage
{
    

    public VerkaufPage()
    {
        InitializeComponent();
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