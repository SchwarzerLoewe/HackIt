using Avalonia;
using Avalonia.Controls;
using System;
using System.Collections.Generic;

namespace HackIt.Core
{
    public static class NavigationService
    {
        public static Grid Container { get; set; }

        public static void Navigate(INavigatable nav)
        {
            var ctrl = nav as Control;

            Container.Children.Clear();

            nav.OnNavigate();

            Container.Children.Add(ctrl);
        }

        public static Button[] CreateLinks(IEnumerable<Type> types, Action<Button> initiator = null)
        {
            var r = new List<Button>();
            foreach (var t in types)
            {
                var cntrl = Activator.CreateInstance(t);
                var nav = cntrl as INavigatable;

                if (nav != null)
                {
                    var l = new Button();

                    if (nav.Title == "") continue;
                    
                    l.Tag = cntrl;
                    l.Content = nav.Title;
                    l.Margin = new Thickness(5);
                    l.Padding = new Thickness(5);
                    l.FontFamily = new Avalonia.Media.FontFamily("Consolas");
                    l.FontSize = 10;

                    l.Click += (s, e) =>
                    {
                        Navigate(nav);
                    };

                    initiator?.Invoke(l);

                    r.Add(l);
                }
            }

            return r.ToArray();
        }
    }
}