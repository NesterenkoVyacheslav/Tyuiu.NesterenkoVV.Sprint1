using Tyuiu.NesterenkoVV.Sprint1.Task4.V15.Lib;
namespace Tyuiu.NesterenkoVV.Sprint1.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpresion()
        {
            DataService ds= new DataService();
            double x =1 ;
            double y =0.5;
            double wait = 1.25;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);

        }
    }
}
