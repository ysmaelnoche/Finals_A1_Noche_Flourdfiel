using System;
using System.Collections.Generic;

namespace backend.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public List<string> ImageUrls { get; set; }
        public int PrepTime { get; set; } // in minutes
        public int CookTime { get; set; } // in minutes
        public List<string> Ingredients { get; set; }
        public List<string> Steps { get; set; }
        public string CulturalContext { get; set; }
        public string Difficulty { get; set; } // Easy, Medium, Hard
        public List<string> Tags { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
} 