using MoviePlayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlayer.ViewModels
{
    public class PlayerViewModel : BaseViewModel 
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
    }
}
