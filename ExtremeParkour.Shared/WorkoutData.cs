using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ExtremeParkour.Shared
{
    public class WorkoutData
    {
        
        public ImageSource Source { get; set; }
        public byte[] Image { get; set; }
        public string ImageName { get; set; }
        public string VideoSource { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Difficulty { get; set; }

    }
}
