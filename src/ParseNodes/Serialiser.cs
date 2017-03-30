using System;
using System.Collections.Generic;
using System.Linq;

namespace ParseNodes
{
    public class Serialiser
    {
        public List<ExitNode> SerialiseExitNodes(string nodeData)
        {
            List<string> splitList = nodeData.Split('\n').ToList();
            List<ExitNode> exitNodes = new List<ExitNode>();
            ExitNode exitNode = new ExitNode();
            foreach (string line in splitList)
            {   
                string strippedLine = StripString(line);
                if (line.Contains("ExitNode"))
                {
                    exitNode.ExitNodeId = strippedLine;
                }
                if (line.Contains("Published"))
                {
                    exitNode.Published = Convert.ToDateTime(strippedLine);
                }
                if (line.Contains("LastStatus"))
                {
                    exitNode.LastStatus = Convert.ToDateTime(strippedLine);
                }
                if (line.Contains("ExitAddress"))
                {
                    exitNode.ExitAddress = strippedLine.Substring(0, strippedLine.IndexOf(" ", StringComparison.Ordinal));
                }
                if (exitNode.ExitNodeId != null && exitNode.ExitAddress != null && !exitNode.LastStatus.Equals(DateTime.MinValue) && !exitNode.Published.Equals(DateTime.MinValue))
                {
                    exitNodes.Add(exitNode);
                    exitNode = new ExitNode();
                }
            }
            return exitNodes;
        }

        private string StripString(string stripable)
        {
            stripable = stripable.Replace("ExitNode", string.Empty);
            stripable = stripable.Replace("Published", string.Empty);
            stripable = stripable.Replace("LastStatus", string.Empty);
            stripable = stripable.Replace("ExitAddress", string.Empty);
            return stripable.Trim();
        }
    }
}