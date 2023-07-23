using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using UndoAssessment.Services;
using UndoAssessment.Views;
using UndoAssessment.Models;

namespace UndoAssessment
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            DependencyService.Register<IDataStore<Item>, MockDataStore>();
            DependencyService.Register<IDataStore<User>, MockUsersDataStore>();
            DependencyService.Register<ApiService>();
            DependencyService.Register<MessageService>();
            MainPage = new AppShell();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

