using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whiteboard.Model;
using Whiteboard.Services.Interfaces;

namespace Whiteboard.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        public ObservableCollection<SketchModel> Projects { get; set; } = new ObservableCollection<SketchModel>();

        private readonly IMessenger _messenger;
        private readonly IMyNavigationService _myNavigationService;

        public HomeViewModel(IMessenger messenger, IMyNavigationService myNavigationService)
        {
            _messenger = messenger;
            _myNavigationService = myNavigationService;
        }

        public RelayCommand AddProjectCommand
        {
            get => new(() =>
            {
                _myNavigationService.NavigateTo<WhiteboardViewModel>();
            });
        }
    }
}
