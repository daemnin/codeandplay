using System.Collections.Generic;

namespace CodeAndPlay.Commons.Entities
{
    public class Organizer
    {
        public string Name { get; set; }
        public IEnumerable<Role> Roles { get; set; }
    }
}
