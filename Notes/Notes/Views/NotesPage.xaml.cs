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

        async void OnPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hunger());
        }
    }
}