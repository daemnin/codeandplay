namespace CodeAndPlay.Business.Commons
{
    public class Constants
    {
        public const string CTRL_NUM_PATTERN = @"^\d{8,8}$";
        public const string TEAM_NAME_PATTERN = @"^[\s\w.:]{3,25}$";
        public const string PASSWORD_PATTERN = @"^[\w]{8,}$";
        public const string USERNAME_PATTERN = @"^[\w]{8,}$";
        public const string STUDENT_NAME_PATTERN = @"^[\w]+$";
    }
}
