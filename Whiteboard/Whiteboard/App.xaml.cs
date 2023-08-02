using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using Whiteboard.View;
using Whiteboard.ViewModel;

namespace Whiteboard
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; set; } = new();

        protected override void OnStartup(StartupEventArgs e)
        {

            MainStartup();
        }

        private void Register()
        {
            Container.RegisterSingleton<IMessenger, Messenger>();

            Container.RegisterSingleton<MainViewModel>();
        }

        private void MainStartup()
        {
            var mainView = new MainView();
            mainView.DataContext = Container.GetInstance<MainViewModel>();
            mainView.ShowDialog();
        }
    }
}
