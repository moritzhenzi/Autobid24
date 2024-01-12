using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autobid24;

public partial class FAQPage : ContentPage
{
    public FAQPage()
    {
        InitializeComponent();
    }
    private void OnHomeClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
    }
}