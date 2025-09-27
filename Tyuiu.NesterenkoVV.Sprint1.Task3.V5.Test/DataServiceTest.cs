using Tyuiu.NesterenkoVV.Sprint1.Task3.V5.Lib;
namespace Tyuiu.NesterenkoVV.Sprint1.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 115.3;
            double wait = 576.5;
            var res = ds.DistanceLength(x, y);
            Assert.AreEqual(wait, res);


        }
    }
}
