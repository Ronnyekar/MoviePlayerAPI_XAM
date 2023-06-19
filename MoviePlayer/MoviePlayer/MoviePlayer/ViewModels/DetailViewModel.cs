using MoviePlayer.Models;
using MoviePlayer.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoviePlayer.ViewModels
{
    public class DetailViewModel : BaseViewModel
    {
        private Movie selectedMovie;
        public Movie SelectedMovie
        {
            get { return selectedMovie; }
            set
            {
                selectedMovie = value;
                OnPropertyChanged();
            }
        }

        public ICommand PlayCommand => new Command(() =>
        {
            var vm = new PlayerViewModel { SelectedMovie = selectedMovie };
            var page = new PlayerMoviePage { BindingContext = vm };
            Application.Current.MainPage.Navigation.PushAsync(page);
        });
    }
}
