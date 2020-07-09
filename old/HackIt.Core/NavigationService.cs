using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace HackIt.Core
{
    public static class NavigationService
    {
        public static Control Container { get; set; }

        public static void Navigate(INavigatable nav)
        {
            var ctrl = nav as Control;

            Container.Controls.Clear();
            ctrl.Dock = DockStyle.Fill;

            nav.OnNavigate();

            Container.Controls.Add(ctrl);
        }

        public static LinkLabel[] CreateLinks(IEnumerable<Type> types, Action<LinkLabel> initiator = null)
        {
            var r = new List<LinkLabel>();
            foreach (var t in types)
            {
                var cntrl = Activator.CreateInstance(t);
                var nav = cntrl as INavigatable;

                if (nav != null)
                {
                    var l = new LinkLabel();

                    if (nav.Title == "") continue;
                    
                    l.Tag = cntrl;
                    l.Text = nav.Title;
                    l.AutoSize = true;
                    l.Margin = new Padding(5);
                    l.Padding = new Padding(5);
                    l.Font = new System.Drawing.Font("Consolas", 10);
                    l.LinkBehavior = LinkBehavior.HoverUnderline;

                    l.LinkClicked += (s, e) =>
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