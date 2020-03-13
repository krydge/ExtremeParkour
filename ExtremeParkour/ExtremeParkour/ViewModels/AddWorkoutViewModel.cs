﻿using Plugin.FilePicker;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ExtremeParkour.ViewModels
{
    public class AddWorkoutViewModel : ViewModelBase
    {
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

        public AddWorkoutViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Add Workout";
            VFText = "Null";
            VFText2 = "Null";
        }

        public Command addToWorkouts;
        public Command AddToWorkouts => addToWorkouts ?? (addToWorkouts = new Command(() =>
        {

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
                VFText2 = file.FileName.Length <= 2 ? file.FileName : file.FileName.Substring(0, 17) + "...";
            }
        }));
    }
}
