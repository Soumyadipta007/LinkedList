using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SearchAndFindNode()
        {
            LinkedListClass list = new LinkedListClass();
            list.Add1(56);
            list.Add1(30);
            list.Add1(70);
            Node node=list.Search(30);
            Assert.AreEqual(30, node.data);
        }
    }
}
