using System.Collections.Generic;

namespace HackIt.UI
{
    public class Grid
    {
        public List<Header> Headers { get; set; } = new List<Header>();
        public List<string> Entries { get; set; } = new List<string>();

        public Point Location { get; set; }
        public int EntriesPerPage { get; set; } = 5;
        public int Page { get; set; }

        public void AddToForm(ConsoleForm form)
        {
            form.FormComplete += (s, e) =>
            {
                Page++;
            };

            var divider = new Label("divider", new Point(Location.X, 5), 60, "______________________________________________________________________");

            Point p = new Point(Location.X, Location.Y);
            foreach (var h in Headers)
            {
                var l = new Label(h.Name, p, h.Length, h.Title);

                form.Labels.Add(l);
                p = new Point(h.Length + 10, Location.Y);
            }

            form.Labels.Add(divider);

            int _index = 0;
            for (int i = _index; i < EntriesPerPage; i++)
            {
                if ((Page + i) == Entries.Count)
                    break;

                Label lbl =
                        new Label("lblIndex" + i,
                                                    new Point(Location.X, i + 7),
                                                        Entries[i].Length,
                                                        Entries[i]);

                form.Labels.Add(lbl);
            }
        }
    }

    public class Header
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
    }
}