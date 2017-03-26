using System;

namespace ParseNodes
{
    public class ExitNode
    {
        public string ExitNodeId { get; set; }
        public DateTime Published { get; set; }
        public DateTime LastStatus { get; set; }
        public string ExitAddress { get; set; }
    }
}