using ExtremeParkour.Services;
using ExtremeParkour.Shared;
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

        private readonly IExtremeParkourService extremeParkourService;
        private VideoTutorialData tutorial;
        
        string videoTitle;
        public string VideoTitle
        {
            get => videoTitle;
            set { SetProperty(ref videoTitle, value); }
        }
        string description;
        public string Description
        {
            get => description;
            set { SetProperty(ref description, value); }
        }
        string userLevel;
        public string UserLevel
        {
            get => userLevel;
            set { SetProperty(ref userLevel, value); }
        }
        string focus;
        public string Focus
        {
            get => focus;
            set { SetProperty(ref focus, value); }
        }


        private string vFText;
        public string VFText
        {
            get => vFText;
            set { SetProperty(ref vFText, value); }
        }

        public AddTutorialViewModel(INavigationService navigationService, IExtremeParkourService extremeParkourService)
            : base(navigationService)
        {
            this.extremeParkourService = extremeParkourService;
            tutorial = new VideoTutorialData();
            Title = "Add Video Tutotrial";
        }

        public Command addToTutorials;
        public Command AddToTutorials => addToTutorials ?? (addToTutorials = new Command(async () =>
        {
            tutorial.Title = VideoTitle;
            tutorial.Description = Description;
            tutorial.UserLevel = UserLevel;
            tutorial.Focus = Focus;
            tutorial.Source = "ExtremeParkour.Images.random-image.jpg";
            tutorial.VideoSource = VFText;
            int returning = await extremeParkourService.AddTutorial(tutorial);
        }));

        /*public Command chooseImage;

        public Command ChooseImage => chooseImage ?? (chooseImage = new Command(async () =>
        {
            var file = await CrossFilePicker.Current.PickFile();

            if (file != null)
            {
                fileData = file.DataArray;
                VFText2 = file.FileName;
                VFText3 = file.FileName.Length <= 20 ? file.FileName : file.FileName.Substring(0, 17) + "...";
            }
        }));*/
    }
}

