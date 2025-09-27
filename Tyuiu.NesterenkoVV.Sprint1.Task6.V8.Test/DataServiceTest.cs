using Tyuiu.NesterenkoVV.Sprint1.Task6.V8.Lib;
namespace Tyuiu.NesterenkoVV.Sprint1.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string Text = "тёмный двор";
            var res = ds.MoveLetterToEnd(Text);
            string wait = "ёмныйт ворд";
            Assert.AreEqual(wait, res);
        }
    }
}
