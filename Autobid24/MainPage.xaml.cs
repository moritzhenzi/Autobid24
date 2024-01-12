using Microsoft.Maui.Controls;
using System;
using System.Text.RegularExpressions;

namespace Autobid24
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new SearchPage();
        }
        
        private void OnUnsClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ueber_uns();
        }

        private void OnSubscribeClicked(object sender, EventArgs e)
        {
            // Validiere die E-Mail-Adresse
            string email = EmailEntry.Text.Trim();
            if (IsValidEmail(email))
            {
                // Hier kannst du die Logik für das tatsächliche Abonnieren des Newsletters hinzufügen
                DisplayAlert("Success", $"Subscribed with email: {email}", "OK");
            }
            else
            {
                DisplayAlert("Error", "Please enter a valid email address.", "OK");
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                // Verwende eine einfache Regex für grundlegende E-Mail-Validierung
                var regex = new Regex(@"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$");
                return regex.IsMatch(email);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        
        private void OnVerkaufClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new VerkaufPage();
        }
        
        private void OnHomeClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
        private void OnACCClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new AccountPage();
        }
        
        private void oninfoclicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Infopage();
        }
        private void onFAQClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new FAQPage();
        }

    }
}