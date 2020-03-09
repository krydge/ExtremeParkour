﻿using ExtremeParkour.Data;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtremeParkour.ViewModels
{
    public class VideoTutorialDetailPageViewModel : ViewModelBase
    {
        public VideoTutorialDetailPageViewModel(INavigationService navigationService)
            :base(navigationService)
        {
            Title = "Video Tutorial Details";
        }

        public VideoTutorialData Tutorial { get; private set; }

        private string tutorialName;
        public string TutorialName
        {
            get => tutorialName;
            set { SetProperty(ref tutorialName, value); }
        }

        private string focus;
        public string Focus
        {
            get => focus;
            set { SetProperty(ref focus, value); }
        }

        private string description;
        public string Description
        {
            get => description;
            set { SetProperty(ref description, value); }
        }

        private string userLevel;
        public string UserLevel
        {
            get => userLevel;
            set { SetProperty(ref userLevel, value); }
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Tutorial = (VideoTutorialData)parameters["tutorial"];

            if (Tutorial == null)
            {
                TestableNavigation.TestableGoBackAsync(NavigationService);
            }
            else
            {
                TutorialName = Tutorial.Title;
                Focus = Tutorial.Focus;
                Description = Tutorial.Description;
                UserLevel = Tutorial.UserLevel;
            }
        }
    }
}