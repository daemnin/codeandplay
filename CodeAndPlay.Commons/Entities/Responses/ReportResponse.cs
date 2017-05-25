using System.Collections.Generic;

namespace CodeAndPlay.Commons.Entities.Responses
{
    public class ReportResponse : BasicResponse
    {
        public IEnumerable<Report> Reports { get; set; }

        public ReportResponse(bool success, string message, IEnumerable<Report> reports)
            : base(success, message)
        {
            Reports = reports;
        }
    }
}
