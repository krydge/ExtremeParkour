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
            workout.Image = fileData;
            workout.ImageName = VFText2;
            workout.VideoSource = VFText;
            await extremeParkourService.AddWorkout(workout);
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
