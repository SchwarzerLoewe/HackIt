using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HackIt.Core
{
    public class Command
    {
        public string Name { get; set; }
        public string[] Args { get; set; }

        public static Command Parse(string src)
        {
            var cmd = new Command();

            var parsed = src.Split('"')
                     .Select((element, index) => index % 2 == 0  // If even index
                                           ? element.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)  // Split the item
                                           : new string[] { element })  // Keep the entire item
                     .SelectMany(element => element).ToList();

            cmd.Name = parsed[0];
            parsed.RemoveAt(0);

            cmd.Args = parsed.ToArray();

            return cmd;
        }

        public override string ToString() => Name + " " + string.Join(" ", Args);
    }
}