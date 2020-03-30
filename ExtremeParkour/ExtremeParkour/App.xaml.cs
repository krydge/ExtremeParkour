using Prism;
using Prism.Ioc;
using ExtremeParkour.ViewModels;
using ExtremeParkour.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ExtremeParkour
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<VideoTutorialsPage, VideoTutorialsPageViewModel>();
            containerRegistry.RegisterForNavigation<WorkoutsPage, WorkoutsPageViewModel>();
            containerRegistry.RegisterForNavigation<WorkoutDetailPage, WorkoutDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<VideoTutorialDetailPage, VideoTutorialDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<AdminControls, AdminControlsViewModel>();
            containerRegistry.RegisterForNavigation<AddWorkout, AddWorkoutViewModel>();
            containerRegistry.RegisterForNavigation<AddTutorial, AddTutorialViewModel>();
            
            var weatherAPI = RestService.For<IWeatherService>("--APILocation(Example--- ""Http//localhost");
            containerRegistry.RegisterInstance(weatherAPI);
        }
    }
}
