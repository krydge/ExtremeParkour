﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtremeParkourAPI
{
    public class Workouts
    {
        public byte[] Source { get; set; }
        public string ImageName { get; set; }
        public byte[] Video { get; set; }
        public string VideoName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Difficulty { get; set; }
    }
}