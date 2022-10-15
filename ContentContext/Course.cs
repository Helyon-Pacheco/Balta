using System.Collections.Generic;
using Balta.ContentContext.Enums;

namespace Balta.ContentContext
{
    public class Course : Content {
        public Course(string title, string url, string tag, IList<Module> modules, int durationInMinutes, EContentLevel level) : base(title, url)
        {
            Modules = new List<Module>();
            Tag = tag;
            Modules = modules;
            DurationInMinutes = durationInMinutes;
            Level = level;
        }

        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}