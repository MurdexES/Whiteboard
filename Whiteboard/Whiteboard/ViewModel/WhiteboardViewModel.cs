using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whiteboard.Services.Interfaces;

namespace Whiteboard.ViewModel
{
    public class WhiteboardViewModel : ViewModelBase
    {
        private readonly IMyNavigationService _myNavigationService;

        public string ProjectName { get; set; } = string.Empty;

        public WhiteboardViewModel(IMyNavigationService myNavigationService)
        {
            _myNavigationService = myNavigationService;
        }

        public RelayCommand OpenCommand
        {
            get => new(() =>
            {

            });
        }

        public RelayCommand SaveCommand
        {
            get => new(() =>
            {

            });
        }

        public RelayCommand ExportCommand
        {
            get => new(() =>
            {

            });
        }

        public RelayCommand SendCommand
        {
            get => new(() =>
            {

            });
        }

        public RelayCommand PrintCommand
        {
            get => new(() =>
            {

            });
        }
    }
}
