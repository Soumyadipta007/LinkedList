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
        [TestMethod]
        public void InsertAtPosition()
        {
            LinkedListClass list = new LinkedListClass();
            list.Add1(56);
            list.Add1(30);
            list.Add1(70);
            list.InsertAtParticularPosition(3, 40);
            int position = list.findPosition(40);
            Assert.AreEqual(3, 3);
        }
        [TestMethod]
        public void DeleteAndGetSize()
        {
            LinkedListClass list = new LinkedListClass();
            list.Add1(56);
            list.Add1(30);
            list.Add1(40);
            list.Add1(70);
            list.DeleteNode(40);
            int size = list.size();
            Assert.AreEqual(3, 3);
        }
    }
}
