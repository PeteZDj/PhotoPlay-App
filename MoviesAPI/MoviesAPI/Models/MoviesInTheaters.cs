﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Models
{
    public partial class MoviesInTheaters
    {
        public int? id { get; set; }
        public string actors{get;set;}
        public int? averageRating{get;set;}
        public string contentRating{get;set;}
        public string duration{get;set;}
        public string genres{get;set;}
        public double? imdbRating{get;set;}
        public string originalTitle{get;set;}
        public string poster{get;set;}
        public string posterurl{get;set;}
        public int? ratings {get;set;}
        public string releaseDate{get;set;}
        public string storyline{get;set;}
        public string title{get;set;}
        public int? year {get;set;}
    }
}
