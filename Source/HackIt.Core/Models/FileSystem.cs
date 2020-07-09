using System;
using System.Collections.Generic;
using System.Linq;

namespace HackIt.Core.Models
{
    public class FileSystem
    {
        public Directory Root { get; set; } = new Directory();

        public NameBase Find(string query)
        {
            var spl = query.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            NameBase current = null;

            foreach (var q in spl)
            {
                if (Root.Name == q)
                {
                    current = Root;
                    continue;
                }
                if (spl.Length == 1)
                {
                    current = Root;
                }

                if (current == null) throw new System.IO.DirectoryNotFoundException(q + " not found");

                foreach (var item in ((Directory)current).Items)
                {
                    if (item.Name == q)
                    {
                        current = item;
                    }
                }
            }

            //if (current == Root) throw new System.IO.FileNotFoundException(spl.Last() + " not found");

            return current;
        }

        public void Mkdir(string path, string name)
        {
            var dir = new Directory();
            dir.Name = name;

            var p = Find(path) as Directory;
            if (p != null)
            {
                p.Items.Add(dir);
            }
        }
        public void MkFile(string path, string name)
        {
            var dir = new File();
            dir.Name = name;

            var p = Find(path) as Directory;
            if (p != null)
            {
                p.Items.Add(dir);
            }
        }
    }

    public class Directory : NameBase
    {
        public List<NameBase> Items { get; set; } = new List<NameBase>();
    }
    public class File : NameBase
    {

    }
    public abstract class NameBase
    {
        public string Name { get; set; }
    }
}