﻿using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whiteboard.Services.Interfaces;
using Whiteboard.Services.Messages;

namespace Whiteboard.Services.Classes
{
    internal class MyNavigationService : IMyNavigationSevice
    {
        private readonly IMessenger _messenger;

        public MyNavigationService(IMessenger messenger)
        {
            _messenger = messenger;
        }

        public void NavigateTo<T>(object? data = null) where T : ViewModelBase
        {
            _messenger.Send(new NavigationMessage()
            {
                ViewModelType = typeof(T)
            });

            if (data != null)
            {
                _messenger.Send(new DataMessages()
                {
                    Data = data
                });
            }
        }
    }
}
