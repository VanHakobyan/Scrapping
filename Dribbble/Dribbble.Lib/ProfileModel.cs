using System.Collections.Generic;

namespace Dribbble.Lib
{
    public class ProfileModel
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Location { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        public List<string> OnTeams { get; set; } = new List<string>();
        public List<string> Elsewhere { get; set; } = new List<string>();
        public List<Project> Projects { get; set; } = new List<Project>();
        public List<string> Featured { get; set; } = new List<string>();
    }

    public class Project
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Shots { get; set; }
    }
}