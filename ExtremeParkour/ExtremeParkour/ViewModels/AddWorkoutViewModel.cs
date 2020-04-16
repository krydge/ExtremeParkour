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
    public class AddWorkoutViewModel : ViewModelBase
    {
        private readonly IExtremeParkourService extremeParkourService;
        WorkoutData workout;
        string workoutTitle;
        public string WorkoutTitle
        {
            get => workoutTitle;
            set { SetProperty(ref workoutTitle, value); }
        }
        string description;
        public string Description
        {
            get => description;
            set { SetProperty(ref description, value); }
        }
        string difficulty;
        public string Difficulty
        {
            get => difficulty;
            set { SetProperty(ref difficulty, value); }
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

        public AddWorkoutViewModel(INavigationService navigationService, IExtremeParkourService extremeParkourService)
            : base(navigationService)
        {
            this.extremeParkourService = extremeParkourService;
            workout = new WorkoutData();
            Title = "Add Workout";
            VFText = "Null";
            VFText2 = "Null";
        }

        public Command addToWorkouts;
        public Command AddToWorkouts => addToWorkouts ?? (addToWorkouts = new Command(async () =>
        {
            workout.Title = WorkoutTitle;
            workout.Description = Description;
            workout.Difficulty = Difficulty;
            workout.Image = fileData2;
            workout.ImageName = VFText2;
            workout.Video = fileData1;
            workout.VideoName = VFText;
            await extremeParkourService.AddWorkout(workout);
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
