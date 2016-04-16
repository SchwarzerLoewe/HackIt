using System.IO;
using System.Text;
using UILibrary;

namespace TestApp
{
    public class ShellWriter : TextWriter
    {
        private ShellControl shellControl1;

        public ShellWriter(ShellControl shellControl1)
        {
            this.shellControl1 = shellControl1;
        }

        public override Encoding Encoding => Encoding.ASCII;

        public override void Write(object value)
        {
            Write(value.ToString());
        }

        public override void Write(string value)
        {
            shellControl1.WriteText(value);
        }

        public override void WriteLine(string value)
        {
            Write(value + "\r\n");
        }

        public override void WriteLine(object value)
        {
            WriteLine(value.ToString());
        }
    }
}