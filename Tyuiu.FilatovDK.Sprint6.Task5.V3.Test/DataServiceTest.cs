using Tyuiu.FilatovDK.Sprint6.Task4.V13.Lib;
namespace Tyuiu.FilatovDK.Sprint6.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] expect = new double[len];

            expect[0] = -9.1;
            expect[1] = 1.55;
            expect[2] = 292.78;
            expect[3] = -0.57;
            expect[4] = -0.35;
            expect[5] = 2;
            expect[6] = 4.35;
            expect[7] = 4.57;
            expect[8] = -288.78;
            expect[9] = 2.45;
            expect[10] = 13.1;

            CollectionAssert.AreEqual(expect, ds.GetMassFunction(startValue, stopValue));
        }
    }
}