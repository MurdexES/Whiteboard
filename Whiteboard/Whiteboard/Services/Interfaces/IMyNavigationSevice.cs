﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard.Services.Interfaces
{
    public interface IMyNavigationSevice
    {
        public void NavigateTo<T>(object? data = null) where T : ViewModelBase;
    }
}