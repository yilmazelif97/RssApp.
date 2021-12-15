using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssApp.Models
{

    public enum Priority
    {
        One,
        Two,
        Three
    }
    public class RssInfo
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string URL { get; set; }
        public int Priority { get; set; }






    }
}
