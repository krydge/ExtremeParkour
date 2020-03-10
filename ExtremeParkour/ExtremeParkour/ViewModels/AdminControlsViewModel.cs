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

        public Command addToWorkouts;
        public Command AddToWorkouts => addToWorkouts ?? (addToWorkouts = new Command(async () =>
        {
           
        }));
        public Command addToTutorials;
        public Command AddToTutorials => addToTutorials ?? (addToTutorials = new Command(async () =>
        {

        }));
        public Command chooseVideo;
        public Command ChooseVideo => chooseVideo ?? (chooseVideo = new Command(async () =>
        {
            var file = await CrossFilePicker.Current.PickFile();

            if (file != null)
            {
                //lbl.Text = file.FileName;
            }
        }));
        public Command chooseImage;
        public Command ChooseImage => chooseImage ?? (chooseImage = new Command(async () =>
        {
            var file = await CrossFilePicker.Current.PickFile();

            if (file != null)
            {
                //lbl.Text = file.FileName;
            }
        }));
    }
}
