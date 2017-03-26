using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParseNodes.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetExitNodeList()
        {
            Assert.IsNotNull(new Parser().GetExitNodes());
        }

        [TestMethod]
        public void SerialiseExitNodes()
        {
            Assert.IsNotNull(new Serialiser().SerialiseExitNodes(new Parser().GetExitNodes()));
        }
    }
}
