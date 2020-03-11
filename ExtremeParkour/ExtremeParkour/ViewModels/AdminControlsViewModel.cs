using Plugin.FilePicker;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ExtremeParkour.ViewModels
{
    public class AdminControlsViewModel : ViewModelBase
    {
        public AdminControlsViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Admin Page";
        }

    }
}
