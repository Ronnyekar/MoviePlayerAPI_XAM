using MediaManager;
using MoviePlayer.Services;
using MoviePlayer.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoviePlayer
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            CrossMediaManager.Current.Init();
            MainPage = new NavigationPage(new WatchListPage ());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
