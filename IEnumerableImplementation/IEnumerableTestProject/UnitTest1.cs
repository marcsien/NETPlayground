using IEnumerableTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace IEnumerableTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DummyTestMethod()
        {
            List<Document> l = new List<Document>();
            Assert.IsTrue(l is IEnumerable<Document>);
        }

        [TestMethod]
        public void CustomCollectionImplementsIEnumerable()
        {
            CustomCollection collection = new CustomCollection();
            Assert.IsTrue(collection is IEnumerable<Document>);
        }
    }
}
