using Tyuiu.NesterenkoVV.Sprint1.Task7.V9.Lib;
namespace Tyuiu.NesterenkoVV.Sprint1.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds=new DataService();
            Double x = 0;
            Double y = 0;
            double wait = 1.503;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
