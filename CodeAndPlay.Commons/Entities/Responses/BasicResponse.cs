namespace CodeAndPlay.Commons.Entities.Responses
{
    public class BasicResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public BasicResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}