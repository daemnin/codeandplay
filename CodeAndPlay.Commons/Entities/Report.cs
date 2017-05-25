namespace CodeAndPlay.Commons.Entities
{
    public class Report
    {
        public int ControlNumber { get; set; }
        public string FullName { get; set; }
        public int Semester { get; set; }

        public string Workshop { get; set; }

        public string TeamName { get; set; }

        public bool IsTeamLeader { get; set; }

        public int Attendance { get; set; }
    }
}
