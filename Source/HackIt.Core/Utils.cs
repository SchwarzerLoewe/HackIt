using System;
using System.Net;

namespace HackIt.Core
{
    public static class Utils
    {
        public static IPAddress GenerateIP(int seed)
        {
            var rndm = new Random(seed);
            return IPAddress.Parse(string.Format("{0}.{1}.{2}.{3}", rndm.Next(0, 255), rndm.Next(0, 255), rndm.Next(0, 255), rndm.Next(0, 255)));
        }
    }
}
