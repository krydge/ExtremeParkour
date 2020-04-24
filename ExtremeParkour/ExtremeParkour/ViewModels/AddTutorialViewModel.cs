using ExtremeParkour.Services;
using ExtremeParkour.Shared;
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

        private readonly IExtremeParkourService extremeParkourService;
        VideoTutorialData tutorial;
        
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

        private byte[] fileData;

        private string vFText;
        public string VFText
        {
            get => vFText;
            set { SetProperty(ref vFText, value); }
        }

        private string vFText2;
        public string VFText2
        {
            get => vFText2;
            set { SetProperty(ref vFText2, value); }
        }

        private string vFText3;
        public string VFText3
        {
            get => vFText3;
            set { SetProperty(ref vFText3, value); }
        }

        public AddTutorialViewModel(INavigationService navigationService, IExtremeParkourService extremeParkourService)
            : base(navigationService)
        {
            this.extremeParkourService = extremeParkourService;
            tutorial = new VideoTutorialData();
            Title = "Add Video Tutotrial";
            VFText = "Null";
            VFText2 = "Null";
            VFText3 = "Null";
        }

        public Command addToTutorials;
        public Command AddToTutorials => addToTutorials ?? (addToTutorials = new Command(async () =>
        {
            tutorial.Title = VideoTitle;
            tutorial.Description = Description;
            tutorial.UserLevel = UserLevel;
            tutorial.Focus = Focus;
            tutorial.Image = fileData;
            tutorial.ImageName = VFText2;
            tutorial.VideoSource = VFText;
            await extremeParkourService.AddTutorial(tutorial);
        }));

        public Command chooseImage;

        public Command ChooseImage => chooseImage ?? (chooseImage = new Command(async () =>
        {
            var file = await CrossFilePicker.Current.PickFile();

            if (file != null)
            {
                fileData = file.DataArray;
                VFText2 = file.FileName;
                VFText3 = file.FileName.Length <= 20 ? file.FileName : file.FileName.Substring(0, 17) + "...";
            }
        }));
    }
}

