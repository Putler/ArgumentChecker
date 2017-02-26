namespace ArgumentChecker.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void DoItTrue_Test()
        {
            var testObject = new Class1();
            var result = testObject.DoIt(5);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void DoItFalse_Test()
        {
            var testObject = new Class1();
            var result = testObject.DoIt(-1);
            Assert.IsFalse(result);
        }
    }
}