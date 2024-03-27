namespace LoginRegistrationApp.Controllers.Models
{
    public class Registration
    {
        public int PF_NO { get; set; }
        public required string USER_NAME { get; set; }
        public required string EMAIL_ID{ get; set; }
        public required string PASSWORD { get; set; }
        public int IS_ACTIVE { get; set; }
    }
}
