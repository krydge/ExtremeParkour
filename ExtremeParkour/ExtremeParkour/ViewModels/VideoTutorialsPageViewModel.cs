using ExtremeParkour.Data;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ExtremeParkour.ViewModels
{
    public class VideoTutorialsPageViewModel : ViewModelBase
    {

        private List<VideoTutorialData> videoTutorials;
        public List<VideoTutorialData> VideoTutorials
        {
            get => videoTutorials;
            set { SetProperty(ref videoTutorials, value); }
        }

        public ImageSource ImageSource => ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg");

        public VideoTutorialsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "VideoTutorialsPage";

            VideoTutorials = new List<VideoTutorialData>();

            var tutorial1 = new VideoTutorialData
            {
                Video = "null1",
                Source= ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Title = "Test Video1",
                Focus = "Jumping1",
                Description = "This is to practice your jumping",
                UserLevel = "Beginner"
            };

            VideoTutorials.Add(tutorial1);

            var tutorial2 = new VideoTutorialData
            {
                Video = "null2",
                Source = ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Title = "Test Video2",
                Focus = "Jumping2",
                Description = "This is to practice your jumping",
                UserLevel = "Intermediate"
            };

            VideoTutorials.Add(tutorial2);

            var tutorial3 = new VideoTutorialData
            {
                Video = "null3",
                Source = ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Title = "Test Video3",
                Focus = "Jumping3",
                Description = "This is to practice your jumping",
                UserLevel = "Hard"
            };

            VideoTutorials.Add(tutorial3);

            var tutorial4 = new VideoTutorialData
            {
                Video = "null4",
                Title = "Test Video4",
                Source = ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Focus = "Jumping4",
                Description = "This is to practice your jumping",
                UserLevel = "Master"
            };

            VideoTutorials.Add(tutorial4);

            var tutorial5 = new VideoTutorialData
            {
                Video = "null5",
                Source = ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Title = "Test Video5",
                Focus = "Jumping5",
                Description = "This is to practice your jumping",
                UserLevel = "Beginner"
            };

            VideoTutorials.Add(tutorial5);

            var tutorial6 = new VideoTutorialData
            {
                Video = "null6",
                Title = "Test Video6",
                Source = ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Focus = "Jumping6",
                Description = "This is to practice your jumping",
                UserLevel = "Intermediate"
            };

            VideoTutorials.Add(tutorial6);

            var tutorial7 = new VideoTutorialData
            {
                Video = "null7",
                Title = "Test Video7",
                Source = ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Focus = "Jumping7",
                Description = "This is to practice your jumping",
                UserLevel = "Hard"
            };

            VideoTutorials.Add(tutorial7);

            var tutorial8 = new VideoTutorialData
            {
                Video = "null8",
                Title = "Test Video8",
                Source = ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Focus = "Jumping8",
                Description = "This is to practice your jumping",
                UserLevel = "Master"
            };

            VideoTutorials.Add(tutorial8);
        }

        private DelegateCommand<VideoTutorialData> itemTappedCommand;

        public DelegateCommand<VideoTutorialData> ItemTappedCommand => itemTappedCommand ?? (itemTappedCommand = new DelegateCommand<VideoTutorialData>(ExecuteItemTappedCommand));

        public void ExecuteItemTappedCommand(VideoTutorialData selectedWorkout)
        {
            NavigationParameters Parameters = new NavigationParameters
            {
                { "tutorial", selectedWorkout }
            };
            TestableNavigation.TestableNavigateAsync(NavigationService, nameof(Views.VideoTutorialDetailPage), Parameters, false, true).ConfigureAwait(false);

        }

    }
}
