using Tyuiu.NesterenkoVV.Sprint1.Task5.V2.Lib;
namespace Tyuiu.NesterenkoVV.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 32;
            int wait = 0;
            var res = ds.FahrenheitToСelsius(x);
            Assert.AreEqual(wait, res);

        }
    }
}
