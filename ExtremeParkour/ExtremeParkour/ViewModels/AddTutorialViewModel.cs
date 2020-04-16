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

        private byte[] fileData1;
        private byte[] fileData2;

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

        public AddTutorialViewModel(INavigationService navigationService, IExtremeParkourService extremeParkourService)
            : base(navigationService)
        {
            this.extremeParkourService = extremeParkourService;
            tutorial = new VideoTutorialData();
            Title = "Add Video Tutotrial";
            VFText = "Null";
            VFText2 = "Null";
        }

        public Command addToTutorials;
        public Command AddToTutorials => addToTutorials ?? (addToTutorials = new Command(async () =>
        {
            tutorial.Title = VideoTitle;
            tutorial.Description = Description;
            tutorial.UserLevel = UserLevel;
            tutorial.Focus = Focus;
            tutorial.Image = fileData2;
            tutorial.ImageName = VFText2;
            tutorial.Video = fileData1;
            tutorial.VideoName = VFText;
            await extremeParkourService.AddTutorial(tutorial);
        }));
        public Command chooseVideo;
        public Command ChooseVideo => chooseVideo ?? (chooseVideo = new Command(async () =>
        {
            var file = await CrossFilePicker.Current.PickFile();

            if (file != null)
            {
                fileData1 = file.DataArray;
                VFText = file.FileName.Length <= 20 ? file.FileName : file.FileName.Substring(0, 17) + "...";
            }
        }));
        public Command chooseImage;

        public Command ChooseImage => chooseImage ?? (chooseImage = new Command(async () =>
        {
            var file = await CrossFilePicker.Current.PickFile();

            if (file != null)
            {
                fileData2 = file.DataArray;
                VFText2 = file.FileName.Length <= 20 ? file.FileName : file.FileName.Substring(0, 17) + "...";
            }
        }));
    }
}

