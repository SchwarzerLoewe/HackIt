namespace HackIt.Core.Models
{
    public class Credential
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public static Credential Empty { get; set; } = new Credential();
    }
}