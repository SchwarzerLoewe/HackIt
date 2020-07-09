using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace HackIt.Core
{
    public static class Utils
    {
        public static IPAddress GenerateIP(int seed)
        {
            var rndm = new Random(seed);
            return IPAddress.Parse(string.Format("{0}.{1}.{2}.{3}", rndm.Next(0, 255), rndm.Next(0, 255), rndm.Next(0, 255), rndm.Next(0, 255)));
        }

        public static string[] ToArray(this ListBox.ObjectCollection src)
        {
            var res = new List<string>();

            foreach (var item in src)
            {
                res.Add(item.ToString());
            }

            return res.ToArray();
        }
    }
}
