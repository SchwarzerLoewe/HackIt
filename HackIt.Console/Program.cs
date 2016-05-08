using HackIt.UI;

namespace HackIt.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var form = new ConsoleForm(80, 30);
            form.Name = "Grid";
            form.FormCancelled += (s, e) =>
            {
                System.Console.Clear();
                
                var h = System.Console.ReadLine();
            };
           
            var grid = new Grid();
            grid.Location = new Point(10, 4);

            grid.Headers.Add(new Header { Name = "name", Length = 6, Title = "Name" });
            grid.Headers.Add(new Header { Name = "size", Length = 6, Title = "Size" });

            grid.Entries.Add("Hello");
            grid.Entries.Add("World");

            grid.AddToForm(form);

            form.Render(true);
        }
    }
}