using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace HackIt.Core
{
    public class PreLoader<T>
    {
        private Dictionary<string, T> resources =
          new Dictionary<string, T>();

        public T Get(string s) => load(s);

        private T load(string s, Func<string, T> loader = null)
        {  
            lock (resources)
            {
                if (!resources.ContainsKey(s))
                {
                    var res = loader(s);
                    if (loader != null)
                    {
                        resources.Add(s, res);
                    }

                    return res;
                }
                return resources[s];
            }
        }

        public void PreLoad(Func<string, T> loader = null, params string[] src)
        {  // non-blocking preloading call
            foreach (string img in src)
            {
                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += (s, e) => { load(img, loader); };  // discard the actual image return
                bw.RunWorkerAsync();
            }
        }
    }
}