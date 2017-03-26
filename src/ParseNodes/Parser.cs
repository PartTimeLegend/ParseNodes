using System;
using System.ComponentModel;
using System.IO;
using System.Net;

namespace ParseNodes
{
    public class Parser
    {
        public string GetExitNodes()
        {
            WebClient webClient = new WebClient();
            Stream data = webClient.OpenRead("https://check.torproject.org/exit-addresses");
            StreamReader streamReader = new StreamReader(data);
            string bigString = streamReader.ReadToEnd();
            Console.WriteLine(bigString);
            data.Close();
            streamReader.Close();
            streamReader.Dispose();
            data.Dispose();
            return bigString;
        }
    }
}
