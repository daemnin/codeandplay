using System;

namespace CodeAndPlay.Commons.Entities.Responses
{
    public class AuthResponse : BasicResponse
    {
        public AuthResponse(bool success, string message, string token, DateTime expiration)
            : base(success, message)
        {
            Token = token;
            Expiration = expiration;
        }

        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
