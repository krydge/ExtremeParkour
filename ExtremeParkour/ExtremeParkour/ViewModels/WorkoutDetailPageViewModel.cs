using ExtremeParkour.Data;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtremeParkour.ViewModels
{
    public class WorkoutDetailPageViewModel : ViewModelBase
    {
        public WorkoutDetailPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Workout Detail Page";
        }

        public WorkoutData Workout { get; private set; }

        private string workoutName;
        public string WorkoutName
        {
            get => workoutName;
            set { SetProperty(ref workoutName, value); }
        }

        private string description;
        public string Description
        {
            get => description;
            set { SetProperty(ref description, value); }
        }

        private string difficulty;
        public string Difficulty
        {
            get => difficulty;
            set { SetProperty(ref difficulty, value); }
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Workout = (WorkoutData)parameters["workout"];

            if (Workout == null)
            {
                TestableNavigation.TestableGoBackAsync(NavigationService);
            }
            else
            {
                WorkoutName = Workout.Title;
                Description = Workout.Description;
                Difficulty = Workout.Difficulty;
            }
        }
    }
}
