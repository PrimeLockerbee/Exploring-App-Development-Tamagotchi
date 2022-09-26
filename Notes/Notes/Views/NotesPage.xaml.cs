using System;
using System.IO;
using Xamarin.Forms;

namespace Notes.Views
{
    public partial class NotesPage : ContentPage
    {
        public NotesPage()
        {
            InitializeComponent();
        }

        async void OnBoredomButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Boredom());
        }

        async void OnEnergyButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Energy());
        }

        async void OnHungerButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hunger());
        }

        async void OnSocialButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Social());
        }

        async void OnStimulusButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Stimulus());
        }

        async void OnThirstButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Thirst());
        }
    }
}