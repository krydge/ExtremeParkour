using ExtremeParkour.Data;
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
    public class WorkoutsPageViewModel : ViewModelBase
    {
        private WDAppSide workout;

        private List<WorkoutData> workoutVideos;

        private List<WDAppSide> workouts;
        public List<WDAppSide> Workouts
        {
            get => workouts;
            set { SetProperty(ref workouts, value); }
        }


        public WorkoutsPageViewModel(INavigationService navigationService, IExtremeParkourService extremeParkourService)
            : base(navigationService)
        {

            Title = "WorkoutPage";

            Workouts = new List<WDAppSide>();

            

            workoutVideos = (List<WorkoutData>)extremeParkourService.GetWorkoutsAsync().Result;

            foreach (var i in workoutVideos)
            {
                workout = new WDAppSide();
                workout.Description = i.Description;
                workout.Difficulty = i.Difficulty;
                workout.imageSource = ImageSource.FromResource(i.Source);
                workout.Title = i.Title;
                workout.VideoSource = i.VideoSource;

                Workouts.Add(workout);
            }

            /*var tutorial1 = new WDAppSide
            {
                VideoSource = "null1",
                Source = "ExtremeParkour.Images.black-square.png",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video1",
                Description = "This is to workout",
                Difficulty = "Beginner"
            };

            Workouts.Add(tutorial1);

            var tutorial2 = new WDAppSide
            {
                VideoSource = "null2",
                Source = "ExtremeParkour.Images.black-square.png",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video2",
                Description = "This is to workout",
                Difficulty = "Intermediate"
            };

            Workouts.Add(tutorial2);

            var tutorial3 = new WDAppSide
            {
                VideoSource = "null3",
                Source = "ExtremeParkour.Images.black-square.png",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video3",
                Description = "This is to workout",
                Difficulty = "Hard"
            };

            Workouts.Add(tutorial3);

            var tutorial4 = new WDAppSide
            {
                VideoSource = "null4",
                Source = "ExtremeParkour.Images.black-square.png",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video4",
                Description = "This is to workout",
                Difficulty = "Master"
            };

            Workouts.Add(tutorial4);

            var tutorial5 = new WDAppSide
            {
                VideoSource = "null5",
                Source = "ExtremeParkour.Images.black-square.png",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video5",
                Description = "This is to workout",
                Difficulty = "Beginner"
            };

            Workouts.Add(tutorial5);

            var tutorial6 = new WDAppSide
            {
                VideoSource = "null6",
                Source = "ExtremeParkour.Images.black-square.png",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video6",
                Description = "This is to workout",
                Difficulty = "Intermediate"
            };

            Workouts.Add(tutorial6);

            var tutorial7 = new WDAppSide
            {
                VideoSource = "null7",
                Source = "ExtremeParkour.Images.black-square.png",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video7",
                Description = "This is to workout",
                Difficulty = "Hard"
            };

            Workouts.Add(tutorial7);

            var tutorial8 = new WDAppSide
            {
                VideoSource = "null8",
                Source = "ExtremeParkour.Images.black-square.png",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.black-square.png"),
                Title = "Test Video8",
                Description = "This is to workout",
                Difficulty = "Master"
            };

            Workouts.Add(tutorial8);*/
        }


        private DelegateCommand<WDAppSide> itemTappedCommand;

        public DelegateCommand<WDAppSide> ItemTappedCommand => itemTappedCommand ?? (itemTappedCommand = new DelegateCommand<WDAppSide>(ExecuteItemTappedCommand));

        public void ExecuteItemTappedCommand(WDAppSide selectedWorkout)
        {
            NavigationParameters Parameters = new NavigationParameters
            {
                { "workout", selectedWorkout }
            };
            TestableNavigation.TestableNavigateAsync(NavigationService, nameof(Views.WorkoutDetailPage), Parameters, false, true).ConfigureAwait(false);

        }  
    }
}
