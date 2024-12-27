using Tyuiu.SilinEV.Sprint7.Project.V5.Lib;

namespace Tyuiu.SilinEV.Sprint7.Project.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ValidMinValue()
        {
            double[] matrix = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            Assert.AreEqual(ds.FindMinValue(matrix), 1);
        }

        [TestMethod]
        public void ValidMaxValue()
        {
            double[] matrix = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            Assert.AreEqual(ds.FindMaxValue(matrix), 14);
        }

        [TestMethod]
        public void ValidMiddleValue()
        {
            double[] matrix = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            Assert.AreEqual(ds.FindMiddleValue(matrix), 7.5);
        }

        [TestMethod]
        public void ValidSumValue()
        {
            double[] matrix = { 1, 2, 3, 4, 5 };

            Assert.AreEqual(ds.FindSumValue(matrix), 15);
        }
    }
}