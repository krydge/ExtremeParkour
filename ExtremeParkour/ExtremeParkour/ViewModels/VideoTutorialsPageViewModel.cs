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
    public class VideoTutorialsPageViewModel : ViewModelBase
    {
        private readonly IExtremeParkourService extremeParkourService;

        private List<VideoTutorialData> videos;

        private VTDApp video;

        private List<VTDApp> videoTutorials;
        public List<VTDApp> VideoTutorials
        {
            get => videoTutorials;
            set { SetProperty(ref videoTutorials, value); }
        }

        private IEnumerable<WeatherForecast> forecast;
        public IEnumerable<WeatherForecast> Forecast
        {
            get => forecast;
            set { SetProperty(ref forecast, value); }
        }


        public VideoTutorialsPageViewModel(INavigationService navigationService, IExtremeParkourService extremeParkourService)
            : base(navigationService)
        {
            Title = "VideoTutorialsPage";

            this.extremeParkourService = extremeParkourService;

            

            VideoTutorials = new List<VTDApp>();

            videos = (List<VideoTutorialData>)extremeParkourService.GetTutorialsAsync().Result;

            foreach (var i in videos)
            {
                video = new VTDApp();
                video.Description = i.Description;
                video.Focus = i.Focus;
                video.imageSource = ImageSource.FromResource(i.Source);
                video.Title = i.Title;
                video.UserLevel = i.UserLevel;
                video.VideoSource = i.VideoSource;

                VideoTutorials.Add(video);
            }

            /*
            var tutorial1 = new VTDApp
            {
                VideoSource = "null1",
                Source= "ExtremeParkour.Images.random-image.jpg",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Title = "Test Video1",
                Focus = "Jumping1",
                Description = "This is to practice your jumping",
                UserLevel = "Beginner"
            };

            VideoTutorials.Add(tutorial1);

            var tutorial2 = new VTDApp
            {
                VideoSource = "null2",
                Source = "ExtremeParkour.Images.random-image.jpg",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Title = "Test Video2",
                Focus = "Jumping2",
                Description = "This is to practice your jumping",
                UserLevel = "Intermediate"
            };

            VideoTutorials.Add(tutorial2);

            var tutorial3 = new VTDApp
            {
                VideoSource = "null3",
                Source = "ExtremeParkour.Images.random-image.jpg",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Title = "Test Video3",
                Focus = "Jumping3",
                Description = "This is to practice your jumping",
                UserLevel = "Hard"
            };

            VideoTutorials.Add(tutorial3);

            var tutorial4 = new VTDApp
            {
                VideoSource = "null4",
                Title = "Test Video4",
                Source = "ExtremeParkour.Images.random-image.jpg",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Focus = "Jumping4",
                Description = "This is to practice your jumping",
                UserLevel = "Master"
            };

            VideoTutorials.Add(tutorial4);

            var tutorial5 = new VTDApp
            {
                VideoSource = "null5",
                Source = "ExtremeParkour.Images.random-image.jpg",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Title = "Test Video5",
                Focus = "Jumping5",
                Description = "This is to practice your jumping",
                UserLevel = "Beginner"
            };

            VideoTutorials.Add(tutorial5);

            var tutorial6 = new VTDApp
            {
                VideoSource = "null6",
                Title = "Test Video6",
                Source = "ExtremeParkour.Images.random-image.jpg",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Focus = "Jumping6",
                Description = "This is to practice your jumping",
                UserLevel = "Intermediate"
            };

            VideoTutorials.Add(tutorial6);

            var tutorial7 = new VTDApp
            {
                VideoSource = "null7",
                Title = "Test Video7",
                Source = "ExtremeParkour.Images.random-image.jpg",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Focus = "Jumping7",
                Description = "This is to practice your jumping",
                UserLevel = "Hard"
            };

            VideoTutorials.Add(tutorial7);

            var tutorial8 = new VTDApp
            {
                VideoSource = "null8",
                Title = "Test Video8",
                Source = "ExtremeParkour.Images.random-image.jpg",
                imageSource = ImageSource.FromResource("ExtremeParkour.Images.random-image.jpg"),
                Focus = "Jumping8",
                Description = "This is to practice your jumping",
                UserLevel = "Master"
            };

            VideoTutorials.Add(tutorial8);*/
        }

        private DelegateCommand<VTDApp> itemTappedCommand;

        public DelegateCommand<VTDApp> ItemTappedCommand => itemTappedCommand ?? (itemTappedCommand = new DelegateCommand<VTDApp>(ExecuteItemTappedCommand));

        public void ExecuteItemTappedCommand(VTDApp selectedWorkout)
        {
            NavigationParameters Parameters = new NavigationParameters
            {
                { "tutorial", selectedWorkout }
            };
            TestableNavigation.TestableNavigateAsync(NavigationService, nameof(Views.VideoTutorialDetailPage), Parameters, false, true).ConfigureAwait(false);

        }


        public Command getWeather;
        public Command GetWeather => getWeather ?? (getWeather = new Command(async () =>
        {
            Forecast = await extremeParkourService.GetForecastAsync();
        }));
    }
}
