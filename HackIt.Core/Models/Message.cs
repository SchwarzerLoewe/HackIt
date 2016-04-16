using Mustache;

namespace HackIt.Core.Models
{
    public class Message
    {
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void Template(Computer host)
        {
            Content = new FormatCompiler().Compile(Content).Render(host);
        }
    }
}