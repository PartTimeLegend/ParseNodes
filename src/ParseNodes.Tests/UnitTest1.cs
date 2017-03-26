using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParseNodes.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, TestCategory("Get Exit Nodes")]
        public void GetExitNodeList()
        {
            Assert.IsNotNull(new Parser().GetExitNodes());
        }

        [TestMethod, TestCategory("Serialise Exit Nodes")]
        public void SerialiseExitNodes()
        {
            Assert.IsNotNull(new Serialiser().SerialiseExitNodes(new Parser().GetExitNodes()));
        }
    }
}
