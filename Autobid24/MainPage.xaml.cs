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
            // Implementiere die Logik für die Suche
            DisplayAlert("Info", "Search button clicked!", "OK");
        }

        private void OnSellClicked(object sender, EventArgs e)
        {
            // Implementiere die Logik für das Verkaufen
            DisplayAlert("Info", "Sell button clicked!", "OK");
        }

        private void OnAccountClicked(object sender, EventArgs e)
        {
            // Implementiere die Logik für den Account
            DisplayAlert("Info", "Account button clicked!", "OK");
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

    }
}