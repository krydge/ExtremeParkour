using ExtremeParkour.Data;
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
    public class WorkoutsPageViewModel : ViewModelBase
    {

        private List<WorkoutData> workouts;
        public List<WorkoutData> Workouts
        {
            get => workouts;
            set { SetProperty(ref workouts, value); }
        }


        public WorkoutsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

            Title = "WorkoutPage";

            Workouts = new List<WorkoutData>();

            var tutorial1 = new WorkoutData
            {
                VideoSource = "null1",
                Source = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video1",
                Description = "This is to workout",
                Difficulty = "Beginner"
            };

            Workouts.Add(tutorial1);

            var tutorial2 = new WorkoutData
            {
                VideoSource = "null2",
                Source = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video2",
                Description = "This is to workout",
                Difficulty = "Intermediate"
            };

            Workouts.Add(tutorial2);

            var tutorial3 = new WorkoutData
            {
                VideoSource = "null3",
                Source = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video3",
                Description = "This is to workout",
                Difficulty = "Hard"
            };

            Workouts.Add(tutorial3);

            var tutorial4 = new WorkoutData
            {
                VideoSource = "null4",
                Source = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video4",
                Description = "This is to workout",
                Difficulty = "Master"
            };

            Workouts.Add(tutorial4);

            var tutorial5 = new WorkoutData
            {
                VideoSource = "null5",
                Source = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video5",
                Description = "This is to workout",
                Difficulty = "Beginner"
            };

            Workouts.Add(tutorial5);

            var tutorial6 = new WorkoutData
            {
                VideoSource = "null6",
                Source = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video6",
                Description = "This is to workout",
                Difficulty = "Intermediate"
            };

            Workouts.Add(tutorial6);

            var tutorial7 = new WorkoutData
            {
                VideoSource = "null7",
                Source = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video7",
                Description = "This is to workout",
                Difficulty = "Hard"
            };

            Workouts.Add(tutorial7);

            var tutorial8 = new WorkoutData
            {
                VideoSource = "null8",
                Source = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video8",
                Description = "This is to workout",
                Difficulty = "Master"
            };

            Workouts.Add(tutorial8);
        }


        private DelegateCommand<WorkoutData> itemTappedCommand;

        public DelegateCommand<WorkoutData> ItemTappedCommand => itemTappedCommand ?? (itemTappedCommand = new DelegateCommand<WorkoutData>(ExecuteItemTappedCommand));

        public void ExecuteItemTappedCommand(WorkoutData selectedWorkout)
        {
            NavigationParameters Parameters = new NavigationParameters
            {
                { "workout", selectedWorkout }
            };
            TestableNavigation.TestableNavigateAsync(NavigationService, nameof(Views.WorkoutDetailPage), Parameters, false, true).ConfigureAwait(false);

        }  
    }
}
