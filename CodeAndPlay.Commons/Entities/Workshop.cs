
using System;
using System.Collections.Generic;

namespace CodeAndPlay.Commons.Entities
{
    public class Workshop
    {
        public int Id { get; set; }
        public string Instructor { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int GroupSize { get; set; }
        public DateTime End { get; set; }
        public DateTime Start { get; set; }
        public IEnumerable<Requirement> Requirements { get; set; }
        public int Duration { get; set; }
        public int AvailableSlots { get; set; }
    }
}
