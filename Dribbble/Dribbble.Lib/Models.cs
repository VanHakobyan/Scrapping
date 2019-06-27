namespace Dribbble.Lib
{


    public class Root
    {
        public int user_id { get; set; }
        public Shot[] shots { get; set; }
    }

    public class Shot
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public bool animated { get; set; }
        public object multi_shot { get; set; }
        public string description { get; set; }
        public string[][] ga { get; set; }
        public string img { get; set; }
        public string img_hidpi { get; set; }
        public string media_type { get; set; }
        public Owner owner { get; set; }
        public string path { get; set; }
        public string title { get; set; }
        public string published_at { get; set; }
        public Video_Urls video_urls { get; set; }
    }

    public class Owner
    {
        public string path { get; set; }
        public string avatar { get; set; }
        public string name { get; set; }
        public bool pro { get; set; }
        public bool team { get; set; }
    }

    public class Video_Urls
    {
        public string small_preview { get; set; }
        public string large_preview { get; set; }
        public string xlarge_preview { get; set; }
    }

}