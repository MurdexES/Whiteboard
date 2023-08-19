﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Whiteboard.Services.Interfaces;
using Whiteboard.Model;
using System.Windows;

namespace Whiteboard.ViewModel
{
    public class WhiteboardViewModel : ViewModelBase
    {
        private readonly IMyNavigationService _myNavigationService;
        private readonly IUserManageService _userManageService;
        private readonly IProjectManageService _projectManageService;

        public string ProjectName { get; set; } = string.Empty;

        public WhiteboardViewModel(IMyNavigationService myNavigationService, IUserManageService userManageService, IProjectManageService projectManageService)
        {
            _myNavigationService = myNavigationService;
            _userManageService = userManageService;
            _projectManageService = projectManageService;
        }

        public RelayCommand<Canvas> OpenCommand
        {
            get => new(canvas =>
            {
                if(ProjectName != string.Empty)
                {
                    _projectManageService.AddProject(canvas, ProjectName);

                    _myNavigationService.NavigateWarning<HomeViewModel>(true);
                    _myNavigationService.NavigateTo<HomeViewModel>();
                }
                else
                {
                    MessageBox.Show("You did not enter the project name!!!");
                }
            });
        }

        public RelayCommand SaveCommand
        {
            get => new(() =>
            {

            });
        }

        public RelayCommand<Canvas> ExportCommand
        {
            get => new(param =>
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Images (*.png)|*.png|JPEG Images (*.jpg)|*.jpg|All Files (*.*)|*.*";
                
                if (saveFileDialog.ShowDialog() == true)
                {
                    string filePath = saveFileDialog.FileName;

                    RenderTargetBitmap renderBitmap = new RenderTargetBitmap((int)param.ActualWidth, (int)param.ActualHeight, 96, 96, PixelFormats.Pbgra32);
                    renderBitmap.Render(param);

                    BitmapEncoder encoder = null;

                    if (filePath.EndsWith(".png"))
                    {
                        encoder = new PngBitmapEncoder();
                    }
                    else if (filePath.EndsWith(".jpg"))
                    {
                        encoder = new JpegBitmapEncoder();
                    }

                    if (encoder != null)
                    {
                        encoder.Frames.Add(BitmapFrame.Create(renderBitmap));
                        
                        using (FileStream fs = new FileStream(filePath, FileMode.Create))
                        {
                            encoder.Save(fs);
                        }
                    }
                }
            });
        }

        public RelayCommand SendCommand
        {
            get => new(() =>
            {

            });
        }

        public RelayCommand<Canvas> PrintCommand
        {
            get => new(canvas =>
            {
                PrintDialog printDialog = new();
                
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(canvas, "Canvas Print");
                }
            });
        }
    }
}
