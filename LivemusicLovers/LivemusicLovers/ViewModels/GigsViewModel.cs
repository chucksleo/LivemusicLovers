using LivemusicLovers.Models;
using System.Collections.Generic;
using System.Linq;

namespace LivemusicLovers.ViewModels
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
        public string Heading { get; set; }
    }
}