using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleLibrary;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckConcatMethod()
        {
         string Value=  Class1.GetTextFile1ContainsWithConcat();
            Assert.AreEqual(Value, "Hello World");
        }

        [TestMethod]
        public void CheckCombineMethod()
        {
            string Value = Class1.GetTextFile1ContainsWithCombine();
            Assert.AreEqual(Value, "Hello World");
        }
    }
}
