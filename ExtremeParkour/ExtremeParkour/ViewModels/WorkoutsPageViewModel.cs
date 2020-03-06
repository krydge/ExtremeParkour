﻿using ExtremeParkour.Data;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

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
                Video = "null1",
                Title = "Test Video1",
                Description = "This is to workout",
                Difficulty = "Beginner"
            };

            Workouts.Add(tutorial1);

            var tutorial2 = new WorkoutData
            {
                Video = "null2",
                Title = "Test Video2",
                Description = "This is to workout",
                Difficulty = "Intermediate"
            };

            Workouts.Add(tutorial2);

            var tutorial3 = new WorkoutData
            {
                Video = "null3",
                Title = "Test Video3",
                Description = "This is to workout",
                Difficulty = "Hard"
            };

            Workouts.Add(tutorial3);

            var tutorial4 = new WorkoutData
            {
                Video = "null4",
                Title = "Test Video4",
                Description = "This is to workout",
                Difficulty = "Master"
            };

            Workouts.Add(tutorial4);

            var tutorial5 = new WorkoutData
            {
                Video = "null5",
                Title = "Test Video5",
                Description = "This is to workout",
                Difficulty = "Beginner"
            };

            Workouts.Add(tutorial5);

            var tutorial6 = new WorkoutData
            {
                Video = "null6",
                Title = "Test Video6",
                Description = "This is to workout",
                Difficulty = "Intermediate"
            };

            Workouts.Add(tutorial6);

            var tutorial7 = new WorkoutData
            {
                Video = "null7",
                Title = "Test Video7",
                Description = "This is to workout",
                Difficulty = "Hard"
            };

            Workouts.Add(tutorial7);

            var tutorial8 = new WorkoutData
            {
                Video = "null8",
                Title = "Test Video8",
                Description = "This is to workout",
                Difficulty = "Master"
            };

            Workouts.Add(tutorial8);
        }
    }
}
