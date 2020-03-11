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
    public class AddTutorialViewModel : ViewModelBase
    {
        public AddTutorialViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Add Video Tutotrial";
        }

        public Command addToTutorials;
        public Command AddToTutorials => addToTutorials ?? (addToTutorials = new Command( () =>
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
